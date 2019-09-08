using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Irony.Ast;
using Irony.Parsing;


namespace AnalizadorLexico
{
    public partial class Form1 : Form
    {
        int CARACTER;
        bool cambios = false;
        public Form1()
        {
            InitializeComponent();
        }
        RegexLexer csLexer = new RegexLexer();
        bool load;
        List<string> palabrasReservadas;
        List<TablaSimbolos> ts = new List<TablaSimbolos>();

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            CARACTER = 0; //SE INICIALIZA A 0 EN CADA REPINTADO
            int ALTURA = textoCodigo.GetPositionFromCharIndex(0).Y - 1;//coordenada del primer caracter


            if (textoCodigo.Lines.Length > 0)//si hay alguna linea las recorrera todas y escribira numero
            {
                for (int i = 0; i < textoCodigo.Lines.Length; i++)
                {
                    e.Graphics.DrawString(Convert.ToString(i + 1), textoCodigo.Font, Brushes.Firebrick, pictureBox1.Width - (e.Graphics.MeasureString(Convert.ToString(i + 1), textoCodigo.Font).Width + 10), ALTURA);
                    CARACTER = CARACTER + textoCodigo.Lines[i].Length + 1;
                    //MessageBox.Show(Convert.ToString(textoCodigo.Lines.Length));
                    ALTURA = textoCodigo.GetPositionFromCharIndex(CARACTER).Y;
                }
            }
            else
            {
                e.Graphics.DrawString("1", textoCodigo.Font, Brushes.Firebrick, pictureBox1.Width - (e.Graphics.MeasureString("1", textoCodigo.Font).Width + 10), ALTURA);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer1.Interval = 10;
            Timer1.Start();
            String cad = "\".*?\"";
            csLexer.AddTokenRule(@"usando\s+[a-zA-Z]+\s*;", "DIRECTIVA");
            csLexer.AddTokenRule(@"publico\s+[_a-zA-Z]\w+\s*\(\s*\)\s*{\s*}", "CONSTRUCTOR");
            csLexer.AddTokenRule(@"spacename\s+[a-zA-Z]+\s*\{\s*\}", "NOMBRE_DEL_ESPACIO");
            csLexer.AddTokenRule(@"clase\s+[a-zA-Z]+\s*\{\s*\}", "CLASE");
            csLexer.AddTokenRule(@"estatico\s+vacio\s+\w+\d*\s*\(\s*cadena\s*\[\]\s+argumento\s*\)\s*\{\s*\}", "PSVM");
            csLexer.AddTokenRule(@"publico\s+vacio\s+[_a-zA-Z]+[0-9]*\s*\(\s*\)\{\s*\}", "METODO_VACIO");
            csLexer.AddTokenRule(@"(para\s*\(\s*variable\s+\w.*\s*=\s*\d+\s*;\s*\w.*[<|>|<=|>=]\s*\d+\s*;\s*\w.*[\+\+|\-\-]\s*\)\s*{\s*})|(mientras\s*\(\s*\w.*\s*[<|>|<=|>=]\s*\d+\s*\)\s*{\s*})|(hacer\s*{\s*}mientras\s*\(expresion\)\s*;)", "CICLO");
            csLexer.AddTokenRule(@"mientras\s*\(\s*verdadero\s*\)\s*{\s*}", "CICLO_INFINITO");
            csLexer.AddTokenRule(@"si\s*\(\s*\w+\d*\s*(==|!=|>|<|<=|>=)\s*([+|-]?\d+(\.\d+)?)\s*\)\s*{\s*}\s?(sino\s*\(\s*\w+\d*\s*(==|!=|>|<|<=|>=)\s*([+|-]?\d+(\.\d+)?)\s*\)\s*{\s*}\s?)?(otrocaso\s*{\s*})?", "CONDICIONAL_NUMERICA");
            csLexer.AddTokenRule(@"si\s*\(\s*\w+\d*\s*(==|!=)\s*([+|-]?\d+(\.\d+)?|'[^\\]'|" + cad + @")\s*\)\s*{\s*}\s?(sino\s*\(\s*\w+\d*\s*(==|!=)\s*([+|-]?\d+(\.\d+)?|'[^\\]'|" + cad + @")\s*\)\s*{\s*}\s?)?(otrocaso\s*{\s*})?", "CONDICIONAL_CADENA-CARACTER");
            csLexer.AddTokenRule(@"(variable\s+[_a-zA-Z]+\s*=\s*[_a-zA-Z]+\s*;)|(variable\s+[_a-zA-Z]+\s*=\s*[-|+]?\d*\.?\d+\s*;)", "DECLARACION_GENERAL");
            csLexer.AddTokenRule(@"cadena\s+[_a-zA-Z]+[0-9]*\s*=\s*" + cad + @"\s*;", "DECLARACION_CADENA");
            csLexer.AddTokenRule(@"entero\s+[_a-zA-Z]+[0-9]*\s*=\s*[+|-]?[0-9]+\s*;", "DECLARACION_ENTERO");
            csLexer.AddTokenRule(@"doble\s+[_a-zA-Z]+[0-9]*\s*=\s*[-|+]?\d*\.?\d+;", "DECLARACION_DOBLE");
            csLexer.AddTokenRule(@"flotante\s+[_a-zA-Z]+[0-9]*\s*=\s*[-|+]?\d*\.?\d+;", "DECLARACION_FLOTANTE");
            csLexer.AddTokenRule(@"caracter\s+\w+\s*=\s*'[^\\]';", "DECLARACION_CARACTER");
            csLexer.AddTokenRule(@"booleano\s+\w+\s*=\s*(falso|verdadero);", "DECLARACION_BOOLEANO");
            csLexer.AddTokenRule(@"publico\s+(entero|cadena|doble|flotante|booleano|caracter)\s+[_a-zA-Z]\w*\d*\s*\(\s*\)\s*{\s*retorno\s+\w*\s*;\s*}", "METODO_RETORNANTE");
            csLexer.AddTokenRule(@"(entero|cadena|doble|flotante|booleano|caracter)\[\s*\]\s+[_a-zA-Z]+\d*\s*=\s*nuevo\s*(entero|cadena|doble|flotante|booleano|caracter)\s*\[\s*\d+\s*\]", "DECLARACION_VECTOR");
            csLexer.AddTokenRule(@"(entero|cadena|doble|flotante|booleano|caracter)\[\s*\]\[\s*\]\s+[_a-zA-Z]+\d*\s*=\s*nuevo\s*(entero|cadena|doble|flotante|booleano|caracter)\s*\[\s*\d+\s*\]\[\s*\d+\s*\]", "DECLARACION_MATRIZ");
            csLexer.AddTokenRule(@"(Consola\.EscribirLinea\(\);)|Consola\.LeerLinea\(\);", "CONSOLA");
            csLexer.AddTokenRule(@"\t", "TABULACION"); //  
            //csLexer.AddTokenRule(@"\n+", "SALTO_DE_LINEA");
            csLexer.AddTokenRule(@"\s+", "ESPACIO", true);//true
            csLexer.AddTokenRule(@"AND|OR|NAND|NOR|NOT", "OPERADOR_LOGICO");
            csLexer.AddTokenRule(@"\b[_a-zA-ZñÑáéíóúÁÉÍÓÚ][\w]*\b", "VARIABLE");
            csLexer.AddTokenRule("\".*?\"", "CADENA");
            csLexer.AddTokenRule(@"'\\.'|'[^\\]'", "CARACTER");
            csLexer.AddTokenRule(@"//[^\r\n]*", "COMENTARIO1");
            csLexer.AddTokenRule(@"/[*].*?[*]/", "COMENTARIO2");
            csLexer.AddTokenRule(@"\..[^\n]*", "COMENTARIO3");
            csLexer.AddTokenRule(@"[-|+]?\d*\.?\d+", "NUMERO");
            csLexer.AddTokenRule(@"[\(\)\{\}\[\];,]", "DELIMITADOR");
            csLexer.AddTokenRule(@">|<|==|>=|<=|!|!=", "COMPARADOR");
            csLexer.AddTokenRule(@"\+\+|\-\-", "ACUMULADOR");
            csLexer.AddTokenRule(@"[=\+\-/*%]|\^|\√", "OPERADOR");
            csLexer.AddTokenRule(@"\\n|\\r", "RETORNO");
            csLexer.AddTokenRule(@"\.", "REFERENCIADOR");

            //csLexer.AddTokenRule(@"\0","NULO");


            palabrasReservadas = new List<string>() { "abstracto", "como", "asincrono", "espera",
                "checado", "const", "continuar", "defecto", "delegate", "base", "romper", "caso",
                "hacer", "sino", "enumerar", "evento", "explicito", "externo", "falso", "finalmente",
                "arreglado", "para", "paracadauno", "ir_a", "si", "implicito", "en", "interface",
                "interno", "es", "cerrado", "nuevo", "nulo", "operador","atrapar",
                "fuera", "anular", "parametros", "privado", "protegido", "publico", "leersolo",
                "referencia", "retorno", "sellado", "tamañode", "apilar_todo", "estatico",
                "interruptor", "este", "tirar", "verdadero", "intentar", "tipo_de", "nombre_espacio",
                "nochecado", "inseguro", "virtual", "vacio", "mientras", "flotante", "entero", "largo", "objeto",
                "obtener", "poner", "parcial", "rendimiento", "añadir", "remover", "valor", "alias", "ascendiente",
                "descendiente", "de", "grupo", "dentro", "ordenpor", "seleccionar", "donde",
                "unir", "igual", "usando","booleano", "byte", "caracter", "decimal", "doble", "dinamico",
                "sbyte", "corto", "cadena", "uentero", "ulargo", "ucorto", "variable", "clase", "estructura","spacename","otrocaso" };

            csLexer.Compile(RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.ExplicitCapture);

            load = true;
            AnalizeCode();
            textoCodigo.Focus();

            LlenadoTablaSimbolos();
        }

        public void LlenadoTablaSimbolos()
        {
            //Llenado de palabras reservadas semántico
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "usando", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "sistema", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "spacename", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "publico", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "privado", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "protegido", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "clase", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "estatico", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "vacio", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "principal", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "cadena", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "argumento", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "si", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "sino", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "variable", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "entero", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "largo", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "doble", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "flotante", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "caracter", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "cadena", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "booleano", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "falso", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "verdadero", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "para", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "mientras", null));
            ts.Add(new TablaSimbolos("Reservada", "Reservada", "nuevo", null));
        }

        private void AnalizeCode()
        {
            //dtgToken.clear;
            dtgToken.Rows.Clear();
            int n = 0, e = 0;

            foreach (var tk in csLexer.GetTokens(textoCodigo.Text))
            {
                if (tk.Name == "ERROR NO EXISTE CARACTER") ;

                if (tk.Name == "VARIABLE")
                    if (palabrasReservadas.Contains(tk.Lexema))
                        tk.Name = "RESERVADO DEL SISTEMA";
                dtgToken.Rows.Add(tk.Name, tk.Lexema, tk.Linea, tk.Columna, tk.Index);
                //lvToken.Items.Add(tk.ToString());
                n++;
            }

            //this.title = string.Format("Analizador Lexico - {0} tokens {1} errores", n, e);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.BackColor = Color.FromArgb(26, 32, 40);
        }
        private void btnNuevo_MouseEnter(object sender, EventArgs e)
        {
            btnNuevo.BackColor = Color.White;
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnres.Visible = true;
            btnmaxi.Visible = false;
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnmaxi.Visible = true;
            btnres.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (cambios == true && textoCodigo.TextLength != 0)
            {
                DialogResult dialog = MessageBox.Show("No ha guardado cambios, ¿Desea guardar cambios?", "Finalizar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    GuardarArchivo();
                    Application.Exit();
                }
                else if (dialog == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {

                }
            }
            else
            {
                if (MessageBox.Show("¿Desea cerrar el programa?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

        }

        private void textoCodigo_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
            bool resultado = Sintactico.analizar(textoCodigo.Text);
            if (resultado)
            {
                textoCodigo.ForeColor = Color.Black;
            }
            else
            {
                textoCodigo.ForeColor = Color.Red;
            }
            if (textoCodigo.TextLength == 0)
            {
                dtgToken.Rows.Clear();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (cambios == true)
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", "ADAMANT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GuardarArchivo();
                    textoCodigo.Clear();
                    dtgToken.Rows.Clear();
                }
                else
                {
                    textoCodigo.Clear();
                    dtgToken.Rows.Clear();
                }
                cambios = false;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OFD.Filter = "Documento adamant|*.ada";
            OFD.Title = "Abrir código";
            OFD.FileName = "";
            var resultado = OFD.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(OFD.FileName);
                textoCodigo.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void btnCompilar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textoCodigo.TextLength == 0)
                    MessageBox.Show("No se puede compilar esta vacío");
                else
                if (load == true)
                    AnalizeCode();
                bool resultado = Sintactico.analizar(textoCodigo.Text);
                dtgSemantico.Rows.Clear();
                ParseTree arbol = Sintactico.retornoArbol(textoCodigo.Text);
                RecorridoParseTree recorrido = new RecorridoParseTree(arbol);
                var nodos = recorrido.Recorrer();
                int con = 0;
                int menor = 0, mayor = 0;
                foreach (var item in nodos)
                {
                    //MessageBox.Show("#" + con.ToString()
                    //+ " *ITEM: " + item.ToString()
                    //+ " *associativity: " + item.Associativity.ToString()
                    //+ " *Span End position: " + item.Span.EndPosition
                    //+ " *Span Length: " + item.Span.Length
                    //+ " *Span : Location" + item.Span.Location
                    //+ " *Term: " + item.Term.ToString()
                    //+ " *TermErrorAlias: " + item.Term.ErrorAlias
                    //+ " *itemtermName: " + item.Term.Name);


                    if (item.Term.Name.Equals("Declaracion"))
                    {
                        String tipodedato = null, variable = null, valor = null;
                        menor = item.Span.EndPosition - item.Span.Length;
                        mayor = item.Span.EndPosition;


                    //    MessageBox.Show("#" + con.ToString()
                    //+ " *ITEM: " + item.ToString()
                    //+ " *associativity: " + item.Associativity.ToString()
                    //+ " *Span End position: " + item.Span.EndPosition
                    //+ " *Span Length: " + item.Span.Length
                    //+ " *Span : Location" + item.Span.Location
                    //+ " *Term: " + item.Term.ToString()
                    //+ " *TermErrorAlias: " + item.Term.ErrorAlias
                    //+ " *itemtermName: " + item.Term.Name);
                        //
                        #region Agregado de variables declaradas
                        foreach (var item1 in nodos)
                        {

                            if ((item1.Term.Name.Equals("tipodedato") || item1.Term.Name.Equals("id") || item1.Term.Name.Equals("numero") || item1.Term.Name.Equals("numero-decimal") || item1.Term.Name.Equals("cualquier") || item1.Term.Name.Equals("cualquiercar")) && (item1.Span.EndPosition <= mayor && (item1.Span.EndPosition - item1.Span.Length) >= menor))
                            {
                                if (item1.Term.Name.Equals("tipodedato"))
                                {
                                    tipodedato = item1.ToString().Split(' ').ElementAt(0);
                                    //MessageBox.Show(tipodedato);
                                }
                                if (item1.Term.Name.Equals("id"))
                                {
                                    variable = item1.ToString().Split(' ').ElementAt(0);
                                    //MessageBox.Show(variable);
                                }
                                if (item1.Term.Name.Equals("numero") || item1.Term.Name.Equals("numero-decimal")|| item1.Term.Name.Equals("cualquier") || item1.Term.Name.Equals("cualquiercar") || item1.Term.Name.Equals("tipodedato"))
                                {
                                    valor = item1.ToString().Split(' ').ElementAt(0);
                                    //MessageBox.Show(item1.ToString());
                                }
                            //    MessageBox.Show("#" + con.ToString()
                            //+ " *ITEM: " + item1.ToString()
                            //+ " *associativity: " + item1.Associativity.ToString()
                            //+ " *Span End position: " + item1.Span.EndPosition
                            //+ " *Span Length: " + item1.Span.Length
                            //+ " *Span : Location" + item1.Span.Location
                            //+ " *Term: " + item1.Term.ToString()
                            //+ " *TermErrorAlias: " + item1.Term.ErrorAlias
                            //+ " *itemtermName: " + item1.Term.Name);
                            }
                        }
                        #endregion
                        //
                        #region Detecta si ya hay una variable declarada
                        Boolean declarada = false;
                        foreach (var item1 in ts)
                        {
                            if (variable.Equals(item1.variable) && item1.tipo.Equals("Declaracion"))
                            {
                                declarada = true;
                                break;
                            }
                            else
                            {
                                declarada = false;
                            }
                        }
                        if (declarada == true)
                        {
                            resultado = false;
                            MessageBox.Show("Error está declarando dos o mas veces la variable \"" + variable + "\", ya se encuentra declarada");
                        }
                        else
                        {
                            ts.Add(new TablaSimbolos("Declaracion", tipodedato, variable, valor));
                        }
                        #endregion
                    }

                    //No se ha declarado
                    if (item.ToString().Contains("(id)"))
                    {
                        //MessageBox.Show(item.ToString());
                        String var = item.ToString().Split(' ').ElementAt(0);
                        Boolean encontrada = false;
                        foreach (var item1 in ts)
                        {
                            if (var.Equals(item1.variable) && item1.tipo.Equals("Declaracion"))
                            {
                                encontrada = true;
                                break;
                            }
                            else
                            {
                                encontrada = false;
                            }
                        }
                        if (encontrada == true)
                            if (resultado == true)
                                resultado = true;
                            else
                                resultado = false;
                        else
                        {
                            resultado = false;
                            MessageBox.Show("No se ha declarado la variable: " + var + " en la linea: " + item.Span.Location);
                        }

                    }

                    con++;
                }
                //
                #region Error semantico no se pueden declarar variables que son palabras reservadas
                foreach (var item in nodos)
                {
                    if (item.ToString().Contains("(id)"))
                    {
                        String[] var = item.ToString().Split(' ');
                        foreach (var item1 in ts)
                        {
                            if (var[0].Equals(item1.variable) && item1.tipo.Equals("Reservada"))
                            {
                                MessageBox.Show("Error no puede utilizar \"" + var[0] + "\" es una palabra reservada en la linea: " + item.Span.Location);
                                resultado = false;
                            }
                        }
                    }
                }
                #endregion

                foreach (var item in ts)
                {
                    //MessageBox.Show(item.tipo + " "+item.tipoDato+" "+item.variable+" "+item.valor);
                    dtgSemantico.Rows.Add(item.tipo, item.tipoDato, item.variable, item.valor);
                }

                if (resultado)
                    MessageBox.Show("Compilación correcta");
                else
                    MessageBox.Show("Error de compilación");

                ts.Clear();
                LlenadoTablaSimbolos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de compilación");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarArchivo();
        }

        private void GuardarArchivo()
        {
            SFD.Filter = "Documento adamant|*.ada";
            SFD.Title = "Guardar código";
            SFD.FileName = "Sin titulo 1";
            var resultado = SFD.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(SFD.FileName);
                foreach (object line in textoCodigo.Lines)
                {
                    sw.WriteLine(line);
                }
                sw.Close();
            }
            cambios = false;
        }
        private void btnCopiar_Click(object sender, EventArgs e)
        {
            textoCodigo.Copy();
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            textoCodigo.Cut();
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            textoCodigo.Paste();
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar todo el texto?", "ADAMANT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtgToken.Rows.Clear();
                textoCodigo.Clear();
                cambios = false;
            }
        }

        private void btnAbrir_MouseEnter(object sender, EventArgs e)
        {
            btnAbrir.BackColor = Color.White;
        }

        private void btnAbrir_MouseLeave(object sender, EventArgs e)
        {
            btnAbrir.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btnGuardar_MouseEnter(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.White;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btnCopiar_MouseEnter(object sender, EventArgs e)
        {
            btnCopiar.BackColor = Color.White;
        }

        private void btnCopiar_MouseLeave(object sender, EventArgs e)
        {
            btnCopiar.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btnCortar_MouseEnter(object sender, EventArgs e)
        {
            btnCortar.BackColor = Color.White;
        }

        private void btnCortar_MouseLeave(object sender, EventArgs e)
        {
            btnCortar.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btnPegar_MouseEnter(object sender, EventArgs e)
        {
            btnPegar.BackColor = Color.White;
        }

        private void btnPegar_MouseLeave(object sender, EventArgs e)
        {
            btnPegar.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btnBorrarTodo_MouseEnter(object sender, EventArgs e)
        {
            btnBorrarTodo.BackColor = Color.White;
        }

        private void btnBorrarTodo_MouseLeave(object sender, EventArgs e)
        {
            btnBorrarTodo.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btnCompilar_MouseEnter(object sender, EventArgs e)
        {
            btnCompilar.BackColor = Color.White;
        }

        private void btnCompilar_MouseLeave(object sender, EventArgs e)
        {
            btnCompilar.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btnInfo_MouseEnter(object sender, EventArgs e)
        {
            btnInfo.BackColor = Color.White;
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            btnInfo.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADAMANT $\nCreado por: André Ibarra Pérez","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        int posX = 0;
        int posY = 0;
        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
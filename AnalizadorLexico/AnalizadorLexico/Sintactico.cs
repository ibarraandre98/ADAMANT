using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Irony.Ast;
using Irony.Parsing;

namespace AnalizadorLexico
{
    class Sintactico : Grammar
    {
        public static bool analizar(String cadena)
        {
            Gramatica _gramatica = new Gramatica();
            LanguageData _lenguaje = new LanguageData(_gramatica);
            Parser _parser = new Parser(_lenguaje);
            ParseTree arbol = _parser.Parse(cadena);
            ParseTreeNode raiz = arbol.Root;

            if (raiz == null)
                return false;
            else
                return true;
        }


        public static ParseTree retornoArbol(String cadena)
        {
            Gramatica _gramatica = new Gramatica();
            LanguageData _lenguaje = new LanguageData(_gramatica);
            Parser _parser = new Parser(_lenguaje);
            ParseTree arbol = _parser.Parse(cadena);
            return arbol;
        }

    }
}

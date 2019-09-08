namespace AnalizadorLexico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.PictureBox();
            this.btnBorrarTodo = new System.Windows.Forms.PictureBox();
            this.btnPegar = new System.Windows.Forms.PictureBox();
            this.btnCortar = new System.Windows.Forms.PictureBox();
            this.btnCopiar = new System.Windows.Forms.PictureBox();
            this.btnCompilar = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.btnAbrir = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.PictureBox();
            this.panelDTG = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sintactico = new System.Windows.Forms.TabPage();
            this.dtgToken = new System.Windows.Forms.DataGridView();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semantico = new System.Windows.Forms.TabPage();
            this.dtgSemantico = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLexico = new System.Windows.Forms.TabPage();
            this.textoCodigo = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnmini = new System.Windows.Forms.PictureBox();
            this.btnmaxi = new System.Windows.Forms.PictureBox();
            this.btnres = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPegar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCortar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCompilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).BeginInit();
            this.panelDTG.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.sintactico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgToken)).BeginInit();
            this.semantico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSemantico)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabLexico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnBorrarTodo);
            this.panel1.Controls.Add(this.btnPegar);
            this.panel1.Controls.Add(this.btnCortar);
            this.panel1.Controls.Add(this.btnCopiar);
            this.panel1.Controls.Add(this.btnCompilar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnAbrir);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(960, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(40, 47);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInfo.TabIndex = 10;
            this.btnInfo.TabStop = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            this.btnInfo.MouseEnter += new System.EventHandler(this.btnInfo_MouseEnter);
            this.btnInfo.MouseLeave += new System.EventHandler(this.btnInfo_MouseLeave);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarTodo.Image")));
            this.btnBorrarTodo.Location = new System.Drawing.Point(295, 4);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(40, 40);
            this.btnBorrarTodo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBorrarTodo.TabIndex = 9;
            this.btnBorrarTodo.TabStop = false;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            this.btnBorrarTodo.MouseEnter += new System.EventHandler(this.btnBorrarTodo_MouseEnter);
            this.btnBorrarTodo.MouseLeave += new System.EventHandler(this.btnBorrarTodo_MouseLeave);
            // 
            // btnPegar
            // 
            this.btnPegar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPegar.Image = ((System.Drawing.Image)(resources.GetObject("btnPegar.Image")));
            this.btnPegar.Location = new System.Drawing.Point(249, 4);
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Size = new System.Drawing.Size(40, 40);
            this.btnPegar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPegar.TabIndex = 8;
            this.btnPegar.TabStop = false;
            this.btnPegar.Click += new System.EventHandler(this.btnPegar_Click);
            this.btnPegar.MouseEnter += new System.EventHandler(this.btnPegar_MouseEnter);
            this.btnPegar.MouseLeave += new System.EventHandler(this.btnPegar_MouseLeave);
            // 
            // btnCortar
            // 
            this.btnCortar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCortar.Image = ((System.Drawing.Image)(resources.GetObject("btnCortar.Image")));
            this.btnCortar.Location = new System.Drawing.Point(203, 4);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(40, 40);
            this.btnCortar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCortar.TabIndex = 7;
            this.btnCortar.TabStop = false;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            this.btnCortar.MouseEnter += new System.EventHandler(this.btnCortar_MouseEnter);
            this.btnCortar.MouseLeave += new System.EventHandler(this.btnCortar_MouseLeave);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiar.Image = ((System.Drawing.Image)(resources.GetObject("btnCopiar.Image")));
            this.btnCopiar.Location = new System.Drawing.Point(157, 4);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(40, 40);
            this.btnCopiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCopiar.TabIndex = 6;
            this.btnCopiar.TabStop = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            this.btnCopiar.MouseEnter += new System.EventHandler(this.btnCopiar_MouseEnter);
            this.btnCopiar.MouseLeave += new System.EventHandler(this.btnCopiar_MouseLeave);
            // 
            // btnCompilar
            // 
            this.btnCompilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompilar.Image = ((System.Drawing.Image)(resources.GetObject("btnCompilar.Image")));
            this.btnCompilar.Location = new System.Drawing.Point(361, 4);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(40, 40);
            this.btnCompilar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCompilar.TabIndex = 5;
            this.btnCompilar.TabStop = false;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click);
            this.btnCompilar.MouseEnter += new System.EventHandler(this.btnCompilar_MouseEnter);
            this.btnCompilar.MouseLeave += new System.EventHandler(this.btnCompilar_MouseLeave);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(94, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(40, 40);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseEnter += new System.EventHandler(this.btnGuardar_MouseEnter);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.Location = new System.Drawing.Point(48, 4);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(40, 40);
            this.btnAbrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.TabStop = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            this.btnAbrir.MouseEnter += new System.EventHandler(this.btnAbrir_MouseEnter);
            this.btnAbrir.MouseLeave += new System.EventHandler(this.btnAbrir_MouseLeave);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(3, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Tag = "";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseEnter += new System.EventHandler(this.btnNuevo_MouseEnter);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.btnNuevo_MouseLeave);
            // 
            // panelDTG
            // 
            this.panelDTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelDTG.Controls.Add(this.tabControl1);
            this.panelDTG.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDTG.Location = new System.Drawing.Point(461, 80);
            this.panelDTG.Name = "panelDTG";
            this.panelDTG.Size = new System.Drawing.Size(539, 570);
            this.panelDTG.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sintactico);
            this.tabControl1.Controls.Add(this.semantico);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // sintactico
            // 
            this.sintactico.Controls.Add(this.dtgToken);
            this.sintactico.Location = new System.Drawing.Point(4, 22);
            this.sintactico.Name = "sintactico";
            this.sintactico.Padding = new System.Windows.Forms.Padding(3);
            this.sintactico.Size = new System.Drawing.Size(531, 544);
            this.sintactico.TabIndex = 0;
            this.sintactico.Text = "Sintáctico";
            this.sintactico.UseVisualStyleBackColor = true;
            // 
            // dtgToken
            // 
            this.dtgToken.AllowUserToDeleteRows = false;
            this.dtgToken.AllowUserToResizeRows = false;
            this.dtgToken.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgToken.BackgroundColor = System.Drawing.Color.Firebrick;
            this.dtgToken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgToken.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgToken.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgToken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgToken.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Lexema,
            this.Linea,
            this.Columna,
            this.Indice});
            this.dtgToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgToken.EnableHeadersVisualStyles = false;
            this.dtgToken.Location = new System.Drawing.Point(3, 3);
            this.dtgToken.Name = "dtgToken";
            this.dtgToken.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgToken.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgToken.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgToken.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgToken.Size = new System.Drawing.Size(525, 538);
            this.dtgToken.TabIndex = 0;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            this.Lexema.ReadOnly = true;
            this.Lexema.Width = 99;
            // 
            // Linea
            // 
            this.Linea.HeaderText = "Linea";
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            // 
            // Columna
            // 
            this.Columna.HeaderText = "Columna";
            this.Columna.Name = "Columna";
            this.Columna.ReadOnly = true;
            this.Columna.Width = 99;
            // 
            // Indice
            // 
            this.Indice.HeaderText = "Indice";
            this.Indice.Name = "Indice";
            this.Indice.ReadOnly = true;
            // 
            // semantico
            // 
            this.semantico.Controls.Add(this.dtgSemantico);
            this.semantico.Location = new System.Drawing.Point(4, 22);
            this.semantico.Name = "semantico";
            this.semantico.Padding = new System.Windows.Forms.Padding(3);
            this.semantico.Size = new System.Drawing.Size(531, 544);
            this.semantico.TabIndex = 1;
            this.semantico.Text = "Semántico";
            this.semantico.UseVisualStyleBackColor = true;
            // 
            // dtgSemantico
            // 
            this.dtgSemantico.AllowUserToDeleteRows = false;
            this.dtgSemantico.AllowUserToResizeRows = false;
            this.dtgSemantico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgSemantico.BackgroundColor = System.Drawing.Color.Firebrick;
            this.dtgSemantico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgSemantico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSemantico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgSemantico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSemantico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtgSemantico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSemantico.EnableHeadersVisualStyles = false;
            this.dtgSemantico.Location = new System.Drawing.Point(3, 3);
            this.dtgSemantico.Name = "dtgSemantico";
            this.dtgSemantico.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSemantico.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dtgSemantico.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgSemantico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSemantico.Size = new System.Drawing.Size(525, 538);
            this.dtgSemantico.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo de Dato";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 99;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Variable";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 99;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.tabControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 569);
            this.panel3.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLexico);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(45, 18);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(461, 569);
            this.tabControl.TabIndex = 0;
            // 
            // tabLexico
            // 
            this.tabLexico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabLexico.Controls.Add(this.textoCodigo);
            this.tabLexico.Controls.Add(this.pictureBox1);
            this.tabLexico.Location = new System.Drawing.Point(4, 22);
            this.tabLexico.Name = "tabLexico";
            this.tabLexico.Padding = new System.Windows.Forms.Padding(3);
            this.tabLexico.Size = new System.Drawing.Size(453, 543);
            this.tabLexico.TabIndex = 0;
            this.tabLexico.Text = "Analizador";
            // 
            // textoCodigo
            // 
            this.textoCodigo.AcceptsTab = true;
            this.textoCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textoCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCodigo.Location = new System.Drawing.Point(45, 3);
            this.textoCodigo.Name = "textoCodigo";
            this.textoCodigo.Size = new System.Drawing.Size(405, 537);
            this.textoCodigo.TabIndex = 1;
            this.textoCodigo.Text = "";
            this.textoCodigo.TextChanged += new System.EventHandler(this.textoCodigo_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 537);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Firebrick;
            this.panelTitulo.Controls.Add(this.pictureBox4);
            this.panelTitulo.Controls.Add(this.pictureBox3);
            this.panelTitulo.Controls.Add(this.btnmini);
            this.panelTitulo.Controls.Add(this.btnmaxi);
            this.panelTitulo.Controls.Add(this.btnres);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1000, 33);
            this.panelTitulo.TabIndex = 4;
            this.panelTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(37, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(123, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // btnmini
            // 
            this.btnmini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmini.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnmini.Image = ((System.Drawing.Image)(resources.GetObject("btnmini.Image")));
            this.btnmini.Location = new System.Drawing.Point(846, 0);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(38, 33);
            this.btnmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmini.TabIndex = 14;
            this.btnmini.TabStop = false;
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
            // 
            // btnmaxi
            // 
            this.btnmaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaxi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnmaxi.Image = ((System.Drawing.Image)(resources.GetObject("btnmaxi.Image")));
            this.btnmaxi.Location = new System.Drawing.Point(884, 0);
            this.btnmaxi.Name = "btnmaxi";
            this.btnmaxi.Size = new System.Drawing.Size(40, 33);
            this.btnmaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaxi.TabIndex = 16;
            this.btnmaxi.TabStop = false;
            this.btnmaxi.Click += new System.EventHandler(this.btnmaxi_Click);
            // 
            // btnres
            // 
            this.btnres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnres.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnres.Image = ((System.Drawing.Image)(resources.GetObject("btnres.Image")));
            this.btnres.Location = new System.Drawing.Point(924, 0);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(38, 33);
            this.btnres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnres.TabIndex = 15;
            this.btnres.TabStop = false;
            this.btnres.Visible = false;
            this.btnres.Click += new System.EventHandler(this.btnres_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(962, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 33);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Firebrick;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(461, 1);
            this.panel6.TabIndex = 5;
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelDTG);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adamant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPegar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCortar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCompilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).EndInit();
            this.panelDTG.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.sintactico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgToken)).EndInit();
            this.semantico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSemantico)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabLexico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDTG;
        internal System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.PictureBox btnNuevo;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.PictureBox btnAbrir;
        private System.Windows.Forms.PictureBox btnCompilar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnmini;
        private System.Windows.Forms.PictureBox btnmaxi;
        private System.Windows.Forms.PictureBox btnres;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnPegar;
        private System.Windows.Forms.PictureBox btnCortar;
        private System.Windows.Forms.PictureBox btnCopiar;
        private System.Windows.Forms.PictureBox btnBorrarTodo;
        private System.Windows.Forms.PictureBox btnInfo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dtgToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLexico;
        private System.Windows.Forms.RichTextBox textoCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sintactico;
        private System.Windows.Forms.TabPage semantico;
        private System.Windows.Forms.DataGridView dtgSemantico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}


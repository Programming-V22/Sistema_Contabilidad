namespace sistema_contable01
{
    partial class frm_empresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.conbestado = new System.Windows.Forms.ComboBox();
            this.dgbempresa = new System.Windows.Forms.DataGridView();
            this.txtBuscarUs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid_empresa = new System.Windows.Forms.TextBox();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.txtpropietario = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnBuscarUs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNuevoUs = new System.Windows.Forms.Button();
            this.btnEliminarUs = new System.Windows.Forms.Button();
            this.btnModificarUs = new System.Windows.Forms.Button();
            this.btnGuardarUs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbempresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(293, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 54);
            this.label1.TabIndex = 126;
            this.label1.Text = "Registro De Empresa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // conbestado
            // 
            this.conbestado.Enabled = false;
            this.conbestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conbestado.FormattingEnabled = true;
            this.conbestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.conbestado.Location = new System.Drawing.Point(796, 120);
            this.conbestado.Name = "conbestado";
            this.conbestado.Size = new System.Drawing.Size(135, 28);
            this.conbestado.TabIndex = 109;
            // 
            // dgbempresa
            // 
            this.dgbempresa.AllowUserToAddRows = false;
            this.dgbempresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgbempresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbempresa.Location = new System.Drawing.Point(139, 226);
            this.dgbempresa.Name = "dgbempresa";
            this.dgbempresa.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgbempresa.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgbempresa.Size = new System.Drawing.Size(789, 293);
            this.dgbempresa.TabIndex = 123;
            this.dgbempresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbempresa_CellContentClick);
            this.dgbempresa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbempresa_CellDoubleClick);
            this.dgbempresa.DoubleClick += new System.EventHandler(this.dgvUsuario_DoubleClick);
            // 
            // txtBuscarUs
            // 
            this.txtBuscarUs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUs.Location = new System.Drawing.Point(227, 522);
            this.txtBuscarUs.Multiline = true;
            this.txtBuscarUs.Name = "txtBuscarUs";
            this.txtBuscarUs.Size = new System.Drawing.Size(584, 34);
            this.txtBuscarUs.TabIndex = 120;
            this.txtBuscarUs.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(136, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 119;
            this.label4.Text = "NIT                :";
            // 
            // txtnit
            // 
            this.txtnit.Enabled = false;
            this.txtnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnit.Location = new System.Drawing.Point(259, 122);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(131, 26);
            this.txtnit.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(692, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 118;
            this.label2.Text = "Estado       :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(259, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(408, 26);
            this.txtNombre.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(137, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 117;
            this.label7.Text = "Nombre         :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(691, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 116;
            this.label3.Text = "Codigo       :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtid_empresa
            // 
            this.txtid_empresa.Enabled = false;
            this.txtid_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_empresa.Location = new System.Drawing.Point(796, 58);
            this.txtid_empresa.Name = "txtid_empresa";
            this.txtid_empresa.Size = new System.Drawing.Size(135, 26);
            this.txtid_empresa.TabIndex = 112;
            this.txtid_empresa.TextChanged += new System.EventHandler(this.txtid_empresa_TextChanged);
            // 
            // txtciudad
            // 
            this.txtciudad.Enabled = false;
            this.txtciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtciudad.Location = new System.Drawing.Point(259, 153);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(243, 26);
            this.txtciudad.TabIndex = 127;
            // 
            // txtpropietario
            // 
            this.txtpropietario.Enabled = false;
            this.txtpropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpropietario.Location = new System.Drawing.Point(259, 90);
            this.txtpropietario.Name = "txtpropietario";
            this.txtpropietario.Size = new System.Drawing.Size(408, 26);
            this.txtpropietario.TabIndex = 128;
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(796, 90);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(135, 26);
            this.txttelefono.TabIndex = 129;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(692, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 130;
            this.label5.Text = "Telefono    :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(137, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 131;
            this.label8.Text = "Propietario    :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(138, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 132;
            this.label10.Text = "Ciudad          :";
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnimprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnimprimir.Enabled = false;
            this.btnimprimir.FlatAppearance.BorderSize = 0;
            this.btnimprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnimprimir.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.White;
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.Location = new System.Drawing.Point(139, 190);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(95, 34);
            this.btnimprimir.TabIndex = 133;
            this.btnimprimir.Text = "RECARGAR";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1040, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 715);
            this.panel1.TabIndex = 140;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 705);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 10);
            this.panel2.TabIndex = 141;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(25, 254);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 13);
            this.label17.TabIndex = 143;
            this.label17.Text = "Agregar Empresa";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(23, 323);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 13);
            this.label18.TabIndex = 145;
            this.label18.Text = "Gestiona Empresa";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(24, 464);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 13);
            this.label19.TabIndex = 146;
            this.label19.Text = "Editar Empresa";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(24, 534);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 13);
            this.label20.TabIndex = 147;
            this.label20.Text = "Eliminar Empresa";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(25, 393);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 13);
            this.label21.TabIndex = 148;
            this.label21.Text = "Guardar Empresa";
            // 
            // btnBuscarUs
            // 
            this.btnBuscarUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscarUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarUs.FlatAppearance.BorderSize = 0;
            this.btnBuscarUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBuscarUs.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUs.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarUs.Location = new System.Drawing.Point(139, 522);
            this.btnBuscarUs.Name = "btnBuscarUs";
            this.btnBuscarUs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscarUs.Size = new System.Drawing.Size(88, 34);
            this.btnBuscarUs.TabIndex = 121;
            this.btnBuscarUs.Text = "BUSCAR";
            this.btnBuscarUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarUs.UseVisualStyleBackColor = false;
            this.btnBuscarUs.Visible = false;
            this.btnBuscarUs.Click += new System.EventHandler(this.btnBuscarUs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(129, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 134);
            this.pictureBox1.TabIndex = 149;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = global::sistema_contable01.Properties.Resources.agrupar_gestion;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(27, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 57);
            this.button1.TabIndex = 139;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNuevoUs
            // 
            this.btnNuevoUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNuevoUs.BackgroundImage = global::sistema_contable01.Properties.Resources.agregar_empresa;
            this.btnNuevoUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoUs.FlatAppearance.BorderSize = 0;
            this.btnNuevoUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevoUs.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUs.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoUs.Location = new System.Drawing.Point(27, 199);
            this.btnNuevoUs.Name = "btnNuevoUs";
            this.btnNuevoUs.Size = new System.Drawing.Size(82, 58);
            this.btnNuevoUs.TabIndex = 113;
            this.btnNuevoUs.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNuevoUs.UseVisualStyleBackColor = false;
            this.btnNuevoUs.Click += new System.EventHandler(this.btnNuevoUs_Click);
            // 
            // btnEliminarUs
            // 
            this.btnEliminarUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEliminarUs.BackgroundImage = global::sistema_contable01.Properties.Resources.eliminar_empresa;
            this.btnEliminarUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUs.Enabled = false;
            this.btnEliminarUs.FlatAppearance.BorderSize = 0;
            this.btnEliminarUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEliminarUs.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUs.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarUs.Location = new System.Drawing.Point(26, 476);
            this.btnEliminarUs.Name = "btnEliminarUs";
            this.btnEliminarUs.Size = new System.Drawing.Size(83, 57);
            this.btnEliminarUs.TabIndex = 115;
            this.btnEliminarUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarUs.UseVisualStyleBackColor = false;
            this.btnEliminarUs.Click += new System.EventHandler(this.btnEliminarUs_Click);
            // 
            // btnModificarUs
            // 
            this.btnModificarUs.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarUs.BackgroundImage = global::sistema_contable01.Properties.Resources.editar_empresa;
            this.btnModificarUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarUs.Enabled = false;
            this.btnModificarUs.FlatAppearance.BorderSize = 0;
            this.btnModificarUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnModificarUs.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUs.ForeColor = System.Drawing.Color.White;
            this.btnModificarUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUs.Location = new System.Drawing.Point(26, 406);
            this.btnModificarUs.Name = "btnModificarUs";
            this.btnModificarUs.Size = new System.Drawing.Size(83, 57);
            this.btnModificarUs.TabIndex = 114;
            this.btnModificarUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarUs.UseVisualStyleBackColor = false;
            this.btnModificarUs.Click += new System.EventHandler(this.btnModificarUs_Click);
            // 
            // btnGuardarUs
            // 
            this.btnGuardarUs.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarUs.BackgroundImage = global::sistema_contable01.Properties.Resources.guardar1;
            this.btnGuardarUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarUs.Enabled = false;
            this.btnGuardarUs.FlatAppearance.BorderSize = 0;
            this.btnGuardarUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardarUs.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUs.ForeColor = System.Drawing.Color.White;
            this.btnGuardarUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarUs.Location = new System.Drawing.Point(26, 336);
            this.btnGuardarUs.Name = "btnGuardarUs";
            this.btnGuardarUs.Size = new System.Drawing.Size(83, 57);
            this.btnGuardarUs.TabIndex = 111;
            this.btnGuardarUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarUs.UseVisualStyleBackColor = false;
            this.btnGuardarUs.Click += new System.EventHandler(this.btnGuardarUs_Click);
            // 
            // frm_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1050, 715);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtpropietario);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.conbestado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtid_empresa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnNuevoUs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgbempresa);
            this.Controls.Add(this.btnBuscarUs);
            this.Controls.Add(this.txtBuscarUs);
            this.Controls.Add(this.btnEliminarUs);
            this.Controls.Add(this.btnModificarUs);
            this.Controls.Add(this.btnGuardarUs);
            this.Name = "frm_empresa";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbempresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox conbestado;
        private System.Windows.Forms.Button btnBuscarUs;
        private System.Windows.Forms.TextBox txtBuscarUs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnNuevoUs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminarUs;
        private System.Windows.Forms.Button btnModificarUs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarUs;
        private System.Windows.Forms.TextBox txtid_empresa;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.TextBox txtpropietario;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgbempresa;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
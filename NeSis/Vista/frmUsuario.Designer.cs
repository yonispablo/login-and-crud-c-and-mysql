namespace Vista
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pctIcono = new System.Windows.Forms.PictureBox();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.pnlAssets = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbRegPorPagina = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMostrando = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pctSiguiente = new System.Windows.Forms.PictureBox();
            this.cmbPaginaN = new System.Windows.Forms.ComboBox();
            this.pctAnterior = new System.Windows.Forms.PictureBox();
            this.pctUltimo = new System.Windows.Forms.PictureBox();
            this.pctPrimero = new System.Windows.Forms.PictureBox();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rdApellidos = new System.Windows.Forms.RadioButton();
            this.rdNombres = new System.Windows.Forms.RadioButton();
            this.rdAlias = new System.Windows.Forms.RadioButton();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlWork = new System.Windows.Forms.Panel();
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.creado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.pnlAssets.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUltimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrimero)).BeginInit();
            this.grpBuscar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlWork.SuspendLayout();
            this.grpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(74)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pctIcono);
            this.panel1.Controls.Add(this.pctClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 36);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mantenimiento de usuarios";
            // 
            // pctIcono
            // 
            this.pctIcono.BackColor = System.Drawing.Color.Transparent;
            this.pctIcono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctIcono.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctIcono.Image = ((System.Drawing.Image)(resources.GetObject("pctIcono.Image")));
            this.pctIcono.Location = new System.Drawing.Point(0, 0);
            this.pctIcono.Name = "pctIcono";
            this.pctIcono.Size = new System.Drawing.Size(36, 36);
            this.pctIcono.TabIndex = 5;
            this.pctIcono.TabStop = false;
            // 
            // pctClose
            // 
            this.pctClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.pctClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pctClose.Image = ((System.Drawing.Image)(resources.GetObject("pctClose.Image")));
            this.pctClose.Location = new System.Drawing.Point(964, 0);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(36, 36);
            this.pctClose.TabIndex = 4;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // pnlAssets
            // 
            this.pnlAssets.BackColor = System.Drawing.Color.White;
            this.pnlAssets.Controls.Add(this.panel2);
            this.pnlAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAssets.Location = new System.Drawing.Point(0, 36);
            this.pnlAssets.Name = "pnlAssets";
            this.pnlAssets.Size = new System.Drawing.Size(1000, 664);
            this.pnlAssets.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cmbRegPorPagina);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblMostrando);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.grpBuscar);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 5, 10);
            this.panel2.Size = new System.Drawing.Size(1000, 60);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmbRegPorPagina
            // 
            this.cmbRegPorPagina.BackColor = System.Drawing.Color.Lavender;
            this.cmbRegPorPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRegPorPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRegPorPagina.FormattingEnabled = true;
            this.cmbRegPorPagina.Items.AddRange(new object[] {
            "10",
            "20",
            "30"});
            this.cmbRegPorPagina.Location = new System.Drawing.Point(472, 5);
            this.cmbRegPorPagina.Name = "cmbRegPorPagina";
            this.cmbRegPorPagina.Size = new System.Drawing.Size(45, 20);
            this.cmbRegPorPagina.TabIndex = 8;
            this.cmbRegPorPagina.SelectedIndexChanged += new System.EventHandler(this.CmbRegPorPagina_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 11);
            this.label5.TabIndex = 6;
            this.label5.Text = "Registros por página";
            // 
            // lblMostrando
            // 
            this.lblMostrando.AutoSize = true;
            this.lblMostrando.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(74)))), ((int)(((byte)(158)))));
            this.lblMostrando.Location = new System.Drawing.Point(134, 9);
            this.lblMostrando.Name = "lblMostrando";
            this.lblMostrando.Size = new System.Drawing.Size(173, 11);
            this.lblMostrando.TabIndex = 5;
            this.lblMostrando.Text = "Mostrando 0 a 0 de 0|";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblPaginas);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pctSiguiente);
            this.panel4.Controls.Add(this.cmbPaginaN);
            this.panel4.Controls.Add(this.pctAnterior);
            this.panel4.Controls.Add(this.pctUltimo);
            this.panel4.Controls.Add(this.pctPrimero);
            this.panel4.Location = new System.Drawing.Point(131, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 20);
            this.panel4.TabIndex = 2;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginas.Location = new System.Drawing.Point(105, 5);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(33, 11);
            this.lblPaginas.TabIndex = 7;
            this.lblPaginas.Text = "de N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 11);
            this.label2.TabIndex = 4;
            this.label2.Text = "Página";
            // 
            // pctSiguiente
            // 
            this.pctSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctSiguiente.BackgroundImage")));
            this.pctSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctSiguiente.Location = new System.Drawing.Point(208, 1);
            this.pctSiguiente.Name = "pctSiguiente";
            this.pctSiguiente.Size = new System.Drawing.Size(24, 18);
            this.pctSiguiente.TabIndex = 6;
            this.pctSiguiente.TabStop = false;
            this.pctSiguiente.Click += new System.EventHandler(this.PctSiguiente_Click);
            // 
            // cmbPaginaN
            // 
            this.cmbPaginaN.BackColor = System.Drawing.Color.Lavender;
            this.cmbPaginaN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPaginaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaginaN.FormattingEnabled = true;
            this.cmbPaginaN.Location = new System.Drawing.Point(53, 0);
            this.cmbPaginaN.Name = "cmbPaginaN";
            this.cmbPaginaN.Size = new System.Drawing.Size(45, 20);
            this.cmbPaginaN.TabIndex = 3;
            this.cmbPaginaN.SelectedIndexChanged += new System.EventHandler(this.CmbPaginaN_SelectedIndexChanged);
            // 
            // pctAnterior
            // 
            this.pctAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctAnterior.BackgroundImage")));
            this.pctAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctAnterior.Location = new System.Drawing.Point(182, 1);
            this.pctAnterior.Name = "pctAnterior";
            this.pctAnterior.Size = new System.Drawing.Size(24, 18);
            this.pctAnterior.TabIndex = 5;
            this.pctAnterior.TabStop = false;
            this.pctAnterior.Click += new System.EventHandler(this.PctAnterior_Click);
            // 
            // pctUltimo
            // 
            this.pctUltimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctUltimo.BackgroundImage")));
            this.pctUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctUltimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctUltimo.Location = new System.Drawing.Point(234, 1);
            this.pctUltimo.Name = "pctUltimo";
            this.pctUltimo.Size = new System.Drawing.Size(24, 18);
            this.pctUltimo.TabIndex = 4;
            this.pctUltimo.TabStop = false;
            this.pctUltimo.Click += new System.EventHandler(this.PctUltimo_Click);
            // 
            // pctPrimero
            // 
            this.pctPrimero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctPrimero.BackgroundImage")));
            this.pctPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctPrimero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctPrimero.Location = new System.Drawing.Point(156, 1);
            this.pctPrimero.Name = "pctPrimero";
            this.pctPrimero.Size = new System.Drawing.Size(24, 18);
            this.pctPrimero.TabIndex = 3;
            this.pctPrimero.TabStop = false;
            this.pctPrimero.Click += new System.EventHandler(this.PctPrimero_Click);
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.panel3);
            this.grpBuscar.Controls.Add(this.rdApellidos);
            this.grpBuscar.Controls.Add(this.rdNombres);
            this.grpBuscar.Controls.Add(this.rdAlias);
            this.grpBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBuscar.Location = new System.Drawing.Point(500, 5);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(495, 45);
            this.grpBuscar.TabIndex = 1;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Location = new System.Drawing.Point(190, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 32);
            this.panel3.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(17, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(280, 19);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // rdApellidos
            // 
            this.rdApellidos.AutoSize = true;
            this.rdApellidos.Location = new System.Drawing.Point(121, 17);
            this.rdApellidos.Name = "rdApellidos";
            this.rdApellidos.Size = new System.Drawing.Size(67, 17);
            this.rdApellidos.TabIndex = 3;
            this.rdApellidos.Text = "Apellidos";
            this.rdApellidos.UseVisualStyleBackColor = true;
            // 
            // rdNombres
            // 
            this.rdNombres.AutoSize = true;
            this.rdNombres.Location = new System.Drawing.Point(52, 17);
            this.rdNombres.Name = "rdNombres";
            this.rdNombres.Size = new System.Drawing.Size(67, 17);
            this.rdNombres.TabIndex = 2;
            this.rdNombres.Text = "Nombres";
            this.rdNombres.UseVisualStyleBackColor = true;
            // 
            // rdAlias
            // 
            this.rdAlias.AutoSize = true;
            this.rdAlias.Checked = true;
            this.rdAlias.Location = new System.Drawing.Point(5, 17);
            this.rdAlias.Name = "rdAlias";
            this.rdAlias.Size = new System.Drawing.Size(47, 17);
            this.rdAlias.TabIndex = 1;
            this.rdAlias.TabStop = true;
            this.rdAlias.Text = "Alias";
            this.rdAlias.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(74)))), ((int)(((byte)(158)))));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.Location = new System.Drawing.Point(12, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(115, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = " Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // pnlWork
            // 
            this.pnlWork.BackColor = System.Drawing.Color.White;
            this.pnlWork.Controls.Add(this.grpUsuarios);
            this.pnlWork.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlWork.Location = new System.Drawing.Point(0, 100);
            this.pnlWork.Name = "pnlWork";
            this.pnlWork.Size = new System.Drawing.Size(1000, 600);
            this.pnlWork.TabIndex = 8;
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.Controls.Add(this.grdUsuarios);
            this.grpUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUsuarios.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.grpUsuarios.Location = new System.Drawing.Point(0, 0);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Size = new System.Drawing.Size(1000, 600);
            this.grpUsuarios.TabIndex = 1;
            this.grpUsuarios.TabStop = false;
            this.grpUsuarios.Text = "Lista de usuarios";
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.AllowUserToAddRows = false;
            this.grdUsuarios.AllowUserToResizeColumns = false;
            this.grdUsuarios.AllowUserToResizeRows = false;
            this.grdUsuarios.BackgroundColor = System.Drawing.Color.Ivory;
            this.grdUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ALIAS,
            this.CLAVE,
            this.NOMBRES,
            this.APELLIDOS,
            this.foto,
            this.creado,
            this.actualizado});
            this.grdUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdUsuarios.Location = new System.Drawing.Point(3, 22);
            this.grdUsuarios.MultiSelect = false;
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.ReadOnly = true;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grdUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdUsuarios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdUsuarios.RowTemplate.Height = 60;
            this.grdUsuarios.RowTemplate.ReadOnly = true;
            this.grdUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUsuarios.Size = new System.Drawing.Size(994, 578);
            this.grdUsuarios.TabIndex = 0;
            this.grdUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdUsuarios_CellClick);
            this.grdUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GrdUsuarios_CellFormatting);
            this.grdUsuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GrdUsuarios_CellPainting);
            // 
            // ID
            // 
            dataGridViewCellStyle1.NullValue = "null";
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 45;
            // 
            // ALIAS
            // 
            this.ALIAS.HeaderText = "ALIAS";
            this.ALIAS.Name = "ALIAS";
            this.ALIAS.ReadOnly = true;
            this.ALIAS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ALIAS.Width = 75;
            // 
            // CLAVE
            // 
            this.CLAVE.HeaderText = "CLAVE";
            this.CLAVE.Name = "CLAVE";
            this.CLAVE.ReadOnly = true;
            this.CLAVE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CLAVE.Width = 80;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            this.NOMBRES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NOMBRES.Width = 130;
            // 
            // APELLIDOS
            // 
            this.APELLIDOS.HeaderText = "APELLIDOS";
            this.APELLIDOS.Name = "APELLIDOS";
            this.APELLIDOS.ReadOnly = true;
            this.APELLIDOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.APELLIDOS.Width = 150;
            // 
            // foto
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foto.DefaultCellStyle = dataGridViewCellStyle2;
            this.foto.HeaderText = "FOTO";
            this.foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Width = 80;
            // 
            // creado
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.creado.DefaultCellStyle = dataGridViewCellStyle3;
            this.creado.HeaderText = "CREADO";
            this.creado.Name = "creado";
            this.creado.ReadOnly = true;
            this.creado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.creado.Width = 140;
            // 
            // actualizado
            // 
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.actualizado.DefaultCellStyle = dataGridViewCellStyle4;
            this.actualizado.HeaderText = "ACTUALIZADO";
            this.actualizado.Name = "actualizado";
            this.actualizado.ReadOnly = true;
            this.actualizado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.actualizado.Width = 140;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pnlWork);
            this.Controls.Add(this.pnlAssets);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.pnlAssets.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUltimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrimero)).EndInit();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlWork.ResumeLayout(false);
            this.grpUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctIcono;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.Panel pnlAssets;
        private System.Windows.Forms.Panel pnlWork;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView grdUsuarios;
        private System.Windows.Forms.GroupBox grpUsuarios;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.RadioButton rdApellidos;
        private System.Windows.Forms.RadioButton rdNombres;
        private System.Windows.Forms.RadioButton rdAlias;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbRegPorPagina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMostrando;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctSiguiente;
        private System.Windows.Forms.ComboBox cmbPaginaN;
        private System.Windows.Forms.PictureBox pctAnterior;
        private System.Windows.Forms.PictureBox pctUltimo;
        private System.Windows.Forms.PictureBox pctPrimero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALIAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn creado;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualizado;
    }
}
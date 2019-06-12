namespace Vista
{
    partial class frmInsertEditUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertEditUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pctIcono = new System.Windows.Forms.PictureBox();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.panelUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.cmbCargp = new System.Windows.Forms.ComboBox();
            this.lblActualizado = new System.Windows.Forms.Label();
            this.txtModificado = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtCreado = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblRepClave = new System.Windows.Forms.Label();
            this.txtRepClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblAlias = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblCreado = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.pctSubirImagen = new System.Windows.Forms.PictureBox();
            this.pctEliminarImagen = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSubirImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEliminarImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.pctIcono);
            this.panel1.Controls.Add(this.pctClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 36);
            this.panel1.TabIndex = 7;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(41, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 16);
            this.lblHeader.TabIndex = 6;
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
            this.pctClose.Location = new System.Drawing.Point(376, 0);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(36, 36);
            this.pctClose.TabIndex = 4;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelUsuario.ColumnCount = 2;
            this.panelUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.panelUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.panelUsuario.Controls.Add(this.cmbCargp, 1, 7);
            this.panelUsuario.Controls.Add(this.lblActualizado, 0, 10);
            this.panelUsuario.Controls.Add(this.txtModificado, 1, 10);
            this.panelUsuario.Controls.Add(this.lblApellidos, 0, 5);
            this.panelUsuario.Controls.Add(this.txtCreado, 1, 9);
            this.panelUsuario.Controls.Add(this.lblTipo, 0, 6);
            this.panelUsuario.Controls.Add(this.lblCargo, 0, 7);
            this.panelUsuario.Controls.Add(this.txtNombres, 1, 4);
            this.panelUsuario.Controls.Add(this.txtApellidos, 1, 5);
            this.panelUsuario.Controls.Add(this.lblRepClave, 0, 3);
            this.panelUsuario.Controls.Add(this.txtRepClave, 1, 3);
            this.panelUsuario.Controls.Add(this.lblClave, 0, 2);
            this.panelUsuario.Controls.Add(this.txtClave, 1, 2);
            this.panelUsuario.Controls.Add(this.lblAlias, 0, 1);
            this.panelUsuario.Controls.Add(this.txtAlias, 1, 1);
            this.panelUsuario.Controls.Add(this.lblIdUsuario, 0, 0);
            this.panelUsuario.Controls.Add(this.txtId, 1, 0);
            this.panelUsuario.Controls.Add(this.lblNombres, 0, 4);
            this.panelUsuario.Controls.Add(this.lblCreado, 0, 9);
            this.panelUsuario.Controls.Add(this.lblFoto, 0, 8);
            this.panelUsuario.Controls.Add(this.pctFoto, 1, 8);
            this.panelUsuario.Controls.Add(this.cmbTipo, 1, 6);
            this.panelUsuario.Location = new System.Drawing.Point(5, 40);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.RowCount = 12;
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelUsuario.Size = new System.Drawing.Size(400, 506);
            this.panelUsuario.TabIndex = 8;
            // 
            // cmbCargp
            // 
            this.cmbCargp.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargp.FormattingEnabled = true;
            this.cmbCargp.Location = new System.Drawing.Point(155, 283);
            this.cmbCargp.Name = "cmbCargp";
            this.cmbCargp.Size = new System.Drawing.Size(240, 26);
            this.cmbCargp.TabIndex = 7;
            // 
            // lblActualizado
            // 
            this.lblActualizado.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.lblActualizado.Location = new System.Drawing.Point(3, 480);
            this.lblActualizado.Name = "lblActualizado";
            this.lblActualizado.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblActualizado.Size = new System.Drawing.Size(124, 23);
            this.lblActualizado.TabIndex = 21;
            this.lblActualizado.Text = "Actualizado";
            // 
            // txtModificado
            // 
            this.txtModificado.BackColor = System.Drawing.Color.AliceBlue;
            this.txtModificado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModificado.Enabled = false;
            this.txtModificado.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificado.Location = new System.Drawing.Point(155, 483);
            this.txtModificado.Name = "txtModificado";
            this.txtModificado.ReadOnly = true;
            this.txtModificado.Size = new System.Drawing.Size(183, 16);
            this.txtModificado.TabIndex = 22;
            // 
            // lblApellidos
            // 
            this.lblApellidos.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.lblApellidos.Location = new System.Drawing.Point(3, 200);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblApellidos.Size = new System.Drawing.Size(114, 23);
            this.lblApellidos.TabIndex = 11;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtCreado
            // 
            this.txtCreado.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCreado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreado.Enabled = false;
            this.txtCreado.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreado.Location = new System.Drawing.Point(155, 443);
            this.txtCreado.Name = "txtCreado";
            this.txtCreado.ReadOnly = true;
            this.txtCreado.Size = new System.Drawing.Size(184, 16);
            this.txtCreado.TabIndex = 18;
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.lblTipo.Location = new System.Drawing.Point(3, 240);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblTipo.Size = new System.Drawing.Size(114, 23);
            this.lblTipo.TabIndex = 15;
            this.lblTipo.Text = "Tipo";
            // 
            // lblCargo
            // 
            this.lblCargo.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.lblCargo.Location = new System.Drawing.Point(3, 280);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblCargo.Size = new System.Drawing.Size(114, 23);
            this.lblCargo.TabIndex = 13;
            this.lblCargo.Text = "Cargo";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(155, 163);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(241, 23);
            this.txtNombres.TabIndex = 4;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.AliceBlue;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(155, 203);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(241, 23);
            this.txtApellidos.TabIndex = 5;
            // 
            // lblRepClave
            // 
            this.lblRepClave.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.lblRepClave.Location = new System.Drawing.Point(3, 120);
            this.lblRepClave.Name = "lblRepClave";
            this.lblRepClave.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblRepClave.Size = new System.Drawing.Size(144, 23);
            this.lblRepClave.TabIndex = 7;
            this.lblRepClave.Text = "Repetir clave";
            // 
            // txtRepClave
            // 
            this.txtRepClave.BackColor = System.Drawing.Color.AliceBlue;
            this.txtRepClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepClave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepClave.Location = new System.Drawing.Point(155, 123);
            this.txtRepClave.Name = "txtRepClave";
            this.txtRepClave.PasswordChar = '*';
            this.txtRepClave.Size = new System.Drawing.Size(138, 23);
            this.txtRepClave.TabIndex = 3;
            // 
            // lblClave
            // 
            this.lblClave.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.lblClave.Location = new System.Drawing.Point(3, 80);
            this.lblClave.Name = "lblClave";
            this.lblClave.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblClave.Size = new System.Drawing.Size(114, 23);
            this.lblClave.TabIndex = 5;
            this.lblClave.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.AliceBlue;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(155, 83);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(140, 23);
            this.txtClave.TabIndex = 2;
            // 
            // lblAlias
            // 
            this.lblAlias.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.lblAlias.Location = new System.Drawing.Point(3, 40);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblAlias.Size = new System.Drawing.Size(114, 23);
            this.lblAlias.TabIndex = 3;
            this.lblAlias.Text = "Alias";
            // 
            // txtAlias
            // 
            this.txtAlias.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlias.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlias.Location = new System.Drawing.Point(155, 43);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.ShortcutsEnabled = false;
            this.txtAlias.Size = new System.Drawing.Size(139, 23);
            this.txtAlias.TabIndex = 1;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.lblIdUsuario.Location = new System.Drawing.Point(3, 0);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblIdUsuario.Size = new System.Drawing.Size(114, 23);
            this.lblIdUsuario.TabIndex = 0;
            this.lblIdUsuario.Text = "Id usuario";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.AliceBlue;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(155, 3);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(70, 23);
            this.txtId.TabIndex = 2;
            // 
            // lblNombres
            // 
            this.lblNombres.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.lblNombres.Location = new System.Drawing.Point(3, 160);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblNombres.Size = new System.Drawing.Size(114, 23);
            this.lblNombres.TabIndex = 9;
            this.lblNombres.Text = "Nombres";
            // 
            // lblCreado
            // 
            this.lblCreado.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.lblCreado.Location = new System.Drawing.Point(3, 440);
            this.lblCreado.Name = "lblCreado";
            this.lblCreado.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblCreado.Size = new System.Drawing.Size(114, 23);
            this.lblCreado.TabIndex = 19;
            this.lblCreado.Text = "Creado";
            // 
            // lblFoto
            // 
            this.lblFoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFoto.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.lblFoto.Location = new System.Drawing.Point(3, 368);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblFoto.Size = new System.Drawing.Size(114, 23);
            this.lblFoto.TabIndex = 17;
            this.lblFoto.Text = "Foto";
            // 
            // pctFoto
            // 
            this.pctFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctFoto.Location = new System.Drawing.Point(155, 323);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(101, 109);
            this.pctFoto.TabIndex = 10;
            this.pctFoto.TabStop = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "VENDEDOR",
            "SUPERVISOR",
            "USUARIO",
            "ADMINISTRADOR"});
            this.cmbTipo.Location = new System.Drawing.Point(155, 243);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(191, 26);
            this.cmbTipo.TabIndex = 6;
            // 
            // pctSubirImagen
            // 
            this.pctSubirImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctSubirImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctSubirImagen.Image = ((System.Drawing.Image)(resources.GetObject("pctSubirImagen.Image")));
            this.pctSubirImagen.Location = new System.Drawing.Point(272, 370);
            this.pctSubirImagen.Name = "pctSubirImagen";
            this.pctSubirImagen.Size = new System.Drawing.Size(38, 45);
            this.pctSubirImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctSubirImagen.TabIndex = 11;
            this.pctSubirImagen.TabStop = false;
            this.pctSubirImagen.Click += new System.EventHandler(this.PctSubirImagen_Click);
            // 
            // pctEliminarImagen
            // 
            this.pctEliminarImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctEliminarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctEliminarImagen.Image = ((System.Drawing.Image)(resources.GetObject("pctEliminarImagen.Image")));
            this.pctEliminarImagen.Location = new System.Drawing.Point(272, 423);
            this.pctEliminarImagen.Name = "pctEliminarImagen";
            this.pctEliminarImagen.Size = new System.Drawing.Size(38, 47);
            this.pctEliminarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctEliminarImagen.TabIndex = 23;
            this.pctEliminarImagen.TabStop = false;
            this.pctEliminarImagen.Click += new System.EventHandler(this.PctEliminarImagen_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(101, 554);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(211, 33);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mantenimiento de usuarios";
            // 
            // frmInsertEditUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(412, 598);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pctSubirImagen);
            this.Controls.Add(this.pctEliminarImagen);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInsertEditUsuario";
            this.Text = "frmInsertEditUsuario";
            this.Load += new System.EventHandler(this.FrmInsertEditUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSubirImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEliminarImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pctIcono;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.TableLayoutPanel panelUsuario;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblRepClave;
        private System.Windows.Forms.TextBox txtRepClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label lblActualizado;
        private System.Windows.Forms.TextBox txtModificado;
        private System.Windows.Forms.Label lblCreado;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.TextBox txtCreado;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.PictureBox pctSubirImagen;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.PictureBox pctEliminarImagen;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbCargp;
        private System.Windows.Forms.Label label1;
    }
}
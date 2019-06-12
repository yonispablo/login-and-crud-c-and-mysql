namespace Vista
{
    partial class frmPantalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantalla));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.btnRepUsuarios = new System.Windows.Forms.Button();
            this.btnRepVentas = new System.Windows.Forms.Button();
            this.btnMenuReportes = new System.Windows.Forms.Button();
            this.pnlOperaciones = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnMenuOperaciones = new System.Windows.Forms.Button();
            this.pnlParametros = new System.Windows.Forms.Panel();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnMenuParametros = new System.Windows.Forms.Button();
            this.pnlDivisor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlControlesPantalla = new System.Windows.Forms.Panel();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.pctMinimize = new System.Windows.Forms.PictureBox();
            this.pctRestore = new System.Windows.Forms.PictureBox();
            this.pnlApp = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlReportes.SuspendLayout();
            this.pnlOperaciones.SuspendLayout();
            this.pnlParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlControlesPantalla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRestore)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(74)))), ((int)(((byte)(158)))));
            this.pnlMenu.Controls.Add(this.pnlReportes);
            this.pnlMenu.Controls.Add(this.btnMenuReportes);
            this.pnlMenu.Controls.Add(this.pnlOperaciones);
            this.pnlMenu.Controls.Add(this.btnMenuOperaciones);
            this.pnlMenu.Controls.Add(this.pnlParametros);
            this.pnlMenu.Controls.Add(this.btnMenuParametros);
            this.pnlMenu.Controls.Add(this.pnlDivisor);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.Color.White;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 561);
            this.pnlMenu.TabIndex = 1;
            // 
            // pnlReportes
            // 
            this.pnlReportes.Controls.Add(this.btnRepUsuarios);
            this.pnlReportes.Controls.Add(this.btnRepVentas);
            this.pnlReportes.Location = new System.Drawing.Point(2, 460);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(217, 87);
            this.pnlReportes.TabIndex = 6;
            // 
            // btnRepUsuarios
            // 
            this.btnRepUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(148)))));
            this.btnRepUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnRepUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepUsuarios.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnRepUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnRepUsuarios.Image")));
            this.btnRepUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepUsuarios.Location = new System.Drawing.Point(25, 44);
            this.btnRepUsuarios.Name = "btnRepUsuarios";
            this.btnRepUsuarios.Size = new System.Drawing.Size(192, 40);
            this.btnRepUsuarios.TabIndex = 6;
            this.btnRepUsuarios.Text = "USUARIOS";
            this.btnRepUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRepUsuarios.UseVisualStyleBackColor = true;
            this.btnRepUsuarios.Click += new System.EventHandler(this.BtnRepUsuarios_Click);
            // 
            // btnRepVentas
            // 
            this.btnRepVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(148)))));
            this.btnRepVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnRepVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepVentas.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepVentas.ForeColor = System.Drawing.Color.White;
            this.btnRepVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnRepVentas.Image")));
            this.btnRepVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepVentas.Location = new System.Drawing.Point(25, 3);
            this.btnRepVentas.Name = "btnRepVentas";
            this.btnRepVentas.Size = new System.Drawing.Size(192, 40);
            this.btnRepVentas.TabIndex = 5;
            this.btnRepVentas.Text = "VENTAS";
            this.btnRepVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRepVentas.UseVisualStyleBackColor = true;
            // 
            // btnMenuReportes
            // 
            this.btnMenuReportes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(148)))));
            this.btnMenuReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnMenuReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuReportes.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuReportes.ForeColor = System.Drawing.Color.White;
            this.btnMenuReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuReportes.Image")));
            this.btnMenuReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuReportes.Location = new System.Drawing.Point(2, 420);
            this.btnMenuReportes.Name = "btnMenuReportes";
            this.btnMenuReportes.Size = new System.Drawing.Size(217, 40);
            this.btnMenuReportes.TabIndex = 7;
            this.btnMenuReportes.Text = " REPORTES";
            this.btnMenuReportes.UseVisualStyleBackColor = true;
            this.btnMenuReportes.Click += new System.EventHandler(this.BtnMenuReportes_Click);
            // 
            // pnlOperaciones
            // 
            this.pnlOperaciones.Controls.Add(this.btnVentas);
            this.pnlOperaciones.Controls.Add(this.btnInventario);
            this.pnlOperaciones.Location = new System.Drawing.Point(2, 340);
            this.pnlOperaciones.Name = "pnlOperaciones";
            this.pnlOperaciones.Size = new System.Drawing.Size(217, 87);
            this.pnlOperaciones.TabIndex = 4;
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(148)))));
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(25, 44);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(192, 40);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(148)))));
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(25, 3);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(192, 40);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = "INVENTARIO";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnMenuOperaciones
            // 
            this.btnMenuOperaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(148)))));
            this.btnMenuOperaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnMenuOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuOperaciones.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuOperaciones.ForeColor = System.Drawing.Color.White;
            this.btnMenuOperaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuOperaciones.Image")));
            this.btnMenuOperaciones.Location = new System.Drawing.Point(2, 300);
            this.btnMenuOperaciones.Name = "btnMenuOperaciones";
            this.btnMenuOperaciones.Size = new System.Drawing.Size(226, 40);
            this.btnMenuOperaciones.TabIndex = 5;
            this.btnMenuOperaciones.Text = " OPERACIONES";
            this.btnMenuOperaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOperaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuOperaciones.UseVisualStyleBackColor = true;
            this.btnMenuOperaciones.Click += new System.EventHandler(this.BtnMenuOperaciones_Click);
            // 
            // pnlParametros
            // 
            this.pnlParametros.Controls.Add(this.btnProveedores);
            this.pnlParametros.Controls.Add(this.btnClientes);
            this.pnlParametros.Location = new System.Drawing.Point(3, 220);
            this.pnlParametros.Name = "pnlParametros";
            this.pnlParametros.Size = new System.Drawing.Size(217, 87);
            this.pnlParametros.TabIndex = 0;
            // 
            // btnProveedores
            // 
            this.btnProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(148)))));
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(25, 44);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(192, 40);
            this.btnProveedores.TabIndex = 6;
            this.btnProveedores.Text = "PROVEEDORES";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(148)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(25, 3);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(192, 40);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnMenuParametros
            // 
            this.btnMenuParametros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(148)))));
            this.btnMenuParametros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnMenuParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuParametros.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuParametros.ForeColor = System.Drawing.Color.White;
            this.btnMenuParametros.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuParametros.Image")));
            this.btnMenuParametros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuParametros.Location = new System.Drawing.Point(3, 180);
            this.btnMenuParametros.Name = "btnMenuParametros";
            this.btnMenuParametros.Size = new System.Drawing.Size(217, 40);
            this.btnMenuParametros.TabIndex = 0;
            this.btnMenuParametros.Text = " PARÁMETROS";
            this.btnMenuParametros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuParametros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuParametros.UseVisualStyleBackColor = true;
            this.btnMenuParametros.Click += new System.EventHandler(this.BtnMenuParametros_Click);
            // 
            // pnlDivisor
            // 
            this.pnlDivisor.BackColor = System.Drawing.Color.White;
            this.pnlDivisor.Location = new System.Drawing.Point(4, 167);
            this.pnlDivisor.Name = "pnlDivisor";
            this.pnlDivisor.Size = new System.Drawing.Size(210, 2);
            this.pnlDivisor.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 162);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.pnlHeader.Controls.Add(this.btnUsuario);
            this.pnlHeader.Controls.Add(this.panel1);
            this.pnlHeader.Controls.Add(this.btnInicio);
            this.pnlHeader.Controls.Add(this.pnlControlesPantalla);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(764, 64);
            this.pnlHeader.TabIndex = 2;
            // 
            // btnUsuario
            // 
            this.btnUsuario.AutoSize = true;
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(193, 6);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(257, 55);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "Usuario: SIN USUARIO";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(187, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(25, 3);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(157, 55);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // pnlControlesPantalla
            // 
            this.pnlControlesPantalla.Controls.Add(this.pctClose);
            this.pnlControlesPantalla.Controls.Add(this.pctMinimize);
            this.pnlControlesPantalla.Controls.Add(this.pctRestore);
            this.pnlControlesPantalla.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControlesPantalla.Location = new System.Drawing.Point(645, 0);
            this.pnlControlesPantalla.Name = "pnlControlesPantalla";
            this.pnlControlesPantalla.Size = new System.Drawing.Size(119, 64);
            this.pnlControlesPantalla.TabIndex = 0;
            // 
            // pctClose
            // 
            this.pctClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.pctClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctClose.Image = ((System.Drawing.Image)(resources.GetObject("pctClose.Image")));
            this.pctClose.Location = new System.Drawing.Point(80, 3);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(36, 36);
            this.pctClose.TabIndex = 3;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // pctMinimize
            // 
            this.pctMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.pctMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pctMinimize.Image")));
            this.pctMinimize.Location = new System.Drawing.Point(8, 3);
            this.pctMinimize.Name = "pctMinimize";
            this.pctMinimize.Size = new System.Drawing.Size(36, 36);
            this.pctMinimize.TabIndex = 1;
            this.pctMinimize.TabStop = false;
            this.pctMinimize.Click += new System.EventHandler(this.PctMinimize_Click_1);
            // 
            // pctRestore
            // 
            this.pctRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.pctRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctRestore.Image = ((System.Drawing.Image)(resources.GetObject("pctRestore.Image")));
            this.pctRestore.Location = new System.Drawing.Point(44, 3);
            this.pctRestore.Name = "pctRestore";
            this.pctRestore.Size = new System.Drawing.Size(36, 36);
            this.pctRestore.TabIndex = 1;
            this.pctRestore.TabStop = false;
            // 
            // pnlApp
            // 
            this.pnlApp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlApp.BackgroundImage")));
            this.pnlApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApp.Location = new System.Drawing.Point(220, 64);
            this.pnlApp.Name = "pnlApp";
            this.pnlApp.Size = new System.Drawing.Size(764, 497);
            this.pnlApp.TabIndex = 3;
            // 
            // frmPantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlApp);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPantalla";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPantalla_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlReportes.ResumeLayout(false);
            this.pnlOperaciones.ResumeLayout(false);
            this.pnlParametros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlControlesPantalla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRestore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.Button btnRepUsuarios;
        private System.Windows.Forms.Button btnRepVentas;
        private System.Windows.Forms.Button btnMenuReportes;
        private System.Windows.Forms.Panel pnlOperaciones;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnMenuOperaciones;
        private System.Windows.Forms.Panel pnlParametros;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnMenuParametros;
        private System.Windows.Forms.Panel pnlDivisor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlControlesPantalla;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.PictureBox pctMinimize;
        private System.Windows.Forms.PictureBox pctRestore;
        private System.Windows.Forms.Panel pnlApp;
    }
}


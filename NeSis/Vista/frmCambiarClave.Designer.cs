namespace Vista
{
    partial class frmCambiarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarClave));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pctIcono = new System.Windows.Forms.PictureBox();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.lblRepNuevaClave = new System.Windows.Forms.Label();
            this.lblNuevaClave = new System.Windows.Forms.Label();
            this.txtNuevaClave = new System.Windows.Forms.TextBox();
            this.lblClaveActual = new System.Windows.Forms.Label();
            this.txtClaveActual = new System.Windows.Forms.TextBox();
            this.txtRepNuevaClave = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.panelUsuario.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(414, 36);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cambio de clave";
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
            this.pctClose.Location = new System.Drawing.Point(378, 0);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(36, 36);
            this.pctClose.TabIndex = 4;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(95, 177);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(211, 33);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelUsuario.ColumnCount = 2;
            this.panelUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.panelUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.panelUsuario.Controls.Add(this.lblRepNuevaClave, 0, 2);
            this.panelUsuario.Controls.Add(this.lblNuevaClave, 0, 1);
            this.panelUsuario.Controls.Add(this.txtNuevaClave, 1, 1);
            this.panelUsuario.Controls.Add(this.lblClaveActual, 0, 0);
            this.panelUsuario.Controls.Add(this.txtClaveActual, 1, 0);
            this.panelUsuario.Controls.Add(this.txtRepNuevaClave, 1, 2);
            this.panelUsuario.Location = new System.Drawing.Point(3, 42);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.RowCount = 3;
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelUsuario.Size = new System.Drawing.Size(400, 118);
            this.panelUsuario.TabIndex = 11;
            // 
            // lblRepNuevaClave
            // 
            this.lblRepNuevaClave.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepNuevaClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.lblRepNuevaClave.Location = new System.Drawing.Point(3, 80);
            this.lblRepNuevaClave.Name = "lblRepNuevaClave";
            this.lblRepNuevaClave.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblRepNuevaClave.Size = new System.Drawing.Size(214, 23);
            this.lblRepNuevaClave.TabIndex = 5;
            this.lblRepNuevaClave.Text = "Repetir nueva clave";
            // 
            // lblNuevaClave
            // 
            this.lblNuevaClave.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.lblNuevaClave.Location = new System.Drawing.Point(3, 40);
            this.lblNuevaClave.Name = "lblNuevaClave";
            this.lblNuevaClave.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblNuevaClave.Size = new System.Drawing.Size(146, 23);
            this.lblNuevaClave.TabIndex = 3;
            this.lblNuevaClave.Text = "Nueva clave";
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNuevaClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevaClave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaClave.Location = new System.Drawing.Point(223, 43);
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.PasswordChar = '*';
            this.txtNuevaClave.ShortcutsEnabled = false;
            this.txtNuevaClave.Size = new System.Drawing.Size(174, 23);
            this.txtNuevaClave.TabIndex = 2;
            // 
            // lblClaveActual
            // 
            this.lblClaveActual.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.lblClaveActual.Location = new System.Drawing.Point(3, 0);
            this.lblClaveActual.Name = "lblClaveActual";
            this.lblClaveActual.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblClaveActual.Size = new System.Drawing.Size(135, 23);
            this.lblClaveActual.TabIndex = 0;
            this.lblClaveActual.Text = "Clave actual";
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.BackColor = System.Drawing.Color.AliceBlue;
            this.txtClaveActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClaveActual.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveActual.Location = new System.Drawing.Point(223, 3);
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.PasswordChar = '*';
            this.txtClaveActual.Size = new System.Drawing.Size(174, 23);
            this.txtClaveActual.TabIndex = 1;
            // 
            // txtRepNuevaClave
            // 
            this.txtRepNuevaClave.BackColor = System.Drawing.Color.AliceBlue;
            this.txtRepNuevaClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepNuevaClave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepNuevaClave.Location = new System.Drawing.Point(223, 83);
            this.txtRepNuevaClave.Name = "txtRepNuevaClave";
            this.txtRepNuevaClave.PasswordChar = '*';
            this.txtRepNuevaClave.Size = new System.Drawing.Size(174, 23);
            this.txtRepNuevaClave.TabIndex = 3;
            // 
            // frmCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(414, 224);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCambiarClave";
            this.Text = "frmCambiarClave";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pctIcono;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TableLayoutPanel panelUsuario;
        private System.Windows.Forms.Label lblRepNuevaClave;
        private System.Windows.Forms.Label lblNuevaClave;
        private System.Windows.Forms.TextBox txtNuevaClave;
        private System.Windows.Forms.Label lblClaveActual;
        private System.Windows.Forms.TextBox txtClaveActual;
        private System.Windows.Forms.TextBox txtRepNuevaClave;
        private System.Windows.Forms.Label label1;
    }
}
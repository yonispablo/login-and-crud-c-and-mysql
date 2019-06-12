namespace Vista
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtClaveLogin = new System.Windows.Forms.TextBox();
            this.lblCierraLogin = new System.Windows.Forms.Label();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.btnIngresaLogin = new System.Windows.Forms.Button();
            this.btnIngresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClaveLogin
            // 
            this.txtClaveLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(232)))));
            this.txtClaveLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClaveLogin.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveLogin.ForeColor = System.Drawing.Color.White;
            this.txtClaveLogin.Location = new System.Drawing.Point(87, 304);
            this.txtClaveLogin.MaxLength = 10;
            this.txtClaveLogin.Name = "txtClaveLogin";
            this.txtClaveLogin.PasswordChar = '*';
            this.txtClaveLogin.Size = new System.Drawing.Size(223, 24);
            this.txtClaveLogin.TabIndex = 7;
            this.txtClaveLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClaveLogin_KeyPress);
            // 
            // lblCierraLogin
            // 
            this.lblCierraLogin.AutoSize = true;
            this.lblCierraLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblCierraLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCierraLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCierraLogin.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCierraLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCierraLogin.Location = new System.Drawing.Point(142, 349);
            this.lblCierraLogin.Name = "lblCierraLogin";
            this.lblCierraLogin.Size = new System.Drawing.Size(61, 15);
            this.lblCierraLogin.TabIndex = 6;
            this.lblCierraLogin.Text = "Cerrar";
            this.lblCierraLogin.Click += new System.EventHandler(this.LblCierraLogin_Click);
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(232)))));
            this.txtLoginUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginUser.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUser.ForeColor = System.Drawing.Color.White;
            this.txtLoginUser.Location = new System.Drawing.Point(87, 241);
            this.txtLoginUser.MaxLength = 12;
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(223, 24);
            this.txtLoginUser.TabIndex = 5;
            // 
            // btnIngresaLogin
            // 
            this.btnIngresaLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresaLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresaLogin.FlatAppearance.BorderSize = 0;
            this.btnIngresaLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIngresaLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresaLogin.Location = new System.Drawing.Point(85, 265);
            this.btnIngresaLogin.Name = "btnIngresaLogin";
            this.btnIngresaLogin.Size = new System.Drawing.Size(166, 47);
            this.btnIngresaLogin.TabIndex = 4;
            this.btnIngresaLogin.UseVisualStyleBackColor = false;
            // 
            // btnIngresa
            // 
            this.btnIngresa.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresa.FlatAppearance.BorderSize = 0;
            this.btnIngresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIngresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresa.Location = new System.Drawing.Point(102, 379);
            this.btnIngresa.Name = "btnIngresa";
            this.btnIngresa.Size = new System.Drawing.Size(164, 53);
            this.btnIngresa.TabIndex = 8;
            this.btnIngresa.UseVisualStyleBackColor = false;
            this.btnIngresa.Click += new System.EventHandler(this.btnIngresa_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(364, 431);
            this.Controls.Add(this.btnIngresa);
            this.Controls.Add(this.txtClaveLogin);
            this.Controls.Add(this.lblCierraLogin);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.btnIngresaLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Activated += new System.EventHandler(this.FrmLogin_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClaveLogin;
        private System.Windows.Forms.Label lblCierraLogin;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.Button btnIngresaLogin;
        private System.Windows.Forms.Button btnIngresa;
    }
}
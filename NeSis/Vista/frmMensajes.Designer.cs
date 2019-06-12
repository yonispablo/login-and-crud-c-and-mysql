namespace Vista
{
    partial class frmMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensajes));
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pctIcono = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnAceptarMensaje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // pctClose
            // 
            this.pctClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.pctClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pctClose.Image = ((System.Drawing.Image)(resources.GetObject("pctClose.Image")));
            this.pctClose.Location = new System.Drawing.Point(426, 0);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(36, 36);
            this.pctClose.TabIndex = 4;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pctIcono);
            this.panel1.Controls.Add(this.pctClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 36);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mensaje de sistema";
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
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMensaje.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(0, 39);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(462, 100);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "Mensaje";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptarMensaje
            // 
            this.btnAceptarMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnAceptarMensaje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAceptarMensaje.FlatAppearance.BorderSize = 3;
            this.btnAceptarMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarMensaje.Location = new System.Drawing.Point(178, 142);
            this.btnAceptarMensaje.Name = "btnAceptarMensaje";
            this.btnAceptarMensaje.Size = new System.Drawing.Size(93, 24);
            this.btnAceptarMensaje.TabIndex = 7;
            this.btnAceptarMensaje.Text = "ACEPTAR";
            this.btnAceptarMensaje.UseVisualStyleBackColor = false;
            this.btnAceptarMensaje.Visible = false;
            this.btnAceptarMensaje.Click += new System.EventHandler(this.BtnAceptarMensaje_Click);
            // 
            // frmMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(74)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(462, 168);
            this.Controls.Add(this.btnAceptarMensaje);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMensajes";
            this.Text = "frmMensajes";
            this.Load += new System.EventHandler(this.FrmMensajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnAceptarMensaje;
        private System.Windows.Forms.PictureBox pctIcono;
        private System.Windows.Forms.Label label1;
    }
}
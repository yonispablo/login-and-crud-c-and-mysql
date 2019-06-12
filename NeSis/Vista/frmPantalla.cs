using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class frmPantalla : Form
    {
        
        public static clsMUsuario userLogin = null;

        int coordY = 180;
        int cantSubmenus = 0;
        public frmPantalla()
        {
            InitializeComponent();
        }


        public void SetMensaje(string mensaje)
        {
            btnUsuario.Text = mensaje;
            
        }

        private void ocultarSubmenus()
        {
            foreach (Control pnl in pnlMenu.Controls)
            {
                if (pnl.GetType().ToString() == "System.Windows.Forms.Panel" && pnl.Name != "pnlDivisor")
                {
                    pnl.Visible = false;
                }
            }

            btnMenuParametros.Location = new Point(3, coordY);
            btnMenuOperaciones.Location = new Point(3, coordY + 40);
            btnMenuReportes.Location = new Point(3, coordY + 80);
        }
        private void FrmPantalla_Load(object sender, EventArgs e)
        {
            pctRestore.Enabled = false;
            ocultarSubmenus();

            frmLogin f = new frmLogin();
            f.StartPosition = FormStartPosition.CenterParent;
           
            DialogResult dial = f.ShowDialog();

            if (dial == DialogResult.Cancel)
            {
                btnUsuario.Text = f.activeUser;
            }

        }
        private void muestraFrnUsuarios(object frmUsuaro)
        {
            if (this.pnlApp.Controls.Count > 0) this.pnlApp.Controls.RemoveAt(0);
            Form frm = frmUsuaro as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            this.pnlApp.Controls.Add(frm);
            this.pnlApp.Tag = frm;
            frm.Show();

        }
        private void PctClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PctMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMenuParametros_Click(object sender, EventArgs e)
        {
            cantSubmenus = cuentaSubmenus(this.pnlParametros);

            if (pnlParametros.Visible == true)
            {
                pnlParametros.Visible = false;
                ocultarSubmenus();
            }
            else
            {
                ocultarSubmenus();
                pnlParametros.Visible = true;
                pnlParametros.Location = new Point(3, coordY + 40);
                btnMenuOperaciones.Location = new Point(3, coordY + ((cantSubmenus + 1) * 40));
                btnMenuReportes.Location = new Point(3, coordY + ((cantSubmenus + 2) * 40));
            }
        }

        private void BtnMenuOperaciones_Click(object sender, EventArgs e)
        {
            cantSubmenus = cuentaSubmenus(this.pnlOperaciones);

            if (pnlOperaciones.Visible == true)
            {
                pnlOperaciones.Visible = false;
                ocultarSubmenus();
            }
            else
            {
                ocultarSubmenus();
                pnlOperaciones.Visible = true;
                pnlOperaciones.Location = new Point(3, coordY + 80);
                btnMenuReportes.Location = new Point(3, coordY + ((cantSubmenus + 2) * 40));
            }
        }

        private void BtnMenuReportes_Click(object sender, EventArgs e)
        {
            cantSubmenus = cuentaSubmenus(this.pnlOperaciones);

            if (pnlReportes.Visible == true)
            {
                pnlReportes.Visible = false;
                ocultarSubmenus();
            }
            else
            {
                ocultarSubmenus();
                pnlReportes.Visible = true;
                pnlReportes.Location = new Point(3, coordY + 120);

            }
        }
       

        private int cuentaSubmenus(Control panel)
        {
            int contador = 0;
            foreach (Control btn in panel.Controls)
            {
                if (btn.GetType().ToString() == "System.Windows.Forms.Button")
                {
                    contador++;
                }
            }
            return contador;
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            //muestraFrnClientes(new frmClientes());

        }

        private void BtnRepUsuarios_Click(object sender, EventArgs e)
        {
            muestraFrnUsuarios(new frmUsuario());
        }
    }
}

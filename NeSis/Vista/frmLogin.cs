using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Negocio;
using Modelo;

namespace Vista
{
    public partial class frmLogin : Form
    {
        public string activeUser = "";
        private readonly clsNLogin userNLogin= new clsNLogin();
        private readonly clsNCrud _clsNCrud = new clsNCrud();

        //public IComFormMensaje envMensaje { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            this.BackColor = Color.Red;
            this.TransparencyKey = BackColor;
        }

        private void getMensaje(string mensaje)
        {
            Form frmM = new frmMensajes();
            frmM.StartPosition = FormStartPosition.CenterScreen;
            ((Label)frmM.Controls["lblMensaje"]).Text = mensaje;

            frmM.ShowDialog();
        }

        private void LblCierraLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Activated(object sender, EventArgs e)
        {
            txtLoginUser.Focus();
        }

        private void buscarUsuario(string alias, string clave)
        {
            if (frmPantalla.userLogin == null) frmPantalla.userLogin = new clsMUsuario();

            frmPantalla.userLogin = userNLogin.getUserLogin(alias, clave);

            if (userNLogin.stringBuilder.ToString() == "LOGUEADO")
            {
                string nombres = frmPantalla.userLogin.Nombres.ToString();
                string apellidos = frmPantalla.userLogin.Apellidos.ToString();
                getMensaje("BIENVENIDO " + nombres + " " + apellidos);
                activeUser ="Usuario: " + nombres + " " + apellidos;
                this.Dispose();
            }
            else
            {
                getMensaje(userNLogin.stringBuilder.ToString());
            }

            
        }

 
        private void btnIngresa_Click(object sender, EventArgs e)
        {
            string _alias = (string)txtLoginUser.Text;
            string _clave = _clsNCrud.codsHA512Cadena((string)txtClaveLogin.Text);

            buscarUsuario(_alias,_clave);  
        }

        private void TxtClaveLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                string _alias = (string)txtLoginUser.Text;
                string _clave = _clsNCrud.codsHA512Cadena((string)txtClaveLogin.Text);

                buscarUsuario(_alias, _clave);
            }
        }
    }
}

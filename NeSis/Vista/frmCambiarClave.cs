using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Modelo;

namespace Vista
{
    public partial class frmCambiarClave : Form
    {
        private readonly clsNCrud _clsNCrud = new clsNCrud();
        private readonly clsNUsuario _clsNUsuario = new clsNUsuario();
        private clsMUsuario _clsMUsuario = null;

        public IComunicacionForm IForm { get; set; }
        private string _oper = "";
        private int _id = 0;
        private string nuevaClave = "";

        
        string nombreId = "id_usuario";
        string[] camposEditar = {"clave"};
        
       

        public frmCambiarClave()
        {
            InitializeComponent();
        }

        public frmCambiarClave(string oper, int id) : this()
        {
            this._oper = oper;
            this._id = id;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            this.txtClaveActual.Focus();
        }

        private void PctClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string claveActual = (string)this.txtClaveActual.Text;

            if (_clsNUsuario.BuscarPorIdN(_id).Clave == _clsNCrud.codsHA512Cadena(claveActual))
            {
                if (!(string.IsNullOrEmpty((string)this.txtNuevaClave.Text) || ((string)this.txtNuevaClave.Text.Trim()).Length == 0))
                {
                    if (_clsNCrud.ComparaClaves((string)this.txtNuevaClave.Text, (string)this.txtRepNuevaClave.Text))
                    {
                        string nombres = _clsNUsuario.BuscarPorIdN(_id).Nombres;
                        string apellidos = _clsNUsuario.BuscarPorIdN(_id).Apellidos;

                        getMensajeAceptar("Confirmas el cambio de clave del usuario: " + Environment.NewLine + nombres + " " + apellidos);
                    }
                    else
                    {
                        getMensaje("Las nuevas claves no coinciden");
                    }
                }
                else
                {
                    getMensaje("Nueva clave no puede estar vacío");
                }       
            }
            else
            {
                getMensaje("Clave actual incorrecta");
            }
   
        }

        private void ModificarClave()
        {
           
            nuevaClave = ObtenerNuevaClave();

            ArrayList listaValoresEditar = new ArrayList();
            listaValoresEditar.Add(nuevaClave);
            string sqlQuery = ObtenerQuery(camposEditar, nombreId);
            LLenarUsuario(_id);

               
           _clsNUsuario.Registrar(_clsMUsuario, _oper, sqlQuery, null, camposEditar, null, listaValoresEditar, nombreId, _id);

           if (_clsNUsuario.stringBuilder.Length != 0)
           {
              if (_clsNUsuario.stringBuilder.ToString() == "modificado")
              {
                  getMensaje("OPERACIÓN EXITOSA");
              }
              else
              {
                  getMensaje(_clsNUsuario.stringBuilder.ToString());
              }
           }   
        }

        private string ObtenerNuevaClave()
        {
           string resultado = "";
           resultado = _clsNCrud.codsHA512Cadena((string)this.txtNuevaClave.Text);
            
           return resultado;
        }
        private string ObtenerQuery( string[] camposEditar, string nombreId)
        {
            string sqlQuery = "";
          
            sqlQuery = "UPDATE usuarios SET " + _clsNCrud.SerializarCamposUpdate(camposEditar) + " WHERE " + nombreId + " = " + "@" + nombreId;
                  
            return sqlQuery;
        }

        private clsMUsuario LLenarUsuario(int id)
        {
            if (_clsMUsuario == null) _clsMUsuario = new clsMUsuario();

            _clsMUsuario.Alias = _clsNUsuario.BuscarPorIdN(id).Alias;
            _clsMUsuario.Clave = nuevaClave;
            _clsMUsuario.Nombres = _clsNUsuario.BuscarPorIdN(id).Nombres;
            _clsMUsuario.Apellidos = _clsNUsuario.BuscarPorIdN(id).Apellidos;
            _clsMUsuario.Cargo = _clsNUsuario.BuscarPorIdN(id).Cargo;
            _clsMUsuario.Tipo = _clsNUsuario.BuscarPorIdN(id).Tipo;
            _clsMUsuario.Foto = _clsNUsuario.BuscarPorIdN(id).Foto;

            return _clsMUsuario;
        }

        private void getMensaje(string mensaje)
        {
            Form frmM = new frmMensajes();
            frmM.StartPosition = FormStartPosition.CenterScreen;
            ((Label)frmM.Controls["lblMensaje"]).Text = mensaje;

            DialogResult dr = frmM.ShowDialog();
        }
        private void getMensajeAceptar(string mensaje)
        {
            DialogResult dr = new DialogResult();
            Form frmC = new frmConfirmacion();
            frmC.StartPosition = FormStartPosition.CenterScreen;
            ((Label)frmC.Controls["lblMensaje"]).Text = mensaje;

            dr = frmC.ShowDialog();

            if (dr == DialogResult.OK)
            {
                ModificarClave();
                IForm.ActualizaGridUsuarios();
            }
            else
            {
                frmC.Close();
            }
        }

    }
}

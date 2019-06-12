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
    public partial class frmInsertEditUsuario : Form
    {
        private readonly clsNCrud _clsNCrud = new clsNCrud();
        private readonly clsNCargo _clsNCargo = new clsNCargo();
        private readonly clsNUsuario _clsNUsuario = new clsNUsuario();
        private clsMUsuario _clsMUsuario = null;

        string nombreId = "id_usuario";
        string[] camposInsertar = { "alias", "clave", "nombres", "apellidos", "id_cargo", "tipo", "foto" };
        string[] camposEditar = { "alias", "nombres", "apellidos", "id_cargo", "tipo", "foto" };

        public IComunicacionForm IForm { get; set; }

        private string _oper = "";
        private int _id = 0;

        public frmInsertEditUsuario()
        {
            InitializeComponent();
        }

        public frmInsertEditUsuario(string oper,int id = 0) :this()
        {
            this._oper = oper;
            this._id = id;
        }

        private void FrmInsertEditUsuario_Load(object sender, EventArgs e)
        {
            this.txtId.Text = _clsNCrud.getSiguienteID("nesys", "usuarios").ToString();

            List<clsMCargo> listaCargos = _clsNCargo.ListarTodos();

            this.cmbCargp.DataSource = listaCargos;
            this.cmbCargp.DisplayMember = "denominacion";
            this.cmbCargp.ValueMember = "idcargo";

            switch (_oper)
            {
                case "insertar":
                    this.cmbCargp.SelectedIndex = 0;

                    this.cmbTipo.SelectedIndex = 0;

                    this.txtCreado.Text = DateTime.Now.ToString();
                    this.txtModificado.Text = this.txtCreado.Text;
                    break;
                case "editar":
                    LLenarFormConUsuario(_clsNUsuario.BuscarPorIdN(_id));
           
                    if (_clsNUsuario.stringBuilder.Length > 0) MessageBox.Show(_clsNUsuario.stringBuilder.ToString());

                    this.lblClave.Visible = false;
                    this.txtClave.Visible = false;
                    this.lblRepClave.Visible = false;
                    this.txtRepClave.Visible = false;
                    this.panelUsuario.RowStyles[2].Height = 0;
                    this.panelUsuario.RowStyles[3].Height = 0;

                    this.pctSubirImagen.Location = new Point(272, 330);
                    this.pctEliminarImagen.Location = new Point(272, 383);
                    this.btnAceptar.Location = new Point(101, 474);
                    this.Size = new Size(412, 518);

                    break;
            }           
        }

        private void Guardar()
        {
            try
            {
                string sqlQuery = ObtenerQuery(_oper, camposInsertar, camposEditar,nombreId);
                LLenarUsuarioConForm();
                
                _clsNUsuario.Registrar(_clsMUsuario,_oper, sqlQuery, camposInsertar,camposEditar, ObtenerListaValoresInsertar(_clsMUsuario), ObtenerListaValoresEditar(_clsMUsuario), nombreId,_id);

                if (_clsNUsuario.stringBuilder.Length != 0)
                {
                    switch (_clsNUsuario.stringBuilder.ToString())
                    {
                        case "registrado":
                            IForm.ActualizaGridUsuarios();
                            getMensajeConfirmacion("OPERACIÓN EXITOSA" + Environment.NewLine + "Realizarás un nuevo registro?");
                            break;
                        case "modificado":
                            IForm.ActualizaGridUsuarios();
                            getMensaje("OPERACIÓN EXITOSA");
                            break;
                        case "repetido":
                            getMensaje("YA EXISTE UN REGISTRO CON ESTE CÓDIGO EN LA BASE DE DATOS");
                            break;
                        default:
                            getMensaje("ERROR " + _clsNUsuario.stringBuilder.ToString());
                            break;
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

       

        private void PctClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarForm()
        {
            this.txtId.Text = _clsNCrud.getSiguienteID("nesys", "usuarios").ToString();
            this.txtAlias.Clear();
            this.txtClave.Clear();
            this.txtRepClave.Clear();
            this.txtNombres.Clear();
            this.txtApellidos.Clear();
            this.cmbCargp.SelectedIndex = 0;
            this.cmbTipo.SelectedIndex = 0;
            LimpiarImagen();
            this.txtCreado.Text = DateTime.Now.ToString();
            this.txtModificado.Text = this.txtCreado.Text;
            this.txtAlias.Focus();
        }

        private string ObtenerQuery(string operacion, string[] camposInsertar, string[] camposEditar, string nombreId)
        {
            string sqlQuery = "";
            switch (operacion)
            {
                case "insertar":
                    sqlQuery = "INSERT INTO usuarios(" + _clsNCrud.SerializarCampos(camposInsertar) + ") VALUES (" + _clsNCrud.SerializarParametros(camposInsertar) + ")";
                    break;
                case "editar":
                    sqlQuery = "UPDATE usuarios SET " + _clsNCrud.SerializarCamposUpdate(camposEditar) + " WHERE " + nombreId + " = " + "@" + nombreId;
                    break;
            }
            return sqlQuery;
        }

        private ArrayList ObtenerListaValoresInsertar(clsMUsuario _usuario)
        {
            ArrayList listaValores = new ArrayList();
            listaValores.Add(_usuario.Alias);
            listaValores.Add(_usuario.Clave);
            listaValores.Add(_usuario.Nombres);
            listaValores.Add(_usuario.Apellidos);
            listaValores.Add(_usuario.Cargo);
            listaValores.Add(_usuario.Tipo);
            listaValores.Add(_usuario.Foto);

            return listaValores;
        }

        private ArrayList ObtenerListaValoresEditar(clsMUsuario _usuario)
        {
            ArrayList listaValores = new ArrayList();
            listaValores.Add(_usuario.Alias);
            listaValores.Add(_usuario.Nombres);
            listaValores.Add(_usuario.Apellidos);
            listaValores.Add(_usuario.Cargo);
            listaValores.Add(_usuario.Tipo);
            listaValores.Add(_usuario.Foto);

            return listaValores;
        }

        private clsMUsuario LLenarUsuarioConForm()
        {
            if (_clsMUsuario == null) _clsMUsuario = new clsMUsuario();

            _clsMUsuario.Alias = (string)this.txtAlias.Text;
            if (string.IsNullOrEmpty((string)this.txtClave.Text) || ((string)this.txtClave.Text.Trim()).Length == 0)
            {
                _clsMUsuario.Clave = "";
            }
            else
            {
                _clsMUsuario.Clave = _clsNCrud.codsHA512Cadena((string)this.txtClave.Text);
            }

            _clsMUsuario.Nombres = (string)this.txtNombres.Text;
            _clsMUsuario.Apellidos = (string)this.txtApellidos.Text;
            _clsMUsuario.Cargo = (int)this.cmbCargp.SelectedValue;
            _clsMUsuario.Tipo = (string)this.cmbTipo.Text;

            if (pctFoto.Image != null)
            {
                _clsMUsuario.Foto = (byte[])_clsNCrud.ImageToByte(this.pctFoto.Image);
            }
            else
            {
                _clsMUsuario.Foto = null;
            }

            return _clsMUsuario;
        }

        private void LLenarFormConUsuario(clsMUsuario _usuario)
        {
            this.txtId.Text = _usuario.IdUsuario.ToString();
            this.txtAlias.Text = _usuario.Alias;
            this.txtClave.Text = _usuario.Clave;
            this.txtRepClave.Text = _usuario.Clave;
            this.txtNombres.Text = _usuario.Nombres;
            this.txtApellidos.Text = _usuario.Apellidos;
            this.cmbTipo.Text = _usuario.Tipo;
            this.cmbCargp.Text = _clsNCargo.BuscarPorIdN(_usuario.Cargo).Denominacion;
            this.pctFoto.Image = _clsNCrud.ByteArrayToImage(_usuario.Foto);
            this.pctFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            this.txtCreado.Text = _usuario.Creado.ToString();
            this.txtModificado.Text = _usuario.Actualizado.ToString();
        }

        private void PctSubirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileImage = new OpenFileDialog();
            openFileImage.Title = "Buscar imagen";
            openFileImage.Filter = "Imágenes JPG|*.jpg";

            if (openFileImage.ShowDialog() == DialogResult.OK)
            {
                this.pctFoto.Image = Image.FromFile(openFileImage.FileName);
                this.pctFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void PctEliminarImagen_Click(object sender, EventArgs e)
        {
            LimpiarImagen();
        }

        private void LimpiarImagen()
        {
            if (this.pctFoto.Image != null)
            {
                this.pctFoto.Image.Dispose();
                this.pctFoto.Image = null;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            switch (_oper)
            {
                case "insertar":
                    getMensajeAceptar("Confirmas la grabación del registro?");
                    break;
                case "editar":
                    getMensajeAceptar("Confirmas la edición del registro?");
                    break;
            }  
        }

       private void getMensajeConfirmacion(string mensaje)
       {
            DialogResult dr = new DialogResult();
            Form frmC = new frmConfirmacion();
            frmC.StartPosition = FormStartPosition.CenterScreen;
            ((Label)frmC.Controls["lblMensaje"]).Text = mensaje;

            dr = frmC.ShowDialog();

            if (dr == DialogResult.OK)
            {
                LimpiarForm();
            }
            else
            {
                this.Close();
            }
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
                Guardar();
            }
            else
            {
                this.Close();
            }
        }

        private void getMensaje(string mensaje)
        {
            Form frmM = new frmMensajes();
            frmM.StartPosition = FormStartPosition.CenterScreen;
            ((Label)frmM.Controls["lblMensaje"]).Text = mensaje;

            DialogResult dr = frmM.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                this.Close();
            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Modelo;
using Negocio;

namespace Vista
{
    public partial class frmUsuario : Form, IComunicacionForm
    {
        private readonly clsNUsuario _clsNUsuario = new clsNUsuario();

        private int idUsuario = 0;
        private string operacion = "";
        private string campoBusquedaActivo = "";
        private string textoABuscar = "";
        private int totalRegistros = 0;
        private int nuPaginas = 0;
        private int pagina = 1;
        private int regInicialPorPagina = 1;
        private int regFinalPorPagina = 1;
        private bool verificaBusqueda = false;

        public frmUsuario()
        {
            InitializeComponent();
            this.grdUsuarios.Columns["foto"].DefaultCellStyle.NullValue = null;
            this.grdUsuarios.RowTemplate.Height = 25;
        }

        public void ActualizaGridUsuarios()
        {
            pagina = this.cmbPaginaN.SelectedIndex + 1;
            if (!verificaBusqueda)
            {
                llenarGrilla("todos", ObtenerLimites()[0], ObtenerLimites()[1]);
            }
            else
            {
                textoABuscar = (string)this.txtBuscar.Text;
                llenarGrilla("criterio", ObtenerLimites()[0], ObtenerLimites()[1], ObtenerCampoBusqueda(), textoABuscar);
            }

        }
   
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            DataGridViewCellStyle stl = new DataGridViewCellStyle();
            stl.Alignment = DataGridViewContentAlignment.MiddleRight;
            stl.BackColor = Color.Snow;
            stl.ForeColor = Color.Magenta;
            stl.SelectionForeColor = Color.Aquamarine;
         
            DataGridViewButtonColumn clnEditar = new DataGridViewButtonColumn();
            clnEditar.Name = "editar";
            clnEditar.Text = "editar";
            clnEditar.HeaderText = "EDITA";
            clnEditar.UseColumnTextForButtonValue = true;
            clnEditar.FlatStyle = FlatStyle.Flat;
            clnEditar.Width = 75;
            clnEditar.CellTemplate.Style.Font = new Font("lucida console", 9, FontStyle.Underline);
            clnEditar.DefaultCellStyle = stl;


            DataGridViewButtonColumn clnEliminar= new DataGridViewButtonColumn();
            clnEliminar.Name = "eliminar";
            clnEliminar.Text = "eliminar";
            clnEliminar.HeaderText = "ELIMINA";
            clnEliminar.UseColumnTextForButtonValue = true;
            clnEliminar.FlatStyle = FlatStyle.Flat;
            clnEliminar.Width = 95;
            clnEliminar.CellTemplate.Style.Font = new Font("lucida console", 10, FontStyle.Underline);
            clnEliminar.DefaultCellStyle = stl;

            DataGridViewButtonColumn clnCambiarClave = new DataGridViewButtonColumn();
            clnCambiarClave.Name = "cambiarclave";
            clnCambiarClave.Text = "cambiar";
            clnCambiarClave.HeaderText = "CLAVE";
            clnCambiarClave.UseColumnTextForButtonValue = true;
            clnCambiarClave.FlatStyle = FlatStyle.Flat;
            clnCambiarClave.Width = 87;
            clnCambiarClave.CellTemplate.Style.Font = new Font("lucida console", 10, FontStyle.Underline);
            clnCambiarClave.DefaultCellStyle = stl;

            this.grdUsuarios.Columns.Add(clnEditar);
            this.grdUsuarios.Columns.Add(clnEliminar);
            this.grdUsuarios.Columns.Add(clnCambiarClave);

            this.grdUsuarios.Columns["creado"].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm");
            this.grdUsuarios.Columns["actualizado"].DefaultCellStyle.Format = ("dd/MM/yyyy HH:mm");
            this.cmbRegPorPagina.SelectedIndex = 0;

            this.lblMostrando.Text = "Mostrando 1 a " + this.cmbRegPorPagina.Text + " de " + totalRegistros;
            this.lblPaginas.Text = "de " + nuPaginas;
        }

        public void llenarGrilla(string filtro,int reg_inicial,int cant_registros, string columna = "alias", string valor = "")
        {
            grpUsuarios.Text = "Lista de usuarios :: Registro 0 de 0";

            //Limpiar grilla antes de cargarla
            LimpiarImages();
            grdUsuarios.Rows.Clear();

            List<clsMUsuario> lista = null;

            if(filtro == "todos")
            {
                lista = _clsNUsuario.ListarTodos(reg_inicial, cant_registros);
                if (lista != null)
                {
                    if (lista.Count > 0)
                    {
                        foreach (var reg in lista)
                        {
                            grdUsuarios.Rows.Add(reg.IdUsuario,reg.Alias,reg.Clave,reg.Nombres,reg.Apellidos,reg.Foto,reg.Creado,reg.Actualizado);
                        }
                        grdUsuarios.CurrentCell = grdUsuarios[1, 0];
                        grpUsuarios.Text = "Lista de usuarios :: Registro 1 de " + lista.Count;
                    }
                    else
                    {
                        this.grdUsuarios.Rows.Clear();
                    }   
                }
            }
            else
            {
                lista = _clsNUsuario.ListarPorColumna(columna, valor, reg_inicial, cant_registros);
                if (lista != null)
                {
                    if (lista.Count > 0)
                    {
                        foreach (var reg in lista)
                        {
                            grdUsuarios.Rows.Add(reg.IdUsuario, reg.Alias, reg.Clave, reg.Nombres, reg.Apellidos, reg.Foto, reg.Creado, reg.Actualizado);
                        }
                        grdUsuarios.CurrentCell = grdUsuarios[1, 0];
                        grpUsuarios.Text = "Lista de usuarios :: Registro 1 de " + lista.Count;
                    }
                    else
                    {
                        this.grdUsuarios.Rows.Clear();
                    }
                }
            }         
        }
        private void PctClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void GrdUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.grdUsuarios.Columns[e.ColumnIndex].Name == "editar" && e.RowIndex >=0)
            {
                
                e.Paint(e.CellBounds,DataGridViewPaintParts.All);
                DataGridViewButtonCell btnCelda = this.grdUsuarios.Rows[e.RowIndex].Cells["editar"] as DataGridViewButtonCell;
                
                Icon icoEditar = new Icon(Environment.CurrentDirectory + @"\\editar.ico");

                e.Graphics.DrawIcon(icoEditar,e.CellBounds.Left + 3,e.CellBounds.Top + 2);
              
                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.grdUsuarios.Columns[e.ColumnIndex].Name == "eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell btnCelda = this.grdUsuarios.Rows[e.RowIndex].Cells["eliminar"] as DataGridViewButtonCell;

                Icon icoEditar = new Icon(Environment.CurrentDirectory + @"\\eliminar.ico");

                e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 3, e.CellBounds.Top + 2);

                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.grdUsuarios.Columns[e.ColumnIndex].Name == "cambiarclave" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell btnCelda = this.grdUsuarios.Rows[e.RowIndex].Cells["cambiarclave"] as DataGridViewButtonCell;

                Icon icoEditar = new Icon(Environment.CurrentDirectory + @"\\cclave.ico");

                e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 3, e.CellBounds.Top + 2);

                e.Handled = true;
            }
        }

        private void GrdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex != -1)
            {
                if (this.grdUsuarios.Columns[e.ColumnIndex].Name == "editar")
                {
                    if (e.RowIndex != -1)
                    {                      
                        operacion = "editar";
                        idUsuario = (int)this.grdUsuarios.Rows[e.RowIndex].Cells["id"].Value;
                        string nombres = _clsNUsuario.BuscarPorIdN(idUsuario).Nombres;
                        string apellidos = _clsNUsuario.BuscarPorIdN(idUsuario).Apellidos;

                        frmInsertEditUsuario f = new frmInsertEditUsuario(operacion, idUsuario);
                        f.StartPosition = FormStartPosition.CenterParent;
                        f.IForm = this;

                        DialogResult dial = f.ShowDialog();
                    }
                }

                if (this.grdUsuarios.Columns[e.ColumnIndex].Name == "cambiarclave")
                {
                    if (e.RowIndex != -1)
                    {
                        operacion = "editar";
                        idUsuario = (int)this.grdUsuarios.Rows[e.RowIndex].Cells["id"].Value;

                        frmCambiarClave f = new frmCambiarClave(operacion, idUsuario);
                        f.StartPosition = FormStartPosition.CenterParent;
                        f.IForm = this;
                        DialogResult dial = f.ShowDialog();
                      
                    }
                }

                if (this.grdUsuarios.Columns[e.ColumnIndex].Name == "eliminar")
                {
                    if (e.RowIndex != -1)
                    {
                        operacion = "eliminar";
                        idUsuario = (int)this.grdUsuarios.Rows[e.RowIndex].Cells["id"].Value;
                        string nombres = _clsNUsuario.BuscarPorIdN(idUsuario).Nombres;
                        string apellidos = _clsNUsuario.BuscarPorIdN(idUsuario).Apellidos; 
                        getMensajeAceptar("Confirmas la eliminación del usuario: " + Environment.NewLine + nombres + " " + apellidos);
                    }
                }

            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            operacion = "insertar";

            frmInsertEditUsuario f = new frmInsertEditUsuario(operacion);
            f.StartPosition = FormStartPosition.CenterParent;
            f.IForm = this;
            DialogResult dial = f.ShowDialog();
        }

        private void Eliminar()
        {
            string nombreId = "id_usuario";
            string sqlQuery = "DELETE FROM usuarios WHERE " + nombreId + " = " + "@" + nombreId; ;

            _clsNUsuario.Eliminar(sqlQuery, nombreId, idUsuario);

            if (_clsNUsuario.stringBuilder.ToString() == "eliminado")
            {
                ActualizaGridUsuarios();
                getMensaje("REGISTRO ELIMINADO CON ÉXITO");
            }
            else
            {
                getMensaje("ERROR " + _clsNUsuario.stringBuilder.ToString());
            }
        }


        private string ObtenerCampoBusqueda()
        {
            if (this.rdAlias.Checked == true) campoBusquedaActivo = "alias";
            if (this.rdNombres.Checked == true) campoBusquedaActivo = "nombres";
            if (this.rdApellidos.Checked == true) campoBusquedaActivo = "apellidos";
            return campoBusquedaActivo;
        }

        private void llenarComboPaginaN(string filtro,string columna ="alias",string valor="")
        {
            this.cmbPaginaN.Items.Clear();
            int cant_paginas = 0;
            int total_registros = 0;
            int reg_por_paginas = Convert.ToInt32(this.cmbRegPorPagina.Text);

            if (filtro == "todos")
            {
                total_registros = _clsNUsuario.ContarTodosRegistrosN("todos");
            }
            else
            {
                total_registros = _clsNUsuario.ContarTodosRegistrosN("criterio", columna, valor);
            }

            
            decimal resultado_division = (decimal)total_registros / (decimal)reg_por_paginas;

            cant_paginas = Convert.ToInt32(Math.Ceiling(resultado_division));

            if (cant_paginas > 0)
            {
                nuPaginas = cant_paginas;
                totalRegistros = total_registros;
                for (int i = 1; i <= cant_paginas; i++)
                {
                    this.cmbPaginaN.Items.Add(i);
                }
                this.cmbPaginaN.SelectedIndex = 0;
            }
            else
            {
                this.cmbPaginaN.Items.Clear();
            }
        }

        private int[] ObtenerLimites()
        {
            int inicio = 0;
            int reg_por_paginas = Convert.ToInt32(this.cmbRegPorPagina.Text);
            

            if (totalRegistros > 0)
            {
                int indice = pagina - 1;
                if (indice == 0)
                {
                    inicio = 0;
                }
                else if(indice > 0)
                {
                    
                    inicio = indice * reg_por_paginas;
                }        
            }

            int[] resultado = new int[] { inicio, reg_por_paginas };
            return resultado;
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
                Eliminar();                
            }
            else
            {
                frmC.Close();
            }
        }

        private void getMensaje(string mensaje)
        {
            Form frmM = new frmMensajes();
            frmM.StartPosition = FormStartPosition.CenterScreen;
            ((Label)frmM.Controls["lblMensaje"]).Text = mensaje;

            DialogResult dr = frmM.ShowDialog();
        }


        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (!(string.IsNullOrEmpty((string)this.txtBuscar.Text) || ((string)this.txtBuscar.Text.Trim()).Length == 0))
                {
                    verificaBusqueda = true;
                    textoABuscar = (string)this.txtBuscar.Text;
                    llenarComboPaginaN("criterio", ObtenerCampoBusqueda(), textoABuscar);


                    pagina = this.cmbPaginaN.SelectedIndex + 1;
                    regInicialPorPagina = ObtenerLimites()[0] + 1;
                    regFinalPorPagina = ObtenerLimites()[0] + ObtenerLimites()[1];

                    if (regFinalPorPagina >= totalRegistros)
                    {
                        this.lblMostrando.Text = "Mostrando " + regInicialPorPagina + " a " + totalRegistros + " de " + totalRegistros;
                    }
                    else
                    {
                        this.lblMostrando.Text = "Mostrando " + regInicialPorPagina + " a " + regFinalPorPagina + " de " + totalRegistros;
                    }

                    llenarGrilla("criterio", ObtenerLimites()[0], ObtenerLimites()[1], ObtenerCampoBusqueda(), textoABuscar);
                }
                else
                {
                    verificaBusqueda = false;
                    llenarComboPaginaN("todos");
                    llenarGrilla("todos", ObtenerLimites()[0], ObtenerLimites()[1]);
                }

                this.lblPaginas.Text = "de " + nuPaginas;
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty((string)this.txtBuscar.Text) || ((string)this.txtBuscar.Text.Trim()).Length == 0))
            {
                verificaBusqueda = true;
                textoABuscar = (string)this.txtBuscar.Text;
                llenarComboPaginaN("criterio",ObtenerCampoBusqueda(),textoABuscar);
                

                pagina = this.cmbPaginaN.SelectedIndex + 1;
                 regInicialPorPagina = ObtenerLimites()[0] + 1;
                 regFinalPorPagina = ObtenerLimites()[0] + ObtenerLimites()[1];

                 if (regFinalPorPagina >= totalRegistros)
                 {
                     this.lblMostrando.Text = "Mostrando " + regInicialPorPagina + " a " + totalRegistros + " de " + totalRegistros;
                 }
                 else
                 {
                     this.lblMostrando.Text = "Mostrando " + regInicialPorPagina + " a " + regFinalPorPagina + " de " + totalRegistros;
                 }
                
                llenarGrilla("criterio", ObtenerLimites()[0], ObtenerLimites()[1], ObtenerCampoBusqueda(), textoABuscar);
            }
            else
            {
                verificaBusqueda = false;
                llenarComboPaginaN("todos");
                llenarGrilla("todos", ObtenerLimites()[0], ObtenerLimites()[1]);
            }

            this.lblPaginas.Text = "de " + nuPaginas;
        }

        private void PctSiguiente_Click(object sender, EventArgs e)
        {
            if (nuPaginas > 1)
            {
                if (pagina < nuPaginas)
                {
                    pagina += 1;
                }

                this.cmbPaginaN.SelectedIndex = pagina - 1;
            }
        }

        private void PctAnterior_Click(object sender, EventArgs e)
        {
            if (nuPaginas > 1)
            {
                if (pagina > 1 && pagina <= nuPaginas)
                {
                    pagina -= 1 ;
                }

                this.cmbPaginaN.SelectedIndex = pagina - 1;
            }
        }

        private void PctPrimero_Click(object sender, EventArgs e)
        {
            pagina = 1;
            this.cmbPaginaN.SelectedIndex = pagina - 1;
        }

        private void PctUltimo_Click(object sender, EventArgs e)
        {
            pagina = nuPaginas;
            this.cmbPaginaN.SelectedIndex = pagina - 1;
        }

        private void CmbPaginaN_SelectedIndexChanged(object sender, EventArgs e)
        {
            pagina = this.cmbPaginaN.SelectedIndex + 1;
            regInicialPorPagina = ObtenerLimites()[0] + 1;
            regFinalPorPagina = ObtenerLimites()[0] + ObtenerLimites()[1];

            if (regFinalPorPagina >= totalRegistros)
            {
                this.lblMostrando.Text = "Mostrando " + regInicialPorPagina + " a " + totalRegistros + " de " + totalRegistros;
            }
            else
            {
                this.lblMostrando.Text = "Mostrando " + regInicialPorPagina + " a " + regFinalPorPagina + " de " + totalRegistros;
            }

            if (!verificaBusqueda)
            {
                llenarGrilla("todos", ObtenerLimites()[0], ObtenerLimites()[1]);
            }
            else
            {
                textoABuscar = (string)this.txtBuscar.Text;
                llenarGrilla("criterio", ObtenerLimites()[0], ObtenerLimites()[1],ObtenerCampoBusqueda(), textoABuscar);
            }
           
        }
        private void CmbRegPorPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!verificaBusqueda)
            {
                llenarComboPaginaN("todos");
            }
            else
            {
                textoABuscar = (string)this.txtBuscar.Text;
                llenarComboPaginaN("criterio", ObtenerCampoBusqueda(), textoABuscar);
            }
           
           this.lblPaginas.Text = "de " + nuPaginas;
        }

        private void LimpiarImages()
        {
            foreach (DataGridViewRow row in this.grdUsuarios.Rows)
            {
                row.Cells["foto"].Value = null;
                //MessageBox.Show(row.Cells["ID"].Value.ToString());


            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            foreach ( DataGridViewRow row in this.grdUsuarios.Rows)
            {
                row.Cells["foto"].Value = null;
                //MessageBox.Show(row.Cells["ID"].Value.ToString());
                
               
            }
        }

        private void GrdUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            //this.grdUsuarios.Rows[e.RowIndex].Cells["foto"].Value = null;
           /* if (this.grdUsuarios.Columns[e.ColumnIndex].Name == "foto")
            {

            }*/
        }
    }
}


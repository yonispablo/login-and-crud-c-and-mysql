using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelo;

namespace Negocio
{
    public class clsNUsuario
    {
        public readonly StringBuilder stringBuilder = new StringBuilder();

        //Instanciamos nuestra clase clsCrudUsuarios para poder utilizar sus miembros
        private clsDCrudUsuarios _crudUsuarios = new clsDCrudUsuarios();

        public int ContarTodosRegistrosN(string filtro,string columna ="alias",string valor="")
        {
            int resultado = 0;

            if (filtro == "todos")
            {
                resultado = _crudUsuarios.ContarTodosRegistros("todos");
            }
            else
            {
                resultado = _crudUsuarios.ContarTodosRegistros("criterio", columna, valor);
            }

          
            stringBuilder.Append(_crudUsuarios.stringBuilder.ToString());
            return resultado;   
        }


        //Método que lista todos los usuarios
        public List<clsMUsuario> ListarTodos(int primer_registro = 0 ,int nu_registros = 10)
        {
            List<clsMUsuario> res = null;
            stringBuilder.Clear();

            res = _crudUsuarios.Listar("todos", primer_registro, nu_registros);
            stringBuilder.Append(_crudUsuarios.stringBuilder.ToString());

            return res;
        }


        //Método que lista los usuarios por una columna determinada
        public List<clsMUsuario> ListarPorColumna(string columna, string valor, int primer_registro = 0, int nu_registros = 10)
        {
            List<clsMUsuario> res = null;
            stringBuilder.Clear();

            res = _crudUsuarios.Listar("criterio", primer_registro, nu_registros,columna,valor);
            stringBuilder.Append(_crudUsuarios.stringBuilder.ToString());
          
            return res;
        }

        public clsMUsuario BuscarPorIdN(int id)
        {
            clsMUsuario res = null;

            stringBuilder.Clear();
            if (_crudUsuarios.BuscarPorId(id) != null)
            {
                res = _crudUsuarios.BuscarPorId(id);
                stringBuilder.Append(_crudUsuarios.stringBuilder.ToString());
            }

            return res;
        }

        public void Registrar(clsMUsuario _usuario,string operacion, string sqlQuery, string[] camposInsertar, string[] camposEditar, ArrayList valoresInsertar, ArrayList valoresEditar, string nombreId, int valorId)
        {
            stringBuilder.Clear();
            switch (operacion)
            {
                case "insertar":
                    if (ValidarUsuario(_usuario))
                    {
                        if (_crudUsuarios.BuscarPorAlias(_usuario.Alias) == null)
                        {
                            bool resultado = _crudUsuarios.Insertar(sqlQuery, camposInsertar, valoresInsertar);
                            if (resultado)
                            {
                                stringBuilder.Append("registrado");
                            }
                            else
                            {
                                stringBuilder.Append(_crudUsuarios.stringBuilder.ToString());
                            }
                        }
                        else
                        {
                            stringBuilder.Append("repetido");
                        }
                    }
                    break;
                case "editar":
                    if (ValidarUsuario(_usuario))
                    {
                        bool resultado = _crudUsuarios.Editar(sqlQuery, camposEditar, valoresEditar,nombreId, valorId);
                        if (resultado)
                        {
                            stringBuilder.Append("modificado");
                        }
                        else
                        {
                            stringBuilder.Append(_crudUsuarios.stringBuilder.ToString());
                        }
                    }
                    break;
            }              
        }

        public void Eliminar(string sqlQuery, string nombreId, int valorId)
        {
            bool resultado = _crudUsuarios.Eliminar(sqlQuery, nombreId, valorId);

            if (resultado)
            {
                stringBuilder.Append("eliminado");
            }
            else
            {
                stringBuilder.Append(_crudUsuarios.stringBuilder.ToString());
            }
        }

        

        // Método que valida los campos obligatorios
        private bool ValidarUsuario(clsMUsuario _usuario)
        {
            stringBuilder.Clear();
            if (string.IsNullOrEmpty(_usuario.Alias)) stringBuilder.Append("El campo Alias es obligatorio");
            if (string.IsNullOrEmpty(_usuario.Clave)) stringBuilder.Append(Environment.NewLine + "El campo Clave es obligatorio");
            if (string.IsNullOrEmpty(_usuario.Nombres)) stringBuilder.Append(Environment.NewLine + "El campo Nombres es obligatorio");
            if (string.IsNullOrEmpty(_usuario.Apellidos)) stringBuilder.Append(Environment.NewLine + "El campo Apellidos es obligatorio");

            return stringBuilder.Length == 0;
        }
    }
}

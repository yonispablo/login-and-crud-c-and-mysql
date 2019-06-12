using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;

namespace Datos
{
    public class clsDCrudUsuarios : clsDCrud
    {
        private clsDConexion cnn = new clsDConexion();
        private MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rdr;

        public List<clsMUsuario> Listar(string filtro, int primer_registro = 0, int nu_registros = 10, string columna = "alias", string valor = "")
        {
        
            List<clsMUsuario> listaUsuarios = new List<clsMUsuario>();

            stringBuilder.Clear();
            string sqlQuery = "";
            try
            {
                cmd.Connection = cnn.abrirConexion();
                
                switch (filtro)
                {
                   case "todos":
                     sqlQuery = "SELECT * FROM  usuarios ORDER BY id_usuario LIMIT " + primer_registro + "," + nu_registros;
                     break;
                   case "criterio":
                     sqlQuery = "SELECT * FROM usuarios WHERE " + columna + " like '%" + valor + "%' ORDER BY id_usuario LIMIT " + primer_registro + "," + nu_registros;
                     break;
                }
                       
                cmd.CommandText = sqlQuery;
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    { 
                        listaUsuarios.Add(llenarUsuario());
                    }

                    rdr.Close();
                    cmd.Connection = cnn.cerrarConexion();
                    return listaUsuarios;
                }
                else
                {
                    listaUsuarios = null;
                    if (rdr != null) rdr.Close();
                    return listaUsuarios;
                }

            }
            catch (MySqlException e)
            {
                if (rdr != null) rdr.Close();
                stringBuilder.Append("ERROR " + e.Message + e.StackTrace);
                return null;
            }
            finally
            {
                if (rdr != null) rdr.Close();
                cmd.Connection = cnn.cerrarConexion();
            }
        }

        public int ContarTodosRegistros(string filtro,string columna = "alias", string valor = "")
        {
            int resultado = 0;
            stringBuilder.Clear();
            string sqlQuery = "";

            try
            {
                cmd.Connection = cnn.abrirConexion();
                if (filtro == "todos")
                {
                    sqlQuery = "SELECT COUNT(*) FROM usuarios";
                }
                else
                {
                    sqlQuery = "SELECT COUNT(*) FROM usuarios WHERE " + columna + " like '%" + valor + "%' ORDER BY id_usuario";
                }

                cmd.CommandText = sqlQuery;
                resultado = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (MySqlException e)
            {
                stringBuilder.Append("ERROR " + e.Message + e.StackTrace);
            }
            finally
            {
                cmd.Connection = cnn.cerrarConexion();
            }
            return resultado;
        }

       
        public clsMUsuario BuscarPorAlias(string alias)
        {
            cmd.Parameters.Clear();

            clsMUsuario _usuario = new clsMUsuario();
            stringBuilder.Clear();
            string sqlQuery = "SELECT * FROM usuarios WHERE alias = @alias";

            try
            {
                cmd.Connection = cnn.abrirConexion();
                cmd.CommandText = sqlQuery;

                cmd.Parameters.AddWithValue("@alias", alias);
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    rdr.Read();

                    _usuario = llenarUsuario();

                    rdr.Close();
                    cmd.Connection = cnn.cerrarConexion();
                    return _usuario;
                }
                else
                {
                    if (rdr != null) rdr.Close();
                    return null;
                }

            }
            catch (MySqlException e)
            {
                if (rdr != null) rdr.Close();
                stringBuilder.Append("ERROR " + e.Message + e.StackTrace);
                return null;
            }
            finally
            {
                if (rdr != null) rdr.Close();
                cmd.Connection = cnn.cerrarConexion();
            }
        }

        public clsMUsuario BuscarPorId(int id)
        {
            cmd.Parameters.Clear();

            clsMUsuario _usuario = new clsMUsuario();
            stringBuilder.Clear();
            string sqlQuery = "SELECT * FROM usuarios WHERE id_usuario = @id_usuario";

            try
            {
                cmd.Connection = cnn.abrirConexion();
                cmd.CommandText = sqlQuery;

                cmd.Parameters.AddWithValue("@id_usuario", id);
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    rdr.Read();

                    _usuario = llenarUsuario();

                    rdr.Close();
                    cmd.Connection = cnn.cerrarConexion();
                    return _usuario;
                }
                else
                {
                    if (rdr != null) rdr.Close();
                    return null;
                }

            }
            catch (MySqlException e)
            {
                if (rdr != null) rdr.Close();
                stringBuilder.Append("ERROR " + e.Message + e.StackTrace);
                return null;
            }
            finally
            {
                if (rdr != null) rdr.Close();
                cmd.Connection = cnn.cerrarConexion();
            }
        }

        public clsMUsuario llenarUsuario()
        {
            clsMUsuario _usuario = new clsMUsuario();

            _usuario.IdUsuario = (int)rdr["id_usuario"];
            _usuario.Alias = (string)rdr["alias"];
            _usuario.Clave = (string)rdr["clave"];
            _usuario.Nombres = (string)rdr["nombres"];
            _usuario.Apellidos = (string)rdr["apellidos"];
            _usuario.Cargo = (int)rdr["id_cargo"];
            _usuario.Tipo = (string)rdr["tipo"];

            if (rdr["foto"] != System.DBNull.Value)
            {
                _usuario.Foto = (byte[])rdr["foto"];
            }
            else
            {
                _usuario.Foto = null;
            }

            _usuario.Creado = (DateTime)rdr["creado"];
            _usuario.Actualizado = (DateTime)rdr["actualizado"];

            return _usuario;
        }
    }
}

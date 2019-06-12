using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;

namespace Datos
{
    public class clsDLogin
    {
        public readonly StringBuilder stringBuilder = new StringBuilder();
        private clsDConexion cnn = new clsDConexion();

        MySqlDataReader rdr;
        MySqlCommand cmd = new MySqlCommand();

        public clsMUsuario getUserLogin(string alias, string clave)
        {
            stringBuilder.Clear();
            try
            {
                cmd.Connection = cnn.abrirConexion();
                string loginQuery = "SELECT id_usuario,alias, clave, nombres, apellidos,id_cargo FROM usuarios WHERE alias = @alias AND clave = @clave";
                cmd.CommandText = loginQuery;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@alias", alias);
                cmd.Parameters.AddWithValue("@clave", clave);

                rdr = cmd.ExecuteReader();
               
                if (rdr.HasRows)
                {
                    rdr.Read();
                    clsMUsuario _userLogin = new clsMUsuario();

                    _userLogin.IdUsuario = (int)rdr["id_usuario"];
                    _userLogin.Alias = (string)rdr["alias"];
                    _userLogin.Clave = (string)rdr["clave"];
                    _userLogin.Nombres = (string)rdr["nombres"];
                    _userLogin.Apellidos = (string)rdr["apellidos"];
                    _userLogin.Cargo = (int)rdr["id_cargo"];

                    stringBuilder.Append("LOGUEADO");
                    
                    rdr.Close();
                    cmd.Connection = cnn.cerrarConexion();
                    return _userLogin;
                }
                else
                {
                    rdr.Close();
                    stringBuilder.Append("CREDENCIALES INCORRECTAS");
                    return null;
                }

            }
            catch (MySqlException e)
            {
                if (rdr != null) rdr.Close();
                stringBuilder.Append("ERROR " + e.Message + e.StackTrace);
                return null;
            }
           
        }
       
    }
}

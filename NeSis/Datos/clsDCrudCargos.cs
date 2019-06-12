using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;

namespace Datos
{
    public class clsDCrudCargos
    {
        public readonly StringBuilder stringBuilder = new StringBuilder();
        private clsDConexion cnn = new clsDConexion();

        MySqlDataReader rdr;
        MySqlCommand cmd = new MySqlCommand();
        public List<clsMCargo> getAll(string filtro, string columna = "", string valor = "")
        {
            List<clsMCargo> listaCargos = new List<clsMCargo>();

            stringBuilder.Clear();
            string sqlQuery = "";
            try
            {
                cmd.Connection = cnn.abrirConexion();

                switch (filtro)
                {
                    case "todos":
                        sqlQuery = "SELECT * FROM cargos";
                        break;
                    case "criterio":
                        sqlQuery = "SELECT * FROM cargos WHERE " + columna + " like '%" + valor + "%' ORDER BY " + columna;
                        break;
                }

                cmd.CommandText = sqlQuery;
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        //Instanciamos al objeto clsMCargo para llenar sus propiedades
                        clsMCargo _cargo = new clsMCargo();
                        {
                            _cargo.IdCargo = (int)rdr["id_cargo"];
                            _cargo.Codigo = (string)rdr["codigo"];
                            _cargo.Denominacion = (string)rdr["denominacion"];
                            _cargo.Creado = (DateTime)rdr["creado"];
                            _cargo.Actualizado = Convert.ToDateTime(rdr["actualizado"]);
                        };

                        //Insertamos el objeto clsMUsuario dentro de la lista 
                        listaCargos.Add(_cargo);
                    }


                    rdr.Close();
                    cmd.Connection = cnn.cerrarConexion();
                    return listaCargos;
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

        }

        public clsMCargo BuscarPorCodigo(string codigo)
        {
            cmd.Parameters.Clear();

            clsMCargo _cargo = new clsMCargo();
            stringBuilder.Clear();
            string sqlQuery = "SELECT * FROM cargos WHERE codigo = @codigo";

            try
            {
                cmd.Connection = cnn.abrirConexion();
                cmd.CommandText = sqlQuery;

                cmd.Parameters.AddWithValue("@codigo", codigo);
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    rdr.Read();

                    _cargo = llenarCargo();

                    rdr.Close();
                    cmd.Connection = cnn.cerrarConexion();
                    return _cargo;
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
        }

        public clsMCargo BuscarPorId(int id)
        {
            cmd.Parameters.Clear();

            clsMCargo _cargo = new clsMCargo();
            stringBuilder.Clear();
            string sqlQuery = "SELECT * FROM cargos WHERE id_cargo = @id_cargo";

            try
            {
                cmd.Connection = cnn.abrirConexion();
                cmd.CommandText = sqlQuery;

                cmd.Parameters.AddWithValue("@id_cargo", id);
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    rdr.Read();

                    _cargo = llenarCargo();

                    rdr.Close();
                    cmd.Connection = cnn.cerrarConexion();
                    return _cargo;
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
        }

        public clsMCargo llenarCargo()
        {
            clsMCargo _cargo = new clsMCargo();

            _cargo.IdCargo = (int)rdr["id_cargo"];
            _cargo.Codigo = (string)rdr["codigo"];
            _cargo.Denominacion = (string)rdr["denominacion"];
            _cargo.Creado = (DateTime)rdr["creado"];
            _cargo.Actualizado = (DateTime)rdr["actualizado"];

            return _cargo;
        }


    }  
}

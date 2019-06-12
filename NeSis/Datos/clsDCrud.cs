using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using Modelo;

namespace Datos
{
    public class clsDCrud
    {
        public readonly StringBuilder stringBuilder = new StringBuilder();
        private clsDConexion cnn = new clsDConexion();
        private MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rdr;
       
       
        public int ObtenerId(string bd, string tabla)
        {
            int res = 0;
            stringBuilder.Clear();
            string sqlQuery = "SELECT AUTO_INCREMENT FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '" + bd + "' AND TABLE_NAME = '" + tabla + "'";
            cmd.Connection = cnn.abrirConexion();

            cmd.CommandText = sqlQuery;
            try
            {
                if (cmd.ExecuteScalar() != null)
                {
                    res = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (MySqlException e)
            {
                stringBuilder.Append("ERROR " + e.Message + e.StackTrace);
            }
            cmd.Connection = cnn.cerrarConexion();
            return res;
        }

        public Object VerificaCampo(string tabla, string campo, string valor)
        {
            Object res = null;
            stringBuilder.Clear();
            cmd.Connection = cnn.abrirConexion();
            cmd.CommandText = "SELECT " + campo + " FROM " + tabla + " WHERE campo =" + valor;

            try
            {              
                if (cmd.ExecuteScalar() != null)
                {
                    res = cmd.ExecuteScalar();
                }           
            }
            catch (MySqlException e)
            {
                stringBuilder.Append("ERROR " + e.Message + e.StackTrace);
            }

            cmd.Connection = cnn.cerrarConexion();
            return res;
        }
        public bool Insertar(string sqlQuery, string[] camposInsertar, ArrayList valoresInsertar )
        {
            cmd.Parameters.Clear();

            bool res = false;
            try
            {
                stringBuilder.Clear();
                cmd.Connection = cnn.abrirConexion();
                cmd.CommandText = sqlQuery;

                for (int i=0; i<camposInsertar.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@" + camposInsertar[i], valoresInsertar[i]);
                }
                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    res = true;
                }
     
            }
            catch (MySqlException e)
            {
                cmd.Connection = cnn.cerrarConexion();
                stringBuilder.Append("ERROR " + e.Message + e.StackTrace);
            }
            finally
            {
                if (rdr != null) rdr.Close();
                cmd.Connection = cnn.cerrarConexion();
            }

            return res;  
        }

        public bool Editar(string sqlQuery, string[] camposEditar, ArrayList valoresEditar, string nombreId,int valorId)
        {
            cmd.Parameters.Clear();

            bool res = false;
            try
            {
                stringBuilder.Clear();
                cmd.Connection = cnn.abrirConexion();
                cmd.CommandText = sqlQuery;

                cmd.Parameters.AddWithValue("@" + nombreId, valorId);
                for (int i = 0; i < camposEditar.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@" + camposEditar[i], valoresEditar[i]);
                }

                if (cmd.ExecuteNonQuery() > 0)
                {
                    res = true;
                }

            }
            catch (MySqlException e)
            {
                cmd.Connection = cnn.cerrarConexion();
                stringBuilder.Append("ERROR " + e.Message + e.StackTrace);
            }
            finally
            {
                if (rdr != null) rdr.Close();
                cmd.Connection = cnn.cerrarConexion();
            }

            return res;
        }

        public bool Eliminar(string sqlQuery,string nombreId, int valorId)
        {
            cmd.Parameters.Clear();

            bool res = false;
            try
            {
                stringBuilder.Clear();
                cmd.Connection = cnn.abrirConexion();
                cmd.CommandText = sqlQuery;

                cmd.Parameters.AddWithValue("@" + nombreId, valorId);
               
                if (cmd.ExecuteNonQuery() > 0)
                {
                    res = true;
                }

            }
            catch (MySqlException e)
            {
                cmd.Connection = cnn.cerrarConexion();
                stringBuilder.Append("ERROR " + e.Message + e.StackTrace);
            }
            finally
            {
                if (rdr != null) rdr.Close();
                cmd.Connection = cnn.cerrarConexion();
            }

            return res;
        }

       
    }
}

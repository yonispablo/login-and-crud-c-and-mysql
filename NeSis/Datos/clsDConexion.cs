using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections.Specialized;


namespace Datos
{
    public class clsDConexion
    {
        private static string servidor = ConfigurationManager.AppSettings.Get("servidor");
        private static string puerto = ConfigurationManager.AppSettings.Get("puerto");
        private static string usuario = ConfigurationManager.AppSettings.Get("usuario");
        private static string clave = ConfigurationManager.AppSettings.Get("clave");
        private static string basedatos = ConfigurationManager.AppSettings.Get("basedatos");
        private static string cadena = "datasource=" + servidor + ";port=" + puerto + ";username=" + usuario + ";password=" + clave + ";database=" + basedatos + ";";

        private MySqlConnection cnn = new MySqlConnection(cadena);
        public MySqlConnection abrirConexion()
        {
            if (cnn.State != System.Data.ConnectionState.Open) cnn.Open();
            return cnn;
        }
        public MySqlConnection cerrarConexion()
        {
            if (cnn.State != System.Data.ConnectionState.Closed) cnn.Close();
            return cnn;
        }

        public string getCadena()
        {
            return cnn.State.ToString();
        }



    }
}

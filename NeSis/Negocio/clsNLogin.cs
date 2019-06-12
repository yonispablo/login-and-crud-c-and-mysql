using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Datos;

namespace Negocio
{
    public class clsNLogin
    {
        private readonly clsDLogin userDLogin = new clsDLogin();

        public readonly StringBuilder stringBuilder = new StringBuilder();
        public clsMUsuario getUserLogin(string alias, string clave)
        {
            stringBuilder.Clear();

            clsMUsuario res = null;

            if (alias == null || alias.Trim().Length <= 0) stringBuilder.Append("Por favor proporcione un usuario válido");
            if (clave == null || clave.Trim().Length <= 0) stringBuilder.Append(Environment.NewLine + "Por favor proporcione una contraseña válida");

            if (stringBuilder.Length == 0)
            {
                res = userDLogin.getUserLogin(alias, clave);
                stringBuilder.Append(userDLogin.stringBuilder.ToString());
            }
           
            return res;  
        }
    }
}

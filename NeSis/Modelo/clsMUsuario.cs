using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsMUsuario : clsMPersona
    {
        public int IdUsuario { get; set; }
        public string Alias { get; set; }
        public string Clave { get; set; }  
        public string Tipo { get; set; }
        public int Cargo { get; set; }

    }
}

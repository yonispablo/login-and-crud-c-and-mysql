using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Datos;

namespace Negocio
{
    public class clsNCargo
    {
        public readonly StringBuilder stringBuilder = new StringBuilder();

        //Instanciamos nuestra clase clsCrudUsuarios para poder utilizar sus miembros
        private clsDCrudCargos _crudCargos = new clsDCrudCargos();

        private List<clsMCargo> res = null;

        //Método que lista todos los cliente
        public List<clsMCargo> ListarTodos()
        {
            stringBuilder.Clear();
            if (_crudCargos.getAll("todos") != null)
            {
                res = _crudCargos.getAll("todos");
                stringBuilder.Append(_crudCargos.stringBuilder.ToString());
            }

            return res;
        }

        //Método que lista los clientes por una columna determinada
        public List<clsMCargo> ListarPorColumna(string columna, string valor)
        {
            stringBuilder.Clear();
            if (_crudCargos.getAll("criterio", columna, valor) != null)
            {
                res = _crudCargos.getAll("criterio", columna, valor);
                stringBuilder.Append(_crudCargos.stringBuilder.ToString());
            }

            return res;
        }

        // Método que valida los campos obligatorios
        private bool ValidarCargo(clsMCargo _cargo)
        {
            stringBuilder.Clear();
            if (string.IsNullOrEmpty(_cargo.Codigo)) stringBuilder.Append("El campo Código es obligatorio");
            if (string.IsNullOrEmpty(_cargo.Denominacion)) stringBuilder.Append(Environment.NewLine + "El campo Denominacion es obligatorio");
           
            return stringBuilder.Length == 0;
        }

        public clsMCargo BuscarPorIdN(int id)
        {
            clsMCargo res = null;

            stringBuilder.Clear();
            if (_crudCargos.BuscarPorId(id) != null)
            {
                res =_crudCargos.BuscarPorId(id);
                stringBuilder.Append(_crudCargos.stringBuilder.ToString());
            }

            return res;
        }
    }
}

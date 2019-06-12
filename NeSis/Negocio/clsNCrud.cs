using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography;
using System.IO;
using Datos;

namespace Negocio
{
    public class clsNCrud
    {
        private readonly clsDCrud _clsDCrud = new clsDCrud();

        public readonly StringBuilder stringBuilder = new StringBuilder();

       
        public int getSiguienteID(string bd, string tabla)
        {
            stringBuilder.Clear();

            int res = _clsDCrud.ObtenerId(bd, tabla);

            stringBuilder.Append(_clsDCrud.stringBuilder.ToString());

            return res;
        }

        public byte[] ImageToByte(System.Drawing.Image ImageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ImageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ByteArrayToImage(byte[] bytesArr)
        {
            Image res = null;

            if (bytesArr != null)
            {
                MemoryStream ms = new MemoryStream(bytesArr);
                res = Image.FromStream(ms);
            }

            return res;  
        }

        public string SerializarCampos(string[] campos)
        {
            string cadCampos = campos[0];

            if (campos.Length > 1)
            {
                for (int i = 1; i < campos.Length; i++)
                {
                    cadCampos += "," + campos[i];
                }

            }
            return cadCampos;
        }

        public string SerializarParametros(string[] campos)
        {
            string cadParametros = "@" + campos[0];

            if (campos.Length > 1)
            {
                for (int i = 1; i < campos.Length; i++)
                {
                    cadParametros += "," + "@" + campos[i];
                }

            }
            return cadParametros;
        }

        public string SerializarCamposUpdate(string[] campos)
        {
            string cadCamposUpdate = campos[0] + " = " + "@" + campos[0];

            if (campos.Length > 1)
            {
                for (int i = 1; i < campos.Length; i++)
                {
                    cadCamposUpdate += "," + campos[i] + " = " + "@" + campos[i];
                }

            }
            return cadCamposUpdate;
        }

        public string codsHA512Cadena(string clave)
        {
            SHA512 sha512 = new SHA512CryptoServiceProvider();

            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(clave);
            byte[] hash = sha512.ComputeHash(inputBytes);

            return Convert.ToBase64String(hash);
        }

        public bool ComparaClaves(string clave1, string clave2)
        {
            if (clave1.Equals(clave2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

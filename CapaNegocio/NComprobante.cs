using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NComprobante
    {
         

        public static string getComprobante(string tipo)
        {
            DComprobante dComprobante = new DComprobante();

            Comprobante comprobante = dComprobante.getComprobante(tipo);
            return comprobante.NFC;
        }

    }
}

using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEmpresasRNC
    {
        public static void Insert(string nombreEmpresa,string RNC)
        {
            DEmpresasRNC obj = new DEmpresasRNC();
            obj.NombreEmpresa = nombreEmpresa;
            obj.RNC = RNC;
            obj.Insertar(obj);

        }

        public static DataTable Mostrar()
        {
            DEmpresasRNC obj = new DEmpresasRNC();
            return obj.Mostrar();
        }

        public static DataTable BuscarPorRNC(string RNC)
        {
            DEmpresasRNC Obj = new DEmpresasRNC();
            return Obj.BuscarPorRNC(RNC);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NPresentacion
    {
        //Método Insertar que llama al método Insertar de la clase DPresentacion
        //de la CapaDatos
        public static string Insertar(string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DPresentacion
        //de la CapaDatos
        public static string Editar(int idpresentacion, string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Idpresentacion = idpresentacion;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DPresentacion
        //de la CapaDatos
        public static string Eliminar(int idpresentacion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Idpresentacion = idpresentacion;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DPresentacion
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DPresentacion().Mostrar();
        }

        //Método BuscarNombre que llama al método BuscarNombre
        //de la clase DPresentacion de la CapaDatos

        public static DataTable BuscarNombre(string textobuscar)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}

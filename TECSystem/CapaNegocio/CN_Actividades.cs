using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
   public class CN_Actividades
    {
        CD_Actividades obj = new CD_Actividades();

        public DataTable mostrarActividades()
        {
            DataTable tabla = new DataTable();
            tabla = obj.mostrar();
            return tabla;
        }
        public void agregar_actividad(string nombre, string descripcion, string grupo, int tema, int ponderacion, DateTime fecha)
        {
            obj.insertar(nombre, descripcion, grupo, tema, ponderacion, fecha);
        }
        public void editar_actividad(int id,string nombre, string descripcion, string grupo, int tema, int ponderacion, DateTime fecha)
        {
            obj.editar(id, nombre,descripcion,grupo,tema,ponderacion,fecha);
        }
        public void eliminar_actividad(int id)
        {
            obj.eliminar(id);
        }
    }
}

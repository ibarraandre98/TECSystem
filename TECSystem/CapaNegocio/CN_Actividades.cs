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
        CD_Actividades _CD_Actividades = new CD_Actividades();

        public DataTable MostrarActividades()
        {
            DataTable tabla = new DataTable();
            tabla = _CD_Actividades.MostrarActividades();
            return tabla;
        }
        public void AgregarActividad(String nombre, String descripcion, String grupo, String tema, String ponderacion, DateTime fecha)
        {
            _CD_Actividades.InsertarActividades(nombre, descripcion, grupo, Convert.ToInt32(tema), Convert.ToInt32(ponderacion), fecha);
        }
        public void EditarActividad(String id,String nombre, String descripcion, String grupo, String tema, String ponderacion, DateTime fecha)
        {
            _CD_Actividades.EditarActividades(Convert.ToInt32(id), nombre,descripcion,grupo,Convert.ToInt32(tema),Convert.ToInt32(ponderacion),fecha);
        }
        public void EliminarActividad(String id)
        {
            _CD_Actividades.EliminarActividades(Convert.ToInt32(id));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Calificaciones
    {
        CD_Calificaciones _CD_Calificaciones = new CD_Calificaciones();

        public DataTable MostrarCalificaciones()
        {
            DataTable tabla = new DataTable();
            tabla = _CD_Calificaciones.MostrarCalificaciones();
            return tabla;
        }
        public void AgregarCalificacion(String grupo, String matricula, String tema, String califiacion, String tipoEval)
        {
            _CD_Calificaciones.InsertarCalificaciones(grupo,matricula,Convert.ToInt32(tema),Convert.ToDouble(califiacion),tipoEval);
        }
        public void EditarCalificacion(String id,String grupo, String matricula, String tema, String califiacion, String tipoEval)
        {
            _CD_Calificaciones.EditarTarea(Convert.ToInt32(id), grupo,matricula,Convert.ToInt32(tema),Convert.ToDouble(califiacion),tipoEval);
        }
        public void EliminarCalificacion(String id)
        {
            _CD_Calificaciones.EliminarTarea(Convert.ToInt32(id));
        }
    }
}

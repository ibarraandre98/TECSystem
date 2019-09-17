using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_detActividades
    {
        private CD_detActividades objetoCD = new CD_detActividades();

        DataTable tabla = new DataTable();

        public DataTable MostrarTabla()
        {
            return tabla = objetoCD.MostrarTabla();
        }

        public void AgregarACtividad(string actividad, string matricula, string calificacion, string fechaEntrega)
        {
            objetoCD.AgregarActividad(actividad, matricula, calificacion, fechaEntrega);
        }
        public void EditarActividad(string idDetAct, string actividad, string matricula, string calificacion, string fechaEntrega)
        {
            objetoCD.EditarActividad(idDetAct, actividad, matricula, calificacion, fechaEntrega);
        }
        public void EliminarActividad(string idDetAct)
        {
            objetoCD.EliminarActividad(idDetAct);
        }
    }
}

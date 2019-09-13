using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    class CN_detActividades
    {
        private CD_detActividades objetoCD = new CD_detActividades();

        public void AgregarACtividad(int actividad, string matricula, string calificacion, string fechaEntrega)
        {
            objetoCD.AgregarActividad(actividad, matricula, calificacion, fechaEntrega);
        }
        public void EditarActividad(int idDetAct, int actividad, string matricula, string calificacion, string fechaEntrega)
        {
            objetoCD.EditarActividad(idDetAct, actividad, matricula, calificacion, fechaEntrega);
        }
        public void EliminarActividad(int idDetAct)
        {
            objetoCD.EliminarActividad(idDetAct);
        }
    }
}

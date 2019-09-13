using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    class CN_Carreras
    {

        private CD_Carreras objetoCD = new CD_Carreras();

        public void AgregarCarrera(string nombre, int coordinador)
        {
            objetoCD.AgregarCarrera(nombre, coordinador);
        }
        public void EditarCarrera(int idCarrera, string nombre, int coordinador)
        {
            objetoCD.EditarCarrera(idCarrera, nombre, coordinador);
        }
        public void EliminarCarrera(int idCarrera)
        {
            objetoCD.ElimnarCarrera(idCarrera);
        }
    }
}

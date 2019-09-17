using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Carreras
    {

        private CD_Carreras objetoCD = new CD_Carreras();

        DataTable tabla = new DataTable();

        public DataTable MostrarTabla()
        {
            return tabla = objetoCD.MostrarTabla();
        }

        public void AgregarCarrera(string nombre, string coordinador)
        {
            objetoCD.AgregarCarrera(nombre, coordinador);
        }
        public void EditarCarrera(string idCarrera, string nombre, string coordinador)
        {
            objetoCD.EditarCarrera(idCarrera, nombre, coordinador);
        }
        public void EliminarCarrera(string idCarrera)
        {
            objetoCD.ElimnarCarrera(idCarrera);
        }
    }
}

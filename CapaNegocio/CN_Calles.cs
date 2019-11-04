using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Calles
    {
        private CD_Calles objetoCD = new CD_Calles();
        DataTable tabla = new DataTable();

        public DataTable MostrarTabla()
        {
            return tabla = objetoCD.MostrarTabla();
        }

        public void AgregarCalles(string localidad, string nombre)
        {
            objetoCD.AgregarCalles(localidad, nombre);
        }
        public void EditarCalles(string idCalle, string Localidad, string nombre)
        {
            objetoCD.EditarCalles(idCalle, Localidad, nombre);
        }
        public void EliminarCalles(string idCalle)
        {
            objetoCD.EliminarCalles(idCalle);
        }

    }
}

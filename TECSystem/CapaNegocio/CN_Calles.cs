using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    class CN_Calles
    {
        private CD_Calles objetoCD = new CD_Calles();

        public void AgregarCalles(int localidad, string nombre)
        {
            objetoCD.AgregarCalles(localidad, nombre);
        }
        public void EditarCalles(int idCalle, int Localidad, int nombre)
        {
            objetoCD.EditarCalles(idCalle, Localidad, nombre);
        }
        public void EliminarCalles(int idCalle)
        {
            objetoCD.EliminarCalles(idCalle);
        }

    }
}

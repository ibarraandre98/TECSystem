using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Localidades
    {
        private CDLocalidades objetoCD = new CDLocalidades();
        public void AgregarLocalidad(int municipio, string nombre, int tipo)
        {
            objetoCD.AgregarLocalidad(municipio,nombre,tipo);
        }
        public void EditarMunicipio(int municipio, int id)
        {
            objetoCD.EditarMunicipio(municipio,id);
        }
        public void EditarNombre(string nombre, int id)
        {
            objetoCD.EditarNombre(nombre,id);
        }
        public void EditarTipo(int tipo, int id)
        {
            objetoCD.EditarTipo(tipo,id);
        }
        public void Eliminar(int id)
        {
            objetoCD.Eliminar(id);
        }

    }
}

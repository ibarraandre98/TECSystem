using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Localidades
    {
        private CDLocalidades objetoCD = new CDLocalidades();
        DataTable tablaLocalidad = new DataTable();
        public DataTable MostrarLocalidades()
        {
            return tablaLocalidad = objetoCD.MostrarLocalidades();
        }
        public void AgregarLocalidad(int municipio, string nombre, int tipo)
        {
            objetoCD.AgregarLocalidad(municipio,nombre,tipo);
        }
        public void EditarMunicipio(int municipio,string nombre, int id,int tipo)
        {
            objetoCD.EditarMunicipio(municipio,id,nombre,tipo);
        }
        public void Eliminar(int id)
        {
            objetoCD.Eliminar(id);
        }

    }
}

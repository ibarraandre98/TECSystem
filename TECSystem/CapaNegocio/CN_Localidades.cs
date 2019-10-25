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
        private CDLocalidades _CD_Localidades = new CDLocalidades();
        DataTable tablaLocalidad = new DataTable();
        DataTable tablaLocalidadesMunicipio = new DataTable();
        public DataTable MostrarLocalidades()
        {
            return tablaLocalidad = _CD_Localidades.MostrarLocalidades();
        }
        public void AgregarLocalidad(int municipio, string nombre, int tipo)
        {
            _CD_Localidades.AgregarLocalidad(municipio,nombre,tipo);
        }
        public void EditarMunicipio(int municipio,string nombre, int id,int tipo)
        {
            _CD_Localidades.EditarMunicipio(municipio,id,nombre,tipo);
        }
        public void Eliminar(int id)
        {
            _CD_Localidades.Eliminar(id);
        }

        public DataTable MostrarLocalidadesMunicipio(String idMunicipio)
        {
            return tablaLocalidadesMunicipio = _CD_Localidades.MostrarLocalidadesMunicipio(Convert.ToInt32(idMunicipio));
        }

    }
}

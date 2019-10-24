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
    public class CN_Municipio
    {
        private CD_Municipio objetoCD = new CD_Municipio();
        DataTable tablaMunicipio = new DataTable();
        DataTable tablaMunicipioEstado = new DataTable();
        public DataTable MostrarMunicipios()
        {
            return tablaMunicipio = objetoCD.MostrarMunicipio();
        }
        public void AgregarMunicipio(int numero, int estado, string nombre)
        {
            objetoCD.AgregarMunicipio(numero, estado, nombre);
        }
        public void EditarMunicipio(string nombre, int id,int numero,int estado)
        {
            objetoCD.EditarMunicipio(nombre, id,numero,estado);
        }
        public void eliminarMunicipio(int id)
        {
            objetoCD.Eliminar(id);
        }
        public DataTable MostrarMunicipiosEstado(String idEstado)
        {
            return tablaMunicipioEstado = objetoCD.MostrarMunicipioEstado(Convert.ToInt32(idEstado));
        }

    }
}

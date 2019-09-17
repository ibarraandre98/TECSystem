using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Municipio
    {
        private CD_Municipio objetoCD = new CD_Municipio();
        public void AgregarMunicipio(int numero, int estado, String nombre)
        {
            objetoCD.AgregarMunicipio(numero, estado, nombre);
        }
        public void EditarNombre(string nombre, int id)
        {
            objetoCD.EditarNombre(nombre, id);
        }
        public void EditarEstado(int estado, int id)
        {
            objetoCD.EditarEstado(estado, id);
        }
        public void EditarNumero(int estado, int id)
        {
            objetoCD.EditarEstado(estado, id);
        }
        public void eliminarMunicipio(int id)
        {
            objetoCD.Eliminar(id);
        }

    }
}

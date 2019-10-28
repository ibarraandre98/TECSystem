using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
    public class CN_Materia
    {
        private CDMateria objetoCD = new CDMateria();
        DataTable tablaMaterias = new DataTable();
        public DataTable MostrarMaterias()
        {
            return tablaMaterias = objetoCD.MostrarMaterias();
        }
        public void AgregarMateria(String cve, string nombre, int hteoricas, int hpracticas, int creditos, int carrera)
        {
            objetoCD.AgregarMateria(cve,nombre,hteoricas,hpracticas,creditos,carrera);
        }
        public void EditarMateria(int cve, string nombre, int hteoricas, int hpracticas, int creditos, int carrera)
        {
            objetoCD.EditarMateria(cve, nombre, hteoricas, hpracticas, creditos, carrera);
        }
        public void EliminarMateria(int id)
        {
            objetoCD.Eliminar(id);
        }

    }
}

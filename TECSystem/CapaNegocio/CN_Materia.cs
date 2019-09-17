using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Materia
    {
        private CDMateria objetoCD = new CDMateria();
        public void AgregarMateria(int cve, string nombre, int hteoricas, int hpracticas, int creditos, int carrera)
        {
            objetoCD.AgregarMateria(cve,nombre,hteoricas,hpracticas,creditos,carrera);
        }
        public void EliminarMateria(int id)
        {
            objetoCD.Eliminar(id);
        }

    }
}

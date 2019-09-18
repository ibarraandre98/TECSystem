using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class CN_especialidades
    {
        CD_especialidades _CD_especialidades = new CD_especialidades();
        DataTable tablaespecialidades = new DataTable();

        public DataTable Mostrarespecialidades()
        {
            return tablaespecialidades = _CD_especialidades.Mostrarespecialidades();
        }

        public void Agregarespecialidades(string idEspecialidad, String nombre, String carrera)
        {
            _CD_especialidades.Agregarespecialidades(Convert.ToInt32(idEspecialidad), nombre, carrera);
        }

        public void Editarespecialidades(string idEspecialidad, String nombre, String carrera)
        {
            _CD_especialidades.Editarespecialidades(Convert.ToInt32(idEspecialidad), nombre, carrera);
        }

        public void Eliminarespecialidades(int idEspecialidad)
        {
            _CD_especialidades.Eliminarespecialidades(Convert.ToInt32(idEspecialidad));
        }
    }
}
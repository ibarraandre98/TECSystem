using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Profesores
    {
        CD_Profesores _CD_Profesores = new CD_Profesores();
        DataTable TablaProfesores = new DataTable();
        public DataTable MostrarProfesores()
        {
            return TablaProfesores = _CD_Profesores.MostrarProfesores();
        }

        public void AgregarProfesores(String idProfesor, String idEmpleado, String idAcademia, String tipoMemb)
        {
            _CD_Profesores.AgregarProfesores(idProfesor,Convert.ToInt32(idEmpleado), Convert.ToInt32(idAcademia), Convert.ToInt32(tipoMemb));
        }

        public void EditarProfesores(String idProfesor, String idEmpleado, String idAcademia, String tipoMemb, String nuevoidProfesor)
        {
            _CD_Profesores.EditarProfesores(idProfesor, Convert.ToInt32(idEmpleado), Convert.ToInt32(idAcademia), Convert.ToInt32(tipoMemb), nuevoidProfesor);
        }

        public void EliminarProfesores(String idProfesor)
        {
            _CD_Profesores.EliminarProfesores(idProfesor);
        }


    }
}

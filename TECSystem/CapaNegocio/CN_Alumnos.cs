using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Alumnos
    {
        CD_Alumnos _CD_Alumnos = new CD_Alumnos();

        public DataTable MostrarAlumnos()
        {
            DataTable tabla = new DataTable();
            tabla = _CD_Alumnos.MostrarAlumnos();
            return tabla;
        }
        
        public void AgregarAlumno(string matricula, int idPersona, int idCarrera, string tutor, int idEspecialidad, int estatus)
        public void AgregarAlumno(String matricula, String idPersona, String idCarrera, String tutor, String idEspecialidad, String estatus)
        {
            _CD_Alumnos.InsertarAlumnos(matricula,Convert.ToInt32(idPersona),Convert.ToInt32(idCarrera),tutor,Convert.ToInt32(idEspecialidad),Convert.ToInt32(estatus));
        }
        public void EditarAlumno(string matricula, int idPersona, int idCarrera, string tutor, int idEspecialidad, int estatus)
        public void EditarAlumno(String matricula, String idPersona, String idCarrera, String tutor, String idEspecialidad, String estatus)
        {
            obj.editar(matricula, idPersona, idCarrera, tutor, idEspecialidad, estatus);
        }
        public void EditarAlumno(string matricula)
            _CD_Alumnos.EditarAlumnos(matricula, Convert.ToInt32(idPersona), Convert.ToInt32(idCarrera), tutor, Convert.ToInt32(idEspecialidad), Convert.ToInt32(estatus));        }
        public void EliminarAlumno(String matricula)
        {
            _CD_Alumnos.EliminarAlumnos(matricula);
        }
    }
}

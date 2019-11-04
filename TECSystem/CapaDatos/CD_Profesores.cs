using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Profesores
    {
        CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable TablaProfesores = new DataTable();

        public DataTable MostrarProfesores()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = " select profesores.idProfesor, profesores.idEmpleado, empleados.idPersona, personas.nombres, " +
                "personas.paterno, personas.materno, profesores.idAcademia, academias.nombre, profesores.tipoMemb from profesores " +
                "join empleados on profesores.idEmpleado = empleados.idEmpleado " +
                "join personas on empleados.idPersona = personas.idPersona " +
                "join academias on profesores.idAcademia = academias.idAcademia";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            TablaProfesores.Load(leer);
            conexion.CerrarConexion();
            return TablaProfesores;
        }
        public void Eliminar_Profesor( int idempleado)
        {
            comando.Connection = conexion.AbrirConexion();
           
            comando.CommandText = "execute eliminarprofesor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@idEmpleado",idempleado);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void AgregarProfesores(String idProfesor, int idEmpleado, int idAcademia, int tipoMemb)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into profesores (idProfesor,idEmpleado,idAcademia,tipoMemb) values('"+idProfesor+"',"+idEmpleado+","+idAcademia+","+tipoMemb+");";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void EditarProfesores(String idProfesor, int idEmpleado, int idAcademia, int tipoMemb,String nuevoidProfesor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update profesores set idProfesor = '"+nuevoidProfesor+"',idEmpleado = "+idEmpleado+", idAcademia = "+idAcademia+", tipoMemb = "+tipoMemb+" where idProfesor = '"+idProfesor+"';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void EliminarProfesores(String idProfesor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from profesores where idProfesor = '"+idProfesor+"';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
    }
}

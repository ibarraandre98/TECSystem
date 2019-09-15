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
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable TablaProfesores = new DataTable();

        public DataTable MostrarProfesores()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Profesores";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            TablaProfesores.Load(leer);
            conexion.CerrarConexion();
            return TablaProfesores;
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

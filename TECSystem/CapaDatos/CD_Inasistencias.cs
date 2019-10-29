using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Inasistencias
    {
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tablaInasistencias = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarInasistencias()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Inasistencias";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaInasistencias.Load(leer);
            conexion.CerrarConexion();
            return tablaInasistencias;
        }

        public void AgregarInasistencias( string grupo, string matricula, DateTime fecha , int tipoInasistencia)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into inasistencias " +
                "(grupo, matricula, fecha, tipoinasistencia) " +
                "values " +
                "('"+grupo+"', '"+matricula+ "', convert(datetime,'" + fecha.ToString("MM-dd-yyyy") + "',101), '"+tipoInasistencia+"');";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EditarInasistencias(int idInasistencia,  string grupo, string matricula, DateTime fecha, int tipoInasistencia)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update inasistencias set grupo = '" + grupo + "',matricula='" + matricula+ "fecha='" + fecha + "',tipoInasistencia='" + tipoInasistencia+ "' where idInasistencia = '" + idInasistencia+ "';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EliminarInasistencia(int idInasistencia)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from inasistencias where idInasistencia = '" + idInasistencia + "';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}

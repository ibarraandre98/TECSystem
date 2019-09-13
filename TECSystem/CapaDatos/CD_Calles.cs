using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Calles
    {
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void AgregarCalles(int localidad, string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("insert into calles(Localidad,nombre) values(@localidad,@nombre);");
            comando.Parameters.AddWithValue("@localidad", localidad);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

        public void EditarCalles(int idCalle, int Localidad, int nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("update calles set Localidad=@Localidad, nombre=@nombre where idCalle=@idCalle");
            comando.Parameters.AddWithValue("@idCalle", idCalle);
            comando.Parameters.AddWithValue("@Localidad", Localidad);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

        public void EliminarCalles(int idCalle)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("DELETE FROM calles WHERE idCalle=@idCalle");
            comando.Parameters.AddWithValue("@idCalle", idCalle);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

    }
}

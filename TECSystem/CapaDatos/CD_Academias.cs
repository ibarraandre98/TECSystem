using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Academias{
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable mos= new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarAcademias()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from academias";
            leer = comando.ExecuteReader();
            mos.Load(leer);
            conexion.CerrarConexion();
            return mos;
        }
        public void InsertarAcademia(string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into academias values (@nombre)";
            comando.Parameters.AddWithValue("@nombre", nombre);
            leer = comando.ExecuteReader();
            conexion.CerrarConexion();          
        }
        public void EliminarAcademia(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from academias where idAcademia = @idAcademia";
            comando.Parameters.AddWithValue("@idAcademia", id);
            leer = comando.ExecuteReader();
            conexion.CerrarConexion();
        }
        public void EditarAcademia(int id,string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = " update academias set nombre = @nombre where idAcademia = @idAcademia";
            comando.Parameters.AddWithValue("@idAcademia", id);
            comando.Parameters.AddWithValue("@nombre",nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}

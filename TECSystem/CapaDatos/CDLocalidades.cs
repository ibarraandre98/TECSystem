using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaDatos
{
    public class CDLocalidades
    {
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public void AgregarLocalidad(int municipio, string nombre, int tipo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("insert into localidades(Municipio,nombre,tipo) values(@municipio,@nombre,@tipo);");
            comando.Parameters.AddWithValue("@Municipio", municipio);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        public void EditarMunicipio(int municipio,int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("update localidades set Municipio=@municipio where idLocalidad=@idLocalidad");
            comando.Parameters.AddWithValue("@municipio",municipio);
            comando.Parameters.AddWithValue("@idLocalidad", id);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        public void EditarNombre(string nombre, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("update localidades set nombre=@nombre where idLocalidad=@idLocalidad");
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@idLocalidad", id);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        public void EditarTipo(int tipo,int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("update localidades set tipo=@tipo where idLocalidad=@idLocalidad");
            comando.Parameters.AddWithValue("@tipo", "3");
            comando.Parameters.AddWithValue("@idLocalidad", "2");
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("DELETE FROM localidad WHERE idLocalidad=@idLocalidad");
            comando.Parameters.AddWithValue("@idLocalidad", "2");
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

    }
}
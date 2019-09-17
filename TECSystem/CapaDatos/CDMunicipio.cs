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
    public class CD_Municipio
    {
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public void AgregarMunicipio(int numero, int estado, String nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("insert into municipios(numero, Estado, nombre) values(@numero, @estado, @nombre)");
            comando.Parameters.AddWithValue("@numero", numero);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        public void EditarNumeroMunicipio(int numero,int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("update municipios set numero=@numero where idMunicipio=@idMunicipio");
            comando.Parameters.AddWithValue("@numero",numero);
            comando.Parameters.AddWithValue("@idMunicipio", id);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        public void EditarEstado(int estado, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("update municipios set Estado=@estado where idMunicipio=@idMunicipio");
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@idMunicipio", id);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        public void EditarNombre(string nombre,int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("update municipios set nombre=@nombre where idMunicipio=@idMunicipio");
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@idMunicipio", id);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("DELETE FROM municipios WHERE idMunicipio=@idMunicipio");
            comando.Parameters.AddWithValue("@idMunicipio", id);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

    }
}
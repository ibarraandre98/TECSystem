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
        CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable tablaMunicipioEstado = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable MostrarMunicipio()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select municipios.idMunicipio, municipios.numero as NumeroMunicipio," +
                "estados.idEstado, estados.nombre as Estado,municipios.nombre as Municipio from municipios " +
                "join estados on municipios.Estado = estados.idEstado ";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void AgregarMunicipio(int numero, int estado, String nombre)
        {
            /*comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("insert into municipios(numero, Estado, nombre) values(@numero, @estado, @nombre)");
            comando.Parameters.AddWithValue("@numero", numero);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();*/
            //
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into municipios (numero,Estado,nombre) values("+numero+","+estado+",'"+nombre+"');";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
        public void EditarMunicipio(string nombre,int id,int numero,int estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update municipios set nombre = '" + nombre + "', numero = " + numero + ", estado = " + estado + " where idMunicipio = " + id + ";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from municipios where idMunicipio = " + id + ";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable MostrarMunicipioEstado(int idEstado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select idMunicipio,nombre from municipios where Estado = "+idEstado+";";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaMunicipioEstado.Load(leer);
            conexion.CerrarConexion();
            return tablaMunicipioEstado;
        }

    }
}
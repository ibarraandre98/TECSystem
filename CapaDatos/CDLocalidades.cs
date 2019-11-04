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
    public class CD_Localidades
    {
        CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable tablaLocalidadesMunicipio = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable MostrarLocalidades()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select localidades.idLocalidad,municipios.idMunicipio as idMunicipio,municipios.nombre as Municipio, " +
                "estados.idEstado as idEstado,estados.nombre as Estado,localidades.nombre as Nombre_Localidad," +
                "tiposLocalidad.idTipoLoc as idTipoLocalidad, tiposLocalidad.tipo as Tipo_Localidad from localidades " +
                "join municipios on localidades.Municipio = municipios.idMunicipio " +
                "join estados on municipios.Estado = estados.idEstado " +
                "join tiposLocalidad on localidades.tipo = tiposLocalidad.idTipoLoc";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void AgregarLocalidad(int municipio, string nombre, int tipo)
        {
            /*comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("insert into localidades(Municipio,nombre,tipo) values(@municipio,@nombre,@tipo);");
            comando.Parameters.AddWithValue("@Municipio", municipio);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();*/
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Localidades values(" + municipio + ",'" + nombre + "'," + tipo + ");";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
        public void EditarMunicipio(string municipio,int id,string nombre,int tipo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update localidades set nombre = '" + nombre + "', Municipio = '" + municipio + "', tipo = " + tipo + " where idLocalidad = " + id + ";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from localidades where idLocalidad = " + id + ";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable MostrarLocalidadesMunicipio(int idMunicipio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select localidades.idLocalidad, localidades.nombre, " +
                "localidades.Municipio, localidades.tipo from localidades " +
                "where Municipio = " + idMunicipio + ";";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaLocalidadesMunicipio.Load(leer);
            conexion.CerrarConexion();
            return tablaLocalidadesMunicipio;
        }

    }
}
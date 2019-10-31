using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Especialidades
    {
        CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tablaespecialidades = new DataTable();
        DataTable tablaEspecialidadesCarrera = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrarespecialidades()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from especialidades";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaespecialidades.Load(leer);
            conexion.CerrarConexion();
            return tablaespecialidades;
        }

        public void Agregarespecialidades( String nombre, String carrera)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into especialidades" +
                "( nombre,carrera) " +
                "values('" + nombre + "','" + carrera + "');";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void Editarespecialidades(int idEspecialidad, String nombre, String carrera)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update especialidades set nombre = '" + nombre + "',carrera='" + carrera + " where idEspecialidad = " + idEspecialidad + "; ";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void Eliminarespecialidades(int idEspecialidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from especialidades where idEspecialidad = " + idEspecialidad + ";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public DataTable MostrarEspecialidadesCarrera(int carrera)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = " select * from especialidades where carrera = "+carrera+"";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaEspecialidadesCarrera.Load(leer);
            conexion.CerrarConexion();
            return tablaEspecialidadesCarrera;
        }
    }
}

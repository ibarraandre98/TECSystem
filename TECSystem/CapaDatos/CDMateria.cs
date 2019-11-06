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
    public class CD_Materia
    {
        CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
            public DataTable MostrarMaterias()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = " select materias.cveMateria, materias.nombre, materias.hTeoricas, materias.hPracticas, materias.creditos, " +
                "materias.carrera, carreras.nombre as Nombre_Carrera " +
                "from materias " +
                "join carreras on materias.carrera = carreras.idCarrera";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void AgregarMateria(String cve, string nombre, int hteoricas, int hpracticas, int creditos, int carrera)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into materias values('" + cve + "','" + nombre + "'," + hteoricas + "," + hpracticas + "," + creditos + "," + carrera + ");";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
            public void EditarMateria(string cve, string nombre, int hteoricas, int hpracticas, int creditos, int carrera)
            {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Materias set nombre = '"+nombre+ "', hTeoricas = '"+hteoricas+ "', hPracticas = '"+hpracticas+ "',creditos = '"+creditos+ "', carrera = "+carrera+ " where cveMateria = '"+cve+"';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
            }

            public void Eliminar(string id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from materias where cveMateria = '" + id + "';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

    }
}
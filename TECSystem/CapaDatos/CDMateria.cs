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
    public class CDMateria
    {
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public void AgregarMateria(int cve, string nombre, int hteoricas, int hpracticas, int creditos, int carrera)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("insert into materias(cveMateria,nombre,hTeoricas,hPracticas,creditos,carrera) " +
                "values(@cveMateria,@nombre,@hTeoricas,@hPracticas,@creditos,@carrera)");
            comando.Parameters.AddWithValue("@cveMateria", cve);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@hTeoricas", hteoricas);
            comando.Parameters.AddWithValue("@hPracticas", hpracticas);
            comando.Parameters.AddWithValue("@creditos",creditos);
            comando.Parameters.AddWithValue("@carrera", carrera);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("DELETE FROM materias WHERE cveMateria=@cveMateria");
            comando.Parameters.AddWithValue("@cveMateria", id);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Profesores
    {
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable TablaProfesores = new DataTable();

        public DataTable MostrarProfesores()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Profesores";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            TablaProfesores.Load(leer);
            conexion.CerrarConexion();
            return TablaProfesores;
        }

        public void InsertarProfesores()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        //private SqlConnection Conexion = new SqlConnection("Data Source =.;Initial Catalog=BaseDeDatosTec;Integrated Security=true");
        //private SqlConnection Conexion = new SqlConnection("Data Source =.;Initial Catalog=basetec;Integrated Security=true");
        //private SqlConnection Conexion = new SqlConnection("Server=LAPTOP-KF9P88JK\\SQLEXPRESS;DataBase=BDTEC;Integrated Security=true");
        private SqlConnection Conexion = new SqlConnection("Server=MIGUEL-GONZALEZ\\SQLEXPRESS;DataBase=BaseDeDatosTec;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class CD_Personas
    {
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable TablaPersonas = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable MostrarPersonas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from personas";

            return TablaPersonas;
        }

    }
}

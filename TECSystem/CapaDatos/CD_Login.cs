using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Login
    {
        CD_Conexion _CD_Conexion = new CD_Conexion();
        SqlDataReader sdrLeer;
        DataTable dtLogin = new DataTable();
        SqlCommand sCommand = new SqlCommand();

        public SqlDataReader leerLogin()
        {
            sCommand.Connection = _CD_Conexion.AbrirConexion();
            sCommand.CommandText = "select * from usuarios_Login";
            sCommand.CommandType = CommandType.Text;
            sdrLeer = sCommand.ExecuteReader();
            return sdrLeer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Empleos
    {
        CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tablaempleos = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrarempleos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from empleos";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaempleos.Load(leer);
            conexion.CerrarConexion();
            return tablaempleos;
        }

        public void Agregarempleos( String puesto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into empleos" +
                "(puesto) " +
                "values('" + puesto + "');";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void Editarempleos(int idEmpleo, String puesto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update empleos set puesto = '" + puesto + "'  where idEmpleo = "+idEmpleo+" ;";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void Eliminarempleos(int idEmpleo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from empleos where idEmpleo = '" + idEmpleo + "';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
    }
}

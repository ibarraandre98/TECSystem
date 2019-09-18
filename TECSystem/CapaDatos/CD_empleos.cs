using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_empleos
    {
        CDConexion conexion = new CDConexion();
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

        public void Agregarempleos(int idEmpleo, String puesto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into empleos" +
                "(idEmpleo, puesto) " +
                "values(" + idEmpleo + ", '" + puesto + "');";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void Editarempleos(int idEmpleo, String puesto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update empleos set idEmpleo = " + idEmpleo + ", puesto = '" + puesto + "';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void Eliminarempleos(int idEmpleo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from empleos where idEmpleado = '" + idEmpleo + "';";
        }
    }
}

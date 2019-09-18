using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_empleados
    {
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tablaempleados = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrarempleados()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from empleados";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaempleados.Load(leer);
            conexion.CerrarConexion();
            return tablaempleados;
        }

        public void Agregarempleados(int idPersona, int idEmpleo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into empleados" +
                "(idPersona, idEmpleo) " +
                "values(" +idPersona + "," + idEmpleo + ");";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void Editarempleados( int idPersona, int idEmpleo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update empleados set idPersona = " + idPersona + ", idEmpleo = " + idEmpleo + ";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void Eliminarempleados(int idEmpleado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from empleados where idEmpleado = " + idEmpleado + ";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
    }
}

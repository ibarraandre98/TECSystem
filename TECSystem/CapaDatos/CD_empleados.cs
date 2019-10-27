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
            comando.CommandText = "select empleados.idEmpleado,empleados.idPersona," +
                "personas.nombres as Nombre, personas.materno as Materno, " +
                "personas.paterno as Paterno, personas.curp as Curp, empleos.idEmpleo," +
                "empleos.puesto as Puesto " +
                "from empleados " +
                "join personas on empleados.idPersona = personas.idPersona " +
                "join empleos on empleados.idEmpleo = empleos.idEmpleo";
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

        public int ultimoID()
        {
            int id;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = " select top 1 idEmpleado from empleados order by idEmpleado desc";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            leer.Read();
            id = Convert.ToInt32(leer["idEmpleado"].ToString());
            conexion.CerrarConexion();
            return id;
        }
    }
}

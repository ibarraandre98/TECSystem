using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Carreras
    {
        CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarCarreras()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select carreras.idCarrera, carreras.nombre, carreras.coordinador, empleados.idPersona, " +
                "personas.nombres, personas.paterno, personas.materno from carreras " +
                "join empleados on carreras.coordinador = empleados.idEmpleado " +
                "join personas on empleados.idPersona = personas.idPersona";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void AgregarCarrera(string nombre, string coordinador)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into carreras(nombre,coordinador) values(@nombre,@coordinador);";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@coordinador", coordinador);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarCarrera(string idCarrera, string nombre, string coordinador)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update carreras set nombre = @nombre, coordinador = @coordinador where idCarrera = @idCarrera";
            comando.Parameters.AddWithValue("@idCarrera", idCarrera);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@coordinador", coordinador);
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ElimnarCarrera(string idCarrera)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete carreras where idCarrera = @idCarrera";
            comando.Parameters.AddWithValue("@idCarrera", idCarrera);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

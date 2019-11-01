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
        DataTable tablaUsuarios = new DataTable();

        public SqlDataReader leerLogin(String usuario, String pass)
        {
            sCommand.Connection = _CD_Conexion.AbrirConexion();
            sCommand.CommandText = "select * from usuarios_Login where usuario = '"+usuario+"' and pass = '"+pass+"'";
            sCommand.CommandType = CommandType.Text;
            sdrLeer = sCommand.ExecuteReader();
            return sdrLeer;
        }

        public void AgregarUsuario(String usuario, String nombre, String apellidos, String email, String pass)
        {
            sCommand.Connection = _CD_Conexion.AbrirConexion();
            sCommand.CommandText = "insert into usuarios_Login (" +
                "usuario," +
                "nombre," +
                "apellidos," +
                "email," +
                "pass" +
                ")" +
                "values('"+ usuario + "','"+ nombre + "','"+apellidos+"','"+ email + "','"+pass+"');";
            sCommand.CommandType = CommandType.Text;
            sCommand.ExecuteNonQuery();
        }

        public void EditarUsuario(String usuario, String nombre, String apellidos, String email, String pass)
        {
            sCommand.Connection = _CD_Conexion.AbrirConexion();
            sCommand.CommandText = "update usuarios_login set nombre = '"+nombre+"', apellidos = '"+apellidos+"'," +
                "email = '"+email+"', pass = '"+pass+"' where usuario = '"+usuario+"'";
            sCommand.CommandType = CommandType.Text;
            sCommand.ExecuteNonQuery();
        }

        public void EliminarUsuario(String usuario)
        {
            sCommand.Connection = _CD_Conexion.AbrirConexion();
            sCommand.CommandText = "delete from usuarios_login where usuario = '" + usuario + "';";
            sCommand.CommandType = CommandType.Text;
            sCommand.ExecuteNonQuery();
        }

        public DataTable MostrarUsuarios()
        {
            sCommand.Connection = _CD_Conexion.AbrirConexion();
            sCommand.CommandText = "select * from usuarios_Login";
            sCommand.CommandType = CommandType.Text;
            sdrLeer = sCommand.ExecuteReader();
            tablaUsuarios.Load(sdrLeer);
            _CD_Conexion.CerrarConexion();
            return tablaUsuarios;
        }
    }
}

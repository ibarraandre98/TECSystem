using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Login
    {
        private CD_Login _CD_Login = new CD_Login();
        SqlDataReader sdr;
        DataTable tablaUsuarios = new DataTable();

        public SqlDataReader leerLogin(String usuario, String pass)
        {
            return _CD_Login.leerLogin(usuario,pass);
        }

        public void AgregarUsuario(String usuario, String nombre, String apellidos, String email, String pass)
        {
            _CD_Login.AgregarUsuario(usuario,nombre,apellidos,email,pass);
        }

        public void EditarUsuario(String usuario, String nombre, String apellidos, String email, String pass)
        {
            _CD_Login.EditarUsuario(usuario, nombre, apellidos, email, pass);
        }

        public void EliminarUsuario(String usuario)
        {
            _CD_Login.EliminarUsuario(usuario);
        }

        public DataTable MostrarUsuarios()
        {
            return _CD_Login.MostrarUsuarios();
        }
    }
}

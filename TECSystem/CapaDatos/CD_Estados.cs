using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Estados
    {
        CD_Conexion conexion = new CD_Conexion();
        DataTable tablaEstados = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable MostrarEstados()
        {
            comando = new SqlCommand();
            SqlDataReader leer;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from estados";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaEstados.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tablaEstados;
        }

        public void AgregarEstados(String nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into personas" +
                "(nombre) " +
                "values('" + nombre +"');";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void EditarEstados(int idEstado,string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update estados set nombre = '"+nombre+"' where idPersona = '" + idEstado + "';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void EliminarEstado(int idEstado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from estados where idEstado = '" + idEstado + "';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public SqlDataReader MostrarEstadosComboBox()
        {
            SqlDataReader leer;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from estados";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            return leer;
        }
    }
}

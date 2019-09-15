using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_tiposLocalidad
    {
        DataTable TablaTiposLocalidad = new DataTable();
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarTiposLocalidad()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from tiposlocadidad";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            TablaTiposLocalidad.Load(leer);
            conexion.CerrarConexion();
            return TablaTiposLocalidad;
        }

        public void AgregarTiposLocalidad(String tipo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into tiposlocalidad (tipo) values('"+tipo+"';)";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void EditarTiposLocalidad(int idTipoLoc, String tipo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update tiposlocalidad set tipo = '"+tipo+"' where idTipoLoc = "+idTipoLoc+";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void EliminarTiposLocalidad(int idTipoLoc)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from tiposlocalidad where idTipoLoc = " + idTipoLoc + ";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
    }
}

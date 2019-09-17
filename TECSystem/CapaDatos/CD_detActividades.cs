using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_detActividades
    {
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarTabla()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from detActividades";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void AgregarActividad(string actividad, string matricula, string calificacion, string fechaEntrega )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("insert into detActividades(actividad,matricula,calificacion,fechaEntrega) values(@actividad,@matricula,@calificacion,@fechaEntrega);");
            comando.Parameters.AddWithValue("@actividad", actividad);
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.Parameters.AddWithValue("@calificacion", calificacion);
            comando.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

        public void EditarActividad(string idDetAct, string actividad, string matricula, string calificacion, string fechaEntrega)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("update detActividades set actividad=@actividad, matricula=@matricula, calificacion=@calificacion,fechaEntrega=@fechaEntrega where idDetAct=@idDetAct");
            comando.Parameters.AddWithValue("@idDetAct", idDetAct);
            comando.Parameters.AddWithValue("@actividad", actividad);
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.Parameters.AddWithValue("@calificacion", calificacion);
            comando.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

        public void EliminarActividad(string idDetAct)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("DELETE FROM detActividades WHERE idDetAct=@idDetAct");
            comando.Parameters.AddWithValue("@idDetAct", idDetAct);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
    }
}

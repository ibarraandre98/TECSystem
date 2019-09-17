using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Calificaciones
    {
        CDConexion conexion = new CDConexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;

        public void insertar(char grupo,char matricula,int tema,float califiacion,char tipoEval)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into calificaciones values(@grupo,@matricula,@tema,@calificacion,@tipoEval)";
            comando.Parameters.AddWithValue("@grupo", grupo);
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.Parameters.AddWithValue("@tema", tema);
            comando.Parameters.AddWithValue("@calificacion", califiacion);
            comando.Parameters.AddWithValue("@tipoEval", tipoEval);
            leer = comando.ExecuteReader();

            conexion.CerrarConexion();
        }
        public void eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from calificaciones where idCalifiacion = @idCalifiacion";
            comando.Parameters.AddWithValue("@idCalifiacion", id);
            leer = comando.ExecuteReader();
            conexion.CerrarConexion();
        }
        public void editar(int idCalificacion,char grupo, char matricula, int tema, float califiacion, char tipoEval)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update calificaciones set(@grupo,@matricula,@tema,@calificacion,@tipoEval) where idCalifiacion=@idCalifiacion";
            comando.Parameters.AddWithValue("@grupo", grupo);
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.Parameters.AddWithValue("@tema", tema);
            comando.Parameters.AddWithValue("@calificacion", califiacion);
            comando.Parameters.AddWithValue("@tipoEval", tipoEval);
            comando.Parameters.AddWithValue("@idCalifiacion", idCalificacion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}

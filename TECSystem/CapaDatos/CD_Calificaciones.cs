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
        DataTable mos = new DataTable();

        public DataTable mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from calificaciones";
            leer = comando.ExecuteReader();
            mos.Load(leer);
            conexion.CerrarConexion();
            return mos;
        }
        public void insertar(string grupo,string matricula,int tema,double califiacion,string tipoEval)
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
        public void editar(int idCalificacion,string grupo, string matricula, int tema, double califiacion, string tipoEval)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update calificaciones set grupo=@grupo,matricula=@matricula,tema=@tema,calificacion=@calificacion,tipoEval=@tipoEval where idCalifiacion=@idCalifiacion";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   
    public class CD_Alumnos
    {
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable mos = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from alumnos";
            leer = comando.ExecuteReader();
            mos.Load(leer);
            conexion.CerrarConexion();
            return mos;
        }
        public void insertar(string matricula,int idPersona,int idCarrera,string tutor,int idEspecialidad,int estatus)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into alumnos values(@matricula,@idPersona,@idCarrera,@tutor,@idEspecialidad,@estatus)";
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.Parameters.AddWithValue("@idPersona", idPersona);
            comando.Parameters.AddWithValue("@idCarrera", idCarrera);
            comando.Parameters.AddWithValue("@tutor", tutor);
            comando.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);
            comando.Parameters.AddWithValue("@estatus", estatus);
            leer = comando.ExecuteReader();
            conexion.CerrarConexion();
        }
        public void eliminar(string matricula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from alumnos where matricula = @matricula";
            comando.Parameters.AddWithValue("@matricula", matricula);
            leer = comando.ExecuteReader();
            conexion.CerrarConexion();
        }
        public void editar(string matricula, int idPersona, int idCarrera, string tutor, int idEspecialidad, int estatus)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update alumnos set idPersona=@idPersona,idCarrera=@idCarrera,tutor=@tutor,idEspecialidad=@idEspecialidad,estatus=@estatus where matricula=@matricula";
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.Parameters.AddWithValue("@idPersona", idPersona);
            comando.Parameters.AddWithValue("@idCarrera", idCarrera);
            comando.Parameters.AddWithValue("@tutor", tutor);
            comando.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);
            comando.Parameters.AddWithValue("@estatus", estatus);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

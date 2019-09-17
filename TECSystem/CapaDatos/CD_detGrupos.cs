using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_detGrupos
    {
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarTabla()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from detGrupos";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void AgregarGrupo(string cveGrupo, string matricula, string tipoCurso)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("insert into detGrupos(cveGrupo,matricula,tipoCurso) values(@cveGrupo,@matricula,@tipoCurso);");
            comando.Parameters.AddWithValue("@cveGrupo", cveGrupo);
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.Parameters.AddWithValue("@tipoCurso", tipoCurso);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

        public void EditarGrupo(string idDetGpo, string cveGrupo, string matricula, string tipoCurso)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("update detGrupos set cveGrupo=@actividad, matricula=@matricula, tipoCurso=@tipoCurso where idDetGpo=@idDetGpo");
            comando.Parameters.AddWithValue("@idDetGpo", idDetGpo);
            comando.Parameters.AddWithValue("@cveGrupo", cveGrupo);
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.Parameters.AddWithValue("@tipoCursoa", tipoCurso);

            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

        public void EliminarActividad(string idDetGpo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("DELETE FROM detGrupos WHERE idDetGpo=@idDetGpo");
            comando.Parameters.AddWithValue("@idDetGpo", idDetGpo);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
    }
}

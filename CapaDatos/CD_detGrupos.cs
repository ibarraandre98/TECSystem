using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_DetGrupos
    {
        CD_Conexion conexion = new CD_Conexion();
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
            comando.CommandText = "insert into detGrupos(cveGrupo,matricula,tipoCurso) values(@cveGrupo,@matricula,@tipoCurso);";
            comando.Parameters.AddWithValue("@cveGrupo", cveGrupo);
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.Parameters.AddWithValue("@tipoCurso", tipoCurso);
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarGrupo(string idDetGpo, string cveGrupo, string matricula, string tipoCurso)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update detGrupos set cveGrupo=@cveGrupo, matricula=@matricula, tipoCurso=@tipoCurso where idDetGpo=@idDetGpo";
            comando.Parameters.AddWithValue("@idDetGpo", idDetGpo);
            comando.Parameters.AddWithValue("@cveGrupo", cveGrupo);
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.Parameters.AddWithValue("@tipoCurso", tipoCurso);
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarActividad(string idDetGpo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM detGrupos WHERE idDetGpo=@idDetGpo";
            comando.Parameters.AddWithValue("@idDetGpo", idDetGpo);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

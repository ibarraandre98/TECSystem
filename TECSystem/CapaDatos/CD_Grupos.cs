using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Grupos
    {
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tablaGrupos = new DataTable();

        public DataTable mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from grupos";
            leer = comando.ExecuteReader();
            tablaGrupos.Load(leer);
            conexion.CerrarConexion();
            return tablaGrupos;
        }

        public void insertar(string cveGrupo,string materia,string profesor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into grupos values(@cveGrupo,@materia,@profesor)";
            comando.Parameters.AddWithValue("@cveGrupo", cveGrupo);
            comando.Parameters.AddWithValue("@materia", materia);
            comando.Parameters.AddWithValue("@profesor", profesor);
            leer = comando.ExecuteReader();
            conexion.CerrarConexion();
        }
        public void eliminar(string cveGrupo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from grupos where cveGrupo = @cveGrupo";
            comando.Parameters.AddWithValue("@cveGrupo", cveGrupo);
            leer = comando.ExecuteReader();
            conexion.CerrarConexion();
        }
        public void editar(string cveGrupo,string materia,string profesor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update grupos set (@materia,@profesor) where cveGrupo=@cveGrupo";
            comando.Parameters.AddWithValue("@materia", materia);
            comando.Parameters.AddWithValue("@profesor", profesor);
            comando.Parameters.AddWithValue("@cveGrupo", cveGrupo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

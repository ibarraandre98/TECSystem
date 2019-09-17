using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Horarios
    {
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tablaHorarios = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarHorarios()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from horarios";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaHorarios.Load(leer);
            conexion.CerrarConexion();
            return tablaHorarios;
        }

        public void AgregarHorarios(string nombre,string grupo,int dia,int hora,string aula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into horarios" +
                "(nombre,grupo,dia,hora,aula) " +
                "values('" + nombre + "','" + grupo + "','" + dia + "','" + hora + "','" + aula + "');";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void EditarHorarios(int idHorario, string nombre,string grupo,int dia,int hora,string aula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update horarios set nombre = '" + nombre + "',grupo='"+grupo+"hora='"+hora+"',aula='"+aula+"' where idHorario = '" + idHorario + "';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void EliminarHorario(int idHorarios)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from horarios where idHorarios = '" + idHorarios + "';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
    }
}

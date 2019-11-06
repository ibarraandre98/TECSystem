using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Estados

    {

        CD_Estados obj = new CD_Estados();

        public DataTable mostrarEstados()
        {
            DataTable tabla = new DataTable();
            tabla = obj.MostrarEstados();
            return tabla;
        }

        public void agregar_estado(string nombre)
        {
            obj.AgregarEstados(nombre);
        }
        public void editar_alumno(int idEstado,string nombre)
        {
            obj.EditarEstados(idEstado,nombre);
        }
        public void eliminar_alumno(int idEstado)
        {
            obj.EliminarEstado(idEstado);
        }
        public SqlDataReader MostrarEstadosCombobox()
        {
            SqlDataReader leer;
            leer = obj.MostrarEstadosComboBox();
            return leer;
        }
    }
}

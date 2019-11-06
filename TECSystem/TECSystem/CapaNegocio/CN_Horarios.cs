using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Horarios
    {
        CD_Horarios obj = new CD_Horarios();

        public DataTable mostrarHorarios()
        {
            DataTable tabla = new DataTable();
            tabla = obj.MostrarHorarios();
            return tabla;
        }

        public void agregar_horarios(string grupo, int dia, int hora, string aula)
        {
            obj.AgregarHorarios(grupo, dia, hora, aula);
        }
        public void editar_horarios(int idHorario,  string grupo, int dia, int hora, string aula)
        {
            obj.EditarHorarios(idHorario, grupo, dia, hora, aula);
        }
        public void eliminar_horarios(int idHorario)
        {
            obj.EliminarHorario(idHorario);
        }
    }
}

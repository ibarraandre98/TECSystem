using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Calificaciones
    {
        CD_Calificaciones obj = new CD_Calificaciones();

        public DataTable mostrarCalificaciones()
        {
            DataTable tabla = new DataTable();
            tabla = obj.mostrar();
            return tabla;
        }
        public void agregar_calificacion(string grupo, string matricula, int tema, double califiacion, string tipoEval)
        {
            obj.insertar(grupo,matricula,tema,califiacion,tipoEval);
        }
        public void editar_calificacion(int id,string grupo, string matricula, int tema, double califiacion, string tipoEval)
        {
            obj.editar(id, grupo,matricula,tema,califiacion,tipoEval);
        }
        public void eliminar_calificacion(int id)
        {
            obj.eliminar(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Inasistencias
    {
        CD_Inasistencias obj = new CD_Inasistencias();
        
        public DataTable mostrarInasistencias()
        {
            DataTable tabla = new DataTable();
            tabla = obj.MostrarInasistencias();
            return tabla;
        }

        public void agregar_inasistencias(string grupo, string matricula, string fecha,int tipoInasistencia)
        {
            obj.AgregarInasistencias(grupo,matricula,fecha,tipoInasistencia);
        }
        public void editar_inasistencias(int idInasistencia, string grupo, string matricula, string fecha, int tipoInasistencia)
        {
            obj.EditarInasistencias(idInasistencia,grupo,matricula,fecha,tipoInasistencia);
        }
        public void eliminar_inasistencias(int idInasistencia)
        {
            obj.EliminarInasistencia(idInasistencia);
        }
    }
}

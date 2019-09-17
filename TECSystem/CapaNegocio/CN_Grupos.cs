using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Grupos
    {
        CD_Grupos obj = new CD_Grupos();

        public DataTable mostrarGrupos()
        {
            DataTable tabla = new DataTable();
            tabla = obj.mostrar();
            return tabla;}

        public void agregar_grupo(char materia,string profesor)
        {
            obj.insertar(materia,profesor);
        }
        public void editar_grupo(char materia,string profesor,char cveGrupo)
        {
            obj.editar(cveGrupo,materia,profesor);
        }
        public void eliminar_grupo(char cveGrupo)
        {
            obj.eliminar(cveGrupo);
        }
    }
}

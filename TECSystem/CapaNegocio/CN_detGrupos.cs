using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_detGrupos
    {
        private CD_DetGrupos objetoCD = new CD_DetGrupos();

        DataTable tabla = new DataTable();

        public DataTable MostrarTabla()
        {
            return tabla = objetoCD.MostrarTabla();
        }
        public void AgregarGrupo(string cveGrupo, string matricula, string tipoCurso)
        {
            objetoCD.AgregarGrupo(cveGrupo, matricula, tipoCurso);
        }
        public void EditarGrupo(string idDetGpo, string cveGrupo, string matricula, string tipoCurso)
        {
            objetoCD.EditarGrupo(idDetGpo, cveGrupo, matricula, tipoCurso);
        }
        public void EliminarGrupo(string idDetGpo)
        {
            objetoCD.EliminarActividad(idDetGpo);
        }
    }
}

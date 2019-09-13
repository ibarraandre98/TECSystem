using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    class CN_detGrupos
    {
        private CD_detGrupos objetoCD = new CD_detGrupos();

        public void AgregarGrupo(string cveGrupo, string matricula, string tipoCurso)
        {
            objetoCD.AgregarGrupo(cveGrupo, matricula, tipoCurso);
        }
        public void EditarGrupo(int idDetGpo, string cveGrupo, string matricula, string tipoCurso)
        {
            objetoCD.EditarGrupo(idDetGpo, cveGrupo, matricula, tipoCurso);
        }
        public void EliminarGrupo(int idDetGpo)
        {
            objetoCD.EliminarActividad(idDetGpo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class CN_TiposLocalidad
    {
        CD_TiposLocalidad _CD_TiposLocalidad = new CD_TiposLocalidad();
        DataTable TablaTiposLocalidad = new DataTable();

        public DataTable MostrarTiposLocalidad()
        {
            return TablaTiposLocalidad = _CD_TiposLocalidad.MostrarTiposLocalidad();
        }

        public void AgregarTiposLocalidad(String tipo)
        {
            _CD_TiposLocalidad.AgregarTiposLocalidad(tipo);
        }

        public void EditarTiposLocalidad(String idTipoLoc,String tipo)
        {
            _CD_TiposLocalidad.EditarTiposLocalidad(Convert.ToInt32(idTipoLoc), tipo);
        }

        public void EliminarTiposLocalidad(String idTipoLoc)
        {
            _CD_TiposLocalidad.EliminarTiposLocalidad(Convert.ToInt32(idTipoLoc));
        }


    }
}

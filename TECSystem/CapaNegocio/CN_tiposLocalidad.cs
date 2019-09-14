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
    class CN_tiposLocalidad
    {
        CD_tiposLocalidad _CD_TiposLocalidad = new CD_tiposLocalidad();
        DataTable TablaTiposLocalidad = new DataTable();

        public DataTable MostrarTiposLocalidad()
        {
            return TablaTiposLocalidad = _CD_TiposLocalidad.MostrarTiposLocalidad();
        }
    }
}

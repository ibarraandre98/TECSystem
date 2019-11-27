using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Conexion
    {
        public String obtenerConexion()
        {
            CD_Conexion _CD_Conexion = new CD_Conexion();
            return _CD_Conexion.obtenerCadenaConexion();
        }
    }
}

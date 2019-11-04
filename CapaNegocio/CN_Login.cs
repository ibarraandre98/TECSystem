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
    class CN_Login
    {
        CD_Login _CD_Login = new CD_Login();
        SqlDataReader sdrLeer;

        public SqlDataReader leerLogin()
        {
            return _CD_Login.leerLogin();
        }
    }
}

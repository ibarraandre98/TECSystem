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
    public class CN_Academia
    {
        CD_Academias obj = new CD_Academias();

        public DataTable mostrarAcademias()
        {
            DataTable tabla = new DataTable();
            tabla = obj.mostrar();
            return tabla;
        }
        public void agregar_academia(String nombre)
        {
            obj.insertar(nombre);
        }
    }
    
}

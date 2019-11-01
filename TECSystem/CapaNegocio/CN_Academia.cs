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
        CD_Academias _CD_Academias = new CD_Academias();

        public DataTable MostrarAcademias()
        {
            DataTable tabla = new DataTable();
            tabla = _CD_Academias.MostrarAcademias();
            return tabla;
        }
        public void AgregarAcademia(String nombre)
        {
            _CD_Academias.InsertarAcademia(nombre);
        }
        public void EditarAcademia(String id,String nombre)
        {
            _CD_Academias.EditarAcademia(Convert.ToInt32(id),nombre);
        }
        public void EliminarAcademia(String id)
        {
            _CD_Academias.EliminarAcademia(Convert.ToInt32(id));
        }
    }
    
}

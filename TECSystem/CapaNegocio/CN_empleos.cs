using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class CN_empleos
    {
        CD_Empleos _CD_empleos = new CD_Empleos();
        DataTable tablaempleos = new DataTable();

        public DataTable Mostrarempleos()
        {
            return tablaempleos = _CD_empleos.Mostrarempleos();
        }

        public void Agregarempleos(String puesto)
        {
            _CD_empleos.Agregarempleos( puesto);
        }

        public void Editarempleos(String idEmpleo, String puesto)
        {
            _CD_empleos.Editarempleos(Convert.ToInt32(idEmpleo), puesto);
        }

        public void Eliminarempleos(String idEmpleado)
        {
            _CD_empleos.Eliminarempleos(Convert.ToInt32(idEmpleado));
        }
    }
}

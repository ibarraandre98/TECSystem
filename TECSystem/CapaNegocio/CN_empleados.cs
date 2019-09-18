using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    class CN_empleados
    {
        CD_empleados _CD_empleados = new CD_empleados();
        DataTable tablaempleados = new DataTable();

        public DataTable MostrarPersonas()
        {
            return tablaempleados = _CD_empleados.Mostrarempleados();
        }

        public void Agregarempleados(int idEmpleado, int idPersona, int idEmpleo)
        {

            _CD_empleados.Agregarempleados(Convert.ToInt32(idEmpleado), Convert.ToInt32(idPersona), Convert.ToInt32(idEmpleo));
        }

        public void Editarempleados(int idEmpleado, int idPersona, int idEmpleo)
        {
            _CD_empleados.Editarempleados(Convert.ToInt32(idEmpleado), Convert.ToInt32(idPersona), Convert.ToInt32(idEmpleo));
        }

        public void Eliminarempleados(int idEmpleado)
        {
            _CD_empleados.Eliminarempleados(Convert.ToInt32(idEmpleado));
        }
    }
}

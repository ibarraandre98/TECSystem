using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    class CN_empleos
    {
        CD_empleos _CD_empleos = new CD_empleos();
    DataTable tablaempleos = new DataTable();

    public DataTable Mostrarempleados()
    {
        return tablaempleos = _CD_empleos.Mostrarempleos();
    }

    public void Agregarempleados(String idEmpleo, String puesto)
    {
            _CD_empleos.Agregarempleos(Convert.ToInt32(idEmpleo),puesto);
    }

    public void Editarempleados(String idEmpleo, String puesto)
    {
            _CD_empleos.Editarempleos(Convert.ToInt32(idEmpleo),puesto);
    }

    public void Eliminarempleados(String idEmpleado)
    {
            _CD_empleos.Eliminarempleos(Convert.ToInt32(idEmpleado));
    }
}
}

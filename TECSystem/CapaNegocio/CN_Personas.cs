using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocio
{
    class CN_Personas
    {
        CD_Personas _CD_Personas = new CD_Personas();
        DataTable tablaPersonas = new DataTable();

        public DataTable MostrarPersonas()
        {
            return tablaPersonas = _CD_Personas.MostrarPersonas();
        }

        public void AgregarPersonas(String paterno, String materno, String nombres, String fecha_nac, String sexo, String curp, String telefono, String idCalle, String numExt, String numInt, String cp, String edoCivil, String discapacidad)
        {
            _CD_Personas.AgregarPersonas(paterno, materno, nombres,fecha_nac,Convert.ToInt32(sexo),curp,telefono,Convert.ToInt32(idCalle), numExt, numInt, cp, Convert.ToInt32(edoCivil), Convert.ToInt32(discapacidad));
        }

        public void EditarPersonas(String idPersona, String paterno, String materno, String nombres, String fecha_nac, String sexo, String curp, String telefono, String idCalle, String numExt, String numInt, String cp, String edoCivil, String discapacidad)
        {
            _CD_Personas.EditarPersonas(Convert.ToInt32(idPersona),paterno, materno, nombres, fecha_nac, Convert.ToInt32(sexo), curp, telefono, Convert.ToInt32(idCalle), numExt, numInt, cp, Convert.ToInt32(edoCivil), Convert.ToInt32(discapacidad));
        }

        public void EliminarPersona(String idPersona)
        {
            _CD_Personas.EliminarPersona(Convert.ToInt32(idPersona));
        }
    }
}

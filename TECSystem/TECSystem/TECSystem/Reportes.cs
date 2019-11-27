using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECSystem
{
    public partial class Reportes : Form
    {
        private SqlConnection Conexion = new SqlConnection("Data Source =.;Initial Catalog=BaseDeDatosTec;Integrated Security=true");
        int reporte = 1;
        string matricula = "";

        public void setReporte(int reporte)
        {
            this.reporte = reporte;
        }
        public int getReporte()
        {
            return this.reporte;
        }
        public void setMatricula(string matricula)
        {
            this.matricula = matricula;
        }
        public string getMatricula()
        {
            return this.matricula;
        }

        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            callReport();
        }
        private void callReport()
        {
            string sqlEmployees;

            switch (reporte)
            {
                case 1:
                    {
                        sqlEmployees = "select especialidades.idEspecialidad, especialidades.nombre, especialidades.carrera, carreras.nombre, carreras.coordinador, empleados.idPersona, personas.nombres, personas.paterno, personas.materno, personas.telefono, personas.fecha_nac from especialidades join carreras on especialidades.carrera = carreras.idCarrera join empleados on carreras.coordinador = empleados.idEmpleado join personas on empleados.idPersona = personas.idPersona";
                        fillReport(1, sqlEmployees, "DataTable1");
                        break;
                    }
                case 2:
                    {
                        sqlEmployees = "select alumnos.matricula, alumnos.idPersona, personas.nombres as Nombre, personas.paterno as Paterno, "+
                           "personas.materno as Materno, personas.fecha_nac as Fecha_Nacimiento, personas.sexo, personas.curp,"+
                           "personas.telefono, personas.numExt, personas.numInt, personas.cp, personas.edoCivil, personas.discapacidad,"+
                           "personas.calle, personas.localidades, localidades.nombre, localidades.Municipio, municipios.numero,"+
                           "municipios.nombre, municipios.Estado, estados.nombre, localidades.tipo, tiposLocalidad.tipo,"+
                           "alumnos.idCarrera, carreras.nombre, alumnos.tutor, alumnos.idEspecialidad, especialidades.nombre,"+
                           "especialidades.carrera, carreras.nombre, alumnos.estatus "+
                           "from alumnos "+
                           "join personas on alumnos.idPersona = personas.idPersona "+
                           "join localidades on personas.localidades = localidades.idLocalidad "+
                           "join municipios on localidades.Municipio = municipios.idMunicipio "+
                           "join estados on municipios.Estado = estados.idEstado "+
                           "join carreras on alumnos.idCarrera = carreras.idCarrera "+
                           "join tiposLocalidad on localidades.tipo = tiposLocalidad.idTipoLoc "+
                           "join especialidades on alumnos.idEspecialidad = especialidades.idEspecialidad "+
                           "where alumnos.matricula = '1601F0040'";
                        fillReport(2, sqlEmployees, "DtAlumnos");
                        break;
                    }
                case 3:
                    {
                        sqlEmployees = "select calificaciones.grupo, grupos.materia, grupos.profesor, "+
                        "calificaciones.matricula, alumnos.idCarrera, carreras.nombre, alumnos.idEspecialidad, especialidades.nombre, alumnos.idPersona, "+
                        "personas.nombres, personas.paterno, personas.materno, calificaciones.tema, calificaciones.calificacion, "+
                        "calificaciones.tipoEval, inasistencias.tipoInasistencia, inasistencias.grupo, inasistencias.fecha "+
                        "from calificaciones "+
                        "join grupos on calificaciones.grupo = grupos.cveGrupo "+
                        "join alumnos on calificaciones.matricula = alumnos.matricula "+
                        "join personas on alumnos.idPersona = personas.idPersona "+
                        "join carreras on alumnos.idCarrera = carreras.idCarrera "+
                        "join especialidades on alumnos.idEspecialidad = especialidades.idEspecialidad "+
                        "join inasistencias on grupos.cveGrupo = inasistencias.grupo "+
                        $"where calificaciones.matricula = '{matricula}'; ";
                        fillReport(3, sqlEmployees, "dtCalificaciones");
                        break;
                    }
                case 4:
                    {
                        sqlEmployees = "select profesores.idProfesor, profesores.idEmpleado,empleados.idPersona,personas.nombres as Nombre, personas.paterno as Paterno, "+
                       "personas.materno as Materno, personas.fecha_nac as Fecha_Nacimiento, personas.sexo, personas.curp, "+
                       "personas.telefono, personas.numExt, personas.numInt, personas.cp, personas.edoCivil, personas.discapacidad, "+
                       "personas.calle, personas.localidades, localidades.nombre, localidades.Municipio, municipios.numero, "+
                        "municipios.nombre, municipios.Estado, estados.nombre, localidades.tipo, tiposLocalidad.tipo "+
                       "from profesores "+
                       "join empleados on profesores.idEmpleado = empleados.idEmpleado "+
                       "join personas on empleados.idPersona = personas.idPersona "+
                       "join localidades on personas.localidades = localidades.idLocalidad "+
                       "join municipios on localidades.Municipio = municipios.idMunicipio "+
                       "join estados on municipios.Estado = estados.idEstado "+
                       "join tiposLocalidad on localidades.tipo = tiposLocalidad.idTipoLoc "+
                       $"where profesores.idProfesor = '{matricula}'";
                        fillReport(4, sqlEmployees, "dtProfesores");
                        break;
                    }
                case 5:
                    {
                        sqlEmployees = "select horarios.idHorario, horarios.grupo, grupos.materia, grupos.profesor, profesores.idEmpleado, empleados.idPersona, " +
                        "personas.nombres, personas.paterno, personas.materno, horarios.dia, horarios.hora, horarios.aula, materias.nombre, " +
                        "materias.creditos, materias.hPracticas, materias.hTeoricas, materias.carrera, carreras.nombre " +
                        " from horarios" +
                        " join grupos on horarios.grupo = grupos.cveGrupo" +
                        " join profesores on grupos.profesor = profesores.idProfesor" +
                        " join empleados on profesores.idEmpleado = empleados.idEmpleado" +
                        " join personas on empleados.idPersona = personas.idPersona" +
                        " join materias on materias.cveMateria = grupos.materia" +
                        " join carreras on materias.carrera = carreras.idCarrera;";
                        fillReport(5, sqlEmployees, "dtHorarios");
                        break;
                    }
                case 6:
                    {
                        sqlEmployees = "select horarios.idHorario, horarios.grupo, grupos.materia, grupos.profesor, profesores.idEmpleado, empleados.idPersona,"+
                        "personas.nombres, personas.paterno, personas.materno, horarios.dia, horarios.hora, horarios.aula, materias.nombre,"+
                        "materias.creditos, materias.hPracticas, materias.hTeoricas, materias.carrera, carreras.nombre"+
                        " from horarios"+
                        " join grupos on horarios.grupo = grupos.cveGrupo"+
                        " join profesores on grupos.profesor = profesores.idProfesor"+
                        " join empleados on profesores.idEmpleado = empleados.idEmpleado"+
                        " join personas on empleados.idPersona = personas.idPersona"+
                        " join materias on materias.cveMateria = grupos.materia"+
                        " join carreras on materias.carrera = carreras.idCarrera"+
                        $" where profesores.idProfesor = '{matricula}'";
                        fillReport(6, sqlEmployees, "dtHorariosEspecificos");
                        break;
                    }
                case 7:
                    {
                        sqlEmployees = "select horarios.idHorario, horarios.grupo, grupos.materia, grupos.profesor, profesores.idEmpleado, empleados.idPersona, " +
                        "personas.nombres, personas.paterno, personas.materno, horarios.dia, horarios.hora, horarios.aula, materias.nombre, " +
                        "materias.creditos, materias.hPracticas, materias.hTeoricas, materias.carrera, carreras.nombre " +
                        " from horarios" +
                        " join grupos on horarios.grupo = grupos.cveGrupo" +
                        " join profesores on grupos.profesor = profesores.idProfesor" +
                        " join empleados on profesores.idEmpleado = empleados.idEmpleado" +
                        " join personas on empleados.idPersona = personas.idPersona" +
                        " join materias on materias.cveMateria = grupos.materia" +
                        " join carreras on materias.carrera = carreras.idCarrera " +
                        $"where grupos.cveGrupo = '{matricula}'";
                        fillReport(7, sqlEmployees, "dtGrupos");
                        break;
                    }
                 case 8:
                    {
                        sqlEmployees = "select horarios.idHorario, horarios.grupo, grupos.materia, grupos.profesor, profesores.idEmpleado, empleados.idPersona,"+
                        "personas.nombres, personas.paterno, personas.materno, horarios.dia, horarios.hora, horarios.aula, materias.nombre,"+
                        "materias.creditos, materias.hPracticas, materias.hTeoricas, materias.carrera, carreras.nombre"+
                        " from horarios"+
                        " join grupos on horarios.grupo = grupos.cveGrupo"+
                        " join profesores on grupos.profesor = profesores.idProfesor"+
                        " join empleados on profesores.idEmpleado = empleados.idEmpleado"+
                        " join personas on empleados.idPersona = personas.idPersona"+
                        " join materias on materias.cveMateria = grupos.materia"+
                        " join carreras on materias.carrera = carreras.idCarrera"+
                        $" where materias.cveMateria = '{matricula}'";
                        fillReport(8, sqlEmployees, "dtHorarioMaterias");
                        break;
                    }
            }
        }
        private void fillReport(int caso,string sqlEmployees, string nombreData)
        {
            var da = new SqlDataAdapter();
            var ds = new DataSet();
            var Reporte = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            switch (caso)
            {
                case 1:
                    {
                        ds = new dsMaterias();
                        Reporte = new MateriasReporte();
                        break;
                    }            
                case 2:
                    {
                        ds = new dsAlumnos();
                        Reporte = new AlumnosReporte();
                        break;
                    }
                case 3:
                    {
                        ds = new dsCalificaciones();
                        Reporte = new CalificacionesReporte();
                        break;
                    }
                case 4:
                    {
                        ds = new dsProfesores();
                        Reporte = new ProfesoresReporte();
                        break;
                    }
                case 5:
                    {
                        ds = new dsHorarios();
                        Reporte = new HorariosReporte();
                        break;
                    }
                case 6:
                    {
                        ds = new dsHorariosEspecificos();
                        Reporte = new HorariosEspecificosReporte();
                        break;
                    }
                case 7:
                    {
                        ds = new dsGrupos();
                        Reporte = new GruposReportes();
                        break;
                    }
                case 8:
                    {
                        ds = new dsHorarioMaterias();
                        Reporte = new MateriasReportes();
                        break;
                    }
            }
            var cmd = new SqlCommand("", Conexion);

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlEmployees;
    
            da.SelectCommand = cmd;
            da.Fill(ds.Tables[$"{nombreData}"]);

            Reporte.SetDataSource(ds);
            this.crystalReportViewer1.ReportSource = Reporte;
            this.crystalReportViewer1.Show();
        }
    }
}

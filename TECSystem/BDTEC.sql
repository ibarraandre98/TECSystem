CREATE DATABASE BDTEC
USE BDTEC
CREATE TABLE estados (
	idEstado TINYINT IDENTITY(1, 1) PRIMARY KEY,
	nombre VARCHAR(32) NOT NULL 
);

CREATE TABLE municipios (
	idMunicipio SMALLINT IDENTITY(1, 1) PRIMARY KEY,
	numero TINYINT NOT NULL,
	Estado TINYINT NOT NULL,
	nombre VARCHAR(40)
	CONSTRAINT fk_estado FOREIGN KEY (Estado) REFERENCES estados(idEstado) 
);

CREATE TABLE tiposLocalidad (
	idTipoLoc TINYINT IDENTITY(1, 1) PRIMARY KEY,
	tipo VARCHAR(30)
);

CREATE TABLE localidades (
	idLocalidad INT IDENTITY(1, 1) PRIMARY KEY,
	Municipio SMALLINT NOT NULL,
	nombre VARCHAR(40),
	tipo TINYINT NOT NULL
	CONSTRAINT fk_municipio FOREIGN KEY(Municipio) REFERENCES municipios (idMunicipio),
	CONSTRAINT fk_tipoLoc_localidaes FOREIGN KEY (tipo) REFERENCES tiposLocalidad (idTipoLoc)
); 

CREATE TABLE calles (
	idCalle INT IDENTITY(1, 1) PRIMARY KEY,
	Localidad INT NOT NULL,
	nombre VARCHAR(50) NOT NULL
	CONSTRAINT fk_localidad FOREIGN KEY(Localidad) REFERENCES localidades(idLocalidad)
);

CREATE TABLE personas (
	idPersona INT IDENTITY(1, 1) PRIMARY KEY,                                                                                 
	paterno VARCHAR(40) NOT NULL,
	materno VARCHAR(40),
	nombres VARCHAR(40) NOT NULL,
	fecha_nac DATETIME NOT NULL,
	sexo BIT NOT NULL,
	curp CHAR(18) NOT NULL, 
	telefono CHAR(10),
	/*idEstado TINYINT NOT NULL,
	idMunicipio SMALLINT NOT NULL,
	idLocalidad INT NOT NULL,*/
	idCalle INT NOT NULL,
	numExt VARCHAR(5) NOT NULL,
	numInt VARCHAR(5),
	cp CHAR(5),
	edoCivil TINYINT NOT NULL,
	discapacidad TINYINT NOT NULL
	/*CONSTRAINT fk_estado FOREIGN KEY (idEstado) REFERENCES estados (idEstado),
	CONSTRAINT fk_municipio FOREIGN KEY (idMunicipio) REFERENCES municipios (idMunicipio),
	CONSTRAINT fk_localidad FOREIGN KEY (idLocalidad) REFERENCES localidades (idLocalidad),*/
	CONSTRAINT fk_calle FOREIGN KEY (idCalle) REFERENCES calles (idCalle) 
);

CREATE TABLE empleos (
	idEmpleo TINYINT IDENTITY(1, 1) PRIMARY KEY,
	puesto VARCHAR(50) NOT NULL
);

CREATE TABLE empleados (
	idEmpleado SMALLINT IDENTITY(1, 1) PRIMARY KEY,
	idPersona INT NOT NULL,
	idEmpleo TINYINT NOT NULL
	CONSTRAINT fk_persona FOREIGN KEY (idPersona) REFERENCES personas (idPersona),
	CONSTRAINT fk_empleo FOREIGN KEY (idEmpleo) REFERENCES empleos (idEmpleo)
);

CREATE TABLE carreras (
	idCarrera TINYINT IDENTITY(1, 1) PRIMARY KEY,
	nombre VARCHAR(60) NOT NULL,
	coordinador SMALLINT NOT NULL,
	CONSTRAINT fk_coordinador FOREIGN KEY (coordinador) REFERENCES empleados(idEmpleado)
);

CREATE TABLE especialidades (
	idEspecialidad TINYINT IDENTITY(1, 1) PRIMARY KEY,
	nombre VARCHAR(40) NOT NULL,
	carrera TINYINT NOT NULL
	CONSTRAINT fk_carrera FOREIGN KEY (carrera) REFERENCES carreras (idCarrera)
);

CREATE TABLE academias (
	idAcademia TINYINT IDENTITY(1, 1) PRIMARY KEY,
	nombre VARCHAR(80) NOT NULL,
);

CREATE TABLE profesores (
	idProfesor VARCHAR(40) PRIMARY KEY,
	idEmpleado SMALLINT NOT NULL,
	idAcademia TINYINT NOT NULL,
	tipoMemb TINYINT NOT NULL		/*	1: Miembro	2: Vocal2	3: Vocal1	4: Secretario	5: Presidente */
	CONSTRAINT fk_empleado FOREIGN KEY (idEmpleado) REFERENCES empleados (idEmpleado),
	CONSTRAINT fk_academia FOREIGN KEY (idAcademia) REFERENCES academias (idAcademia)
);


CREATE TABLE alumnos (
	matricula CHAR(9) PRIMARY KEY,
	idPersona INT NOT NULL,
	idCarrera TINYINT NOT NULL,
	tutor VARCHAR(40) NOT NULL,
	idEspecialidad TINYINT NOT NULL,
	estatus TINYINT NOT NULL
	CONSTRAINT fk_persona_alumno FOREIGN KEY (idPersona) REFERENCES personas (idPersona),
	CONSTRAINT fk_carrera_alumno FOREIGN KEY (idCarrera) REFERENCES carreras (idCarrera),
	CONSTRAINT fk_tutor_alumno FOREIGN KEY (tutor) REFERENCES profesores (idProfesor),
	CONSTRAINT fk_especialidad_alumno FOREIGN KEY (idEspecialidad) REFERENCES especialidades(idEspecialidad)
);

CREATE TABLE materias (
	cveMateria CHAR(8) PRIMARY KEY,
	nombre VARCHAR(40) NOT NULL,
	hTeoricas TINYINT NOT NULL,
	hPracticas TINYINT NOT NULL,
	creditos TINYINT NOT NULL,
	carrera TINYINT NOT NULL
	CONSTRAINT fk_carrera_materia FOREIGN KEY (carrera) REFERENCES carreras (idCarrera)
);

CREATE TABLE grupos (
	cveGrupo CHAR(10) PRIMARY KEY,
	materia CHAR(8) NOT NULL,
	profesor VARCHAR(40) NOT NULL
	CONSTRAINT fk_materia_grupo FOREIGN KEY (materia) REFERENCES materias (cveMateria),
	CONSTRAINT fk_profesor_grupo FOREIGN KEY (profesor) REFERENCES profesores (idProfesor),
);

CREATE TABLE detGrupos (
	idDetGpo INT IDENTITY(1, 1) PRIMARY KEY,
	cveGrupo CHAR(10) NOT NULL,
	matricula CHAR(9) NOT NULL,
	tipoCurso CHAR(2) NOT NULL      /* CN: Curso Normal		CR: Curso Repetición	CE: Curso Especial		CA: Curso Autodidacta */	 
	CONSTRAINT fk_grupo_detgpo FOREIGN KEY (cveGrupo) REFERENCES grupos (cveGrupo),
	CONSTRAINT fk_matricula_detgpo FOREIGN KEY (matricula) REFERENCES alumnos(matricula) 
);

CREATE TABLE horarios (
	idHorario SMALLINT IDENTITY(1, 1) PRIMARY KEY,
	grupo CHAR(10) NOT NULL,
	dia TINYINT NOT NULL,		/* 1: Lunes		2: Martes		3: Miercoles	4: Jueves		5: Viernes */
	hora TINYINT NOT NULL,		/* 1(7:00), 2(7:55), 3(8:50), 4(9:45), 5(10:40), 6(11:35), 7(12:30), 8(13:25), 9(14:20), 10(15:15), 11(16:10), 12(17:05), 13(18:00)   */  	
	aula VARCHAR(8) NOT NULL
	CONSTRAINT fk_grupo_horario FOREIGN KEY (grupo) REFERENCES grupos (cveGrupo)
);

CREATE TABLE inasistencias (
	idInasistencia INT IDENTITY (1, 1) PRIMARY KEY,
	grupo CHAR(10) NOT NULL,
	matricula CHAR(9) NOT NULL,
	fecha DATETIME NOT NULL,
	tipoInasistencia TINYINT NOT NULL		/* 1: Retardo	2: Inasistencia */
	CONSTRAINT fk_grupo_inasistencia FOREIGN KEY (grupo) REFERENCES grupos (cveGrupo),
	CONSTRAINT fk_matricula_inasistencia FOREIGN KEY (matricula) REFERENCES alumnos (matricula) 
);

CREATE TABLE actividades (
	idActividad INT IDENTITY(1, 1) PRIMARY KEY,
	nombre VARCHAR(30) NOT NULL,
	descripcion VARCHAR(150),
	grupo CHAR(10) NOT NULL,
	tema TINYINT NOT NULL,
	ponderacion TINYINT NOT NULL,
	fecha DATETIME NOT NULL
	CONSTRAINT fk_grupo_actividad FOREIGN KEY (grupo) REFERENCES grupos (cveGrupo)
);

CREATE TABLE detActividades (
	idDetAct INT IDENTITY(1, 1) PRIMARY KEY,
	actividad INT NOT NULL,
	matricula CHAR(9) NOT NULL,
	calificacion TINYINT NOT NULL,
	fechaEntrega DATETIME NOT NULL
	CONSTRAINT fk_actividad_detact FOREIGN KEY (actividad) REFERENCES actividades (idActividad),
	CONSTRAINT fk_matricula_detact FOREIGN KEY (matricula) REFERENCES alumnos (matricula)
);

CREATE TABLE calificaciones (
	idCalifiacion INT IDENTITY (1, 1) PRIMARY KEY,
	grupo CHAR(10) NOT NULL,
	matricula CHAR(9) NOT NULL,
	tema TINYINT NOT NULL,
	calificacion FLOAT NOT NULL,
	tipoEval CHAR(1) NOT NULL /* O: ordinaria		C: Complementaria */
	CONSTRAINT fk_grupo_calificacion FOREIGN KEY (grupo) REFERENCES grupos (cveGrupo),
	CONSTRAINT fk_matriucla_calificacion FOREIGN KEY (matricula) REFERENCES alumnos (matricula)
);
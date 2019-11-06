use basetec



insert into academias (nombre) values ('Ingeniería en Sistemas Computacionales')
insert into academias (nombre) values ('Ingeniería en Innovación Agrícola Sustentable')
insert into academias (nombre) values ('Ingeniería en Gestión Empresarial')
insert into academias (nombre) values ('Ingeniería Industrial')
insert into academias (nombre) values ('Ciencias Básicas')
insert into academias (nombre) values ('Lengua Extranjera')



insert into empleos (puesto) values('Profesor')
insert into empleos (puesto) values('Director')
insert into empleos (puesto) values('Coordinador')
insert into empleos (puesto) values('Jefe de Servicios Escolares')
insert into empleos (puesto) values('Jefe de planeación')


insert into estados (nombre) values('Tamaulipas')
insert into estados (nombre) values('Nuevo León')
insert into estados (nombre) values('Veracruz')
insert into estados (nombre) values('San Luis Potosí')



insert into tiposLocalidad (tipo) values('Congregacion')
insert into tiposLocalidad (tipo) values('Fraccionamiento')
insert into tiposLocalidad (tipo) values('Colonia')
insert into tiposLocalidad (tipo) values('Ejido')
insert into tiposLocalidad (tipo) values('Pueblo')
insert into tiposLocalidad (tipo) values('Unidad Habitacional')
insert into tiposLocalidad (tipo) values('Ranchería')
insert into tiposLocalidad (tipo) values('Zona Industrial')

delete from tiposLocalidad

insert into municipios (numero,Estado,nombre) values (1,1,'Abasolo')
insert into municipios (numero,Estado,nombre) values (2,1,'Aldama')
insert into municipios (numero,Estado,nombre) values (3,1,'Altamira')
insert into municipios (numero,Estado,nombre) values (4,1,'Antiguo Morelos')
insert into municipios (numero,Estado,nombre) values (5,1,'Burgos')
insert into municipios (numero,Estado,nombre) values (6,1,'Bustamante')
insert into municipios (numero,Estado,nombre) values (7,1,'Camargo')
select * from municipios



select municipios.idMunicipio, municipios.numero,estados.nombre as Estados, municipios.nombre 
from municipios 
join estados on municipios.Estado = estados.idEstado 



insert into localidades (Municipio,nombre,tipo) values(6,'Independencia',3)
insert into localidades (Municipio,nombre,tipo) values (6,'Miguel Aleman',2)


select * from tiposLocalidad
select * from municipios
select * from localidades

select localidades.idLocalidad,municipios.nombre as municipio,estados.nombre as estado,localidades.nombre 
as Nombre_Localidad
,tiposLocalidad.tipo as Tipo_Localidad, calles.nombre as Calle from localidades 
join municipios on localidades.Municipio = municipios.idMunicipio 
join estados on municipios.Estado = estados.idEstado
join tiposLocalidad on localidades.tipo = tiposLocalidad.idTipoLoc
join calles on localidades.idLocalidad = calles.Localidad

select * from calles
DBCC CHECKIDENT (calles,RESEED,0)
select * from localidades

insert into calles (Localidad,nombre) values(2,'Hidalgo')
insert into calles (Localidad,nombre) values(2,'Ocampo')

alter table personas add localidades int foreign key references localidades(idLocalidad)
alter table personas alter column fecha_nac date not null
select * from calles
select * from localidades

insert into personas (paterno,materno,nombres,fecha_nac,sexo,curp,telefono,idCalle,numExt,numInt,cp,edoCivil,discapacidad,localidades)
values(
'Ibarra','Pérez','André',CONVERT(datetime,'1998-07-23'),1,'IAPA980723HTSBRN00','8311131562',1,'1410',null,'89888',
1,0,2)

insert into personas (paterno,materno,nombres,fecha_nac,sexo,curp,telefono,idCalle,numExt,numInt,cp,edoCivil,discapacidad,localidades)
values(
'Ibarra','Pérez','Brian',CONVERT(datetime,'2004-09-08'),1,'IAPB040908HTSBRN00','8311131562',1,'1410',null,'89888',
1,0,2)




select personas.nombres,personas.paterno,personas.materno, personas.fecha_nac,personas.sexo,personas.curp,
personas.telefono,calles.nombre, personas.numExt,personas.numInt,personas.cp,personas.edoCivil,personas.discapacidad,
localidades.idLocalidad,municipios.nombre as municipio,estados.nombre as estado,localidades.nombre as Nombre_Localidad 
,tiposLocalidad.tipo as Tipo_Localidad, calles.nombre as Calle
from personas join calles on personas.idCalle = calles.idCalle
join localidades on personas.localidades = localidades.idLocalidad
join municipios on localidades.Municipio = municipios.idMunicipio 
join estados on municipios.Estado = estados.idEstado
join tiposLocalidad on localidades.tipo = tiposLocalidad.idTipoLoc

--DBCC CHECKIDENT (estados,RESEED,0) para reiniciar los auto increment y que inicien desde el principio 
select * from academias

select * from empleados
select * from empleos

insert into empleados (idPersona,idEmpleo) values(2,1)

select empleados.idEmpleado,empleados.idPersona,personas.nombres as Nombre, personas.materno as Materno,
personas.paterno as Paterno, personas.curp as Curp, empleados.idEmpleado, empleos.puesto as Puesto
 from empleados 
 join personas on empleados.idPersona = personas.idPersona 
 join empleos on empleados.idEmpleo = empleos.idEmpleo
 

select * from profesores
select * from academias

insert into profesores (idProfesor,idEmpleado,idAcademia,tipoMemb) values ('BIbarra',1,1,1)

select profesores.idProfesor, profesores.idEmpleado,personas.nombres as Nombre,personas.paterno as Paterno, 
personas.materno as Materno, empleados.idEmpleo,empleos.puesto as Puesto, profesores.idAcademia,
academias.nombre as Academia,
profesores.tipoMemb 
from profesores
join empleados on profesores.idEmpleado = empleados.idEmpleado
join academias on profesores.idAcademia = academias.idAcademia
join personas on empleados.idPersona = personas.idPersona
join empleos on empleados.idEmpleo = empleos.idEmpleo



select * from carreras
insert into carreras (nombre, coordinador) values('Ingeniería en Sistemas Computacionales',1);

select carreras.idCarrera,carreras.nombre,carreras.coordinador as idCoordinador,personas.nombres as Nombre,
personas.paterno as Paterno,personas.materno as Materno
from carreras
join empleados on carreras.coordinador = empleados.idEmpleado
join personas on empleados.idPersona = personas.idPersona 


select * from especialidades
select * from carreras

insert into especialidades (nombre,carrera) values ('Base de Datos',1)

select especialidades.idEspecialidad,especialidades.nombre, carreras.nombre as Carrera
from especialidades
join carreras on especialidades.carrera =  carreras.idCarrera

select * from materias

insert into materias (cveMateria,nombre,hTeoricas,hPracticas,creditos,carrera) 
values ('ABCD1234','Matematicas Discretas',40,40,5,1)

select materias.cveMateria,materias.nombre,materias.hTeoricas,materias.hPracticas,materias.creditos,
materias.carrera, carreras.nombre as NombreCarrera
 from materias 
 join carreras on materias.carrera = carreras.idCarrera
 
 
 select * from grupos
 
 insert into grupos (cveGrupo,materia,profesor) values('Discretas1','ABCD1234','BIbarra')
 
 select * from alumnos
 select * from personas
 select * from carreras
 select * from profesores
 select * from especialidades
 
 insert into alumnos (matricula,idPersona,idCarrera,tutor,idEspecialidad,estatus)
 values ('1601F0062',1,1,'BIbarra',1,1)
 
 select alumnos.matricula, alumnos.idPersona, personas.nombres as Nombre, personas.paterno as Paterno, 
 personas.materno as Materno, alumnos.idCarrera,
 carreras.nombre as CarreraNombre, alumnos.tutor, alumnos.idEspecialidad,
 especialidades.nombre as EspecialidadNombre, alumnos.estatus 
 from alumnos
 join personas on alumnos.idPersona = personas.idPersona
 join carreras on alumnos.idCarrera = carreras.idCarrera
 join especialidades on alumnos.idEspecialidad = especialidades.idEspecialidad
 
 
 select * from actividades
 select * from grupos
  
 insert into actividades (nombre,descripcion,grupo,tema,ponderacion,fecha) 
 values ('Tarea 1','Realizar resumen sobre..','Discretas1',1,5,'2019-10-10')
 
 select actividades.idActividad,actividades.nombre,actividades.descripcion,actividades.grupo,
 grupos.materia as IDMateria, materias.nombre as MateriaNombre, actividades.tema, actividades.ponderacion, 
 actividades.fecha
 from actividades
 join grupos on actividades.grupo = grupos.cveGrupo
 join materias on materias.cveMateria = grupos.materia
 
 select * from horarios
 
 insert into horarios (grupo,dia,hora,aula) values('Discretas1',5,3,'CC2')
 
 
 select horarios.idHorario, horarios.grupo, grupos.materia as IDMateria, materias.nombre as MateriaNombre, 
 horarios.dia,horarios.hora,horarios.aula 
 from horarios
 join grupos on horarios.grupo = grupos.cveGrupo
 join materias on materias.cveMateria = grupos.materia
 
 select * from calificaciones
 select * from grupos
 select * from alumnos
 select * from personas
 
 insert into calificaciones (grupo,matricula,tema,calificacion,tipoEval)
 values('Discretas1','1601F0062',1,100,'O')
 
 select calificaciones.idCalificacion, grupos.materia as IDMateria, materias.nombre as MateriaNombre, 
 alumnos.matricula as MatriculaAlumno, personas.nombres as NombreAlumno, personas.paterno as Paterno,
 personas.materno as Materno, calificaciones.tema, calificaciones.calificacion, calificaciones.tipoEval
 from calificaciones
 join grupos on calificaciones.grupo = grupos.cveGrupo
 join alumnos on calificaciones.matricula = alumnos.matricula
 join personas on alumnos.idPersona = personas.idPersona
 join materias on grupos.materia = materias.cveMateria
 
 
 select * from detActividades
 select * from actividades
 
 insert into detActividades (actividad,matricula,calificacion,fechaEntrega)
 values(3,'1601F0062',5,'2019-10-11')
 
 select detActividades.idDetAct, detActividades.actividad, actividades.nombre as ActividadesNombre, 
 detActividades.matricula, personas.nombres as Nombre, personas.paterno as Paterno, personas.materno as Materno, 
 detActividades.calificacion, detActividades.fechaEntrega
 from detActividades
 join actividades on detActividades.actividad = actividades.idActividad
 join alumnos on detActividades.matricula = alumnos.matricula
 join personas on alumnos.idPersona = personas.idPersona
 
 
 select * from detGrupos
 select * from grupos
 
 insert into detGrupos (cveGrupo, matricula, tipoCurso) values('Discretas1','1601F0062','CN')
 
 select detGrupos.idDetGpo, detGrupos.cveGrupo, grupos.materia as IDMateria, materias.nombre as MateriaNombre, 
 detGrupos.matricula, alumnos.idPersona as IDPersona,personas.nombres as Nombre, personas.paterno as Paterno, 
 personas.materno as Materno, detGrupos.tipoCurso
 from detGrupos 
 join grupos on detGrupos.cveGrupo = grupos.cveGrupo
 join alumnos on detGrupos.matricula = alumnos.matricula
 join personas on alumnos.idPersona = personas.idPersona
 join materias on grupos.materia = materias.cveMateria
 
 
 
 select * from inasistencias
 select * from grupos
 
 
 insert into inasistencias (grupo, matricula, fecha, tipoInasistencia)
 values ('Discretas1', '1601F0062', '2019-10-09',1)
 
 
 select inasistencias.idInasistencia, inasistencias.grupo, grupos.materia as IDMateria, materias.nombre as MateriaNombre, 
 inasistencias.matricula, alumnos.idPersona as IDPersona, personas.nombres as Nombre, personas.paterno as Paterno, 
 personas.materno as Materno, inasistencias.fecha, inasistencias.tipoInasistencia
 from inasistencias 
 join grupos on inasistencias.grupo = grupos.cveGrupo
 join materias on grupos.materia = materias.cveMateria
 join alumnos on inasistencias.matricula = alumnos.matricula
 join personas on alumnos.idPersona = personas.idPersona
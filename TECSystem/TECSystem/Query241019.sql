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

insert into estados (nombre) values('Aguascalientes')
insert into estados (nombre) values('Baja California')
insert into estados (nombre) values('Baja California Sur')
insert into estados (nombre) values('Campeche')
insert into estados (nombre) values('Chiapas')
insert into estados (nombre) values('Chihuahua')
insert into estados (nombre) values('Coahuila de Zaragoza')
insert into estados (nombre) values('Colima')
insert into estados (nombre) values('Durango')
insert into estados (nombre) values('Estado de México')
insert into estados (nombre) values('Guanajuato')
insert into estados (nombre) values('Guerrero')
insert into estados (nombre) values('Hidalgo')
insert into estados (nombre) values('Jalisco')
insert into estados (nombre) values('Michoacán de Ocampo')
insert into estados (nombre) values('Morelos')
insert into estados (nombre) values('Nayarit')
insert into estados (nombre) values('Nuevo León')
insert into estados (nombre) values('Oaxaca')
insert into estados (nombre) values('Puebla')
insert into estados (nombre) values('Querétaro')
insert into estados (nombre) values('Quintana Roo')
insert into estados (nombre) values('San Luis Potosí')
insert into estados (nombre) values('Sinaloa')
insert into estados (nombre) values('Sonora')
insert into estados (nombre) values('Tabasco')
insert into estados (nombre) values('Tamaulipas')
insert into estados (nombre) values('Tlaxcala')
insert into estados (nombre) values('Veracruz')
insert into estados (nombre) values('Yucatán')
insert into estados (nombre) values('Zacatecas')

select * from estados


insert into tiposLocalidad (tipo) values('Colonia')
insert into tiposLocalidad (tipo) values('Congregacion')
insert into tiposLocalidad (tipo) values('Ejido')
insert into tiposLocalidad (tipo) values('Fraccionamiento')
insert into tiposLocalidad (tipo) values('Pueblo')
insert into tiposLocalidad (tipo) values('Ranchería')
insert into tiposLocalidad (tipo) values('Unidad Habitacional')
insert into tiposLocalidad (tipo) values('Zona Industrial')

select * from tiposLocalidad


insert into municipios (numero,Estado,nombre) values (1,27,'Abasolo')
insert into municipios (numero,Estado,nombre) values (2,27,'Aldama')
insert into municipios (numero,Estado,nombre) values (3,27,'Altamira')
insert into municipios (numero,Estado,nombre) values (4,27,'Antiguo Morelos')
insert into municipios (numero,Estado,nombre) values (5,27,'Burgos')
insert into municipios (numero,Estado,nombre) values (6,27,'Bustamante')
insert into municipios (numero,Estado,nombre) values (7,27,'Camargo')
insert into municipios (numero,Estado,nombre) values (8,27,'Casas')
insert into municipios (numero,Estado,nombre) values (9,27,'Ciudad Madero')
insert into municipios (numero,Estado,nombre) values (10,27,'Cruillas')
insert into municipios (numero,Estado,nombre) values (11,27,'Gomez Farías')
insert into municipios (numero,Estado,nombre) values (12,27,'González')
insert into municipios (numero,Estado,nombre) values (13,27,'Güémez')
insert into municipios (numero,Estado,nombre) values (14,27,'Guerrero')
insert into municipios (numero,Estado,nombre) values (15,27,'Gustavo Díaz Ordaz')
insert into municipios (numero,Estado,nombre) values (16,27,'Hidalgo')
insert into municipios (numero,Estado,nombre) values (17,27,'Jaumave')
insert into municipios (numero,Estado,nombre) values (18,27,'Jiménez')
insert into municipios (numero,Estado,nombre) values (19,27,'Llera')
insert into municipios (numero,Estado,nombre) values (20,27,'Mainero')
insert into municipios (numero,Estado,nombre) values (21,27,'El Mante')
insert into municipios (numero,Estado,nombre) values (22,27,'Matamoros')
insert into municipios (numero,Estado,nombre) values (23,27,'Méndez')
insert into municipios (numero,Estado,nombre) values (24,27,'Mier')
insert into municipios (numero,Estado,nombre) values (25,27,'Miguel Alemán')
insert into municipios (numero,Estado,nombre) values (26,27,'Miquihuana')
insert into municipios (numero,Estado,nombre) values (27,27,'Nuevo Laredo')
insert into municipios (numero,Estado,nombre) values (28,27,'Nuevo Morelos')
insert into municipios (numero,Estado,nombre) values (29,27,'Ocampo')
insert into municipios (numero,Estado,nombre) values (30,27,'Padilla')
insert into municipios (numero,Estado,nombre) values (31,27,'Palmillas')
insert into municipios (numero,Estado,nombre) values (32,27,'Reynosa')
insert into municipios (numero,Estado,nombre) values (33,27,'Río Bravo')
insert into municipios (numero,Estado,nombre) values (34,27,'San Carlos')
insert into municipios (numero,Estado,nombre) values (35,27,'San Fernando')
insert into municipios (numero,Estado,nombre) values (36,27,'San Nicolás')
insert into municipios (numero,Estado,nombre) values (37,27,'Soto la Marina')
insert into municipios (numero,Estado,nombre) values (38,27,'Tampico')
insert into municipios (numero,Estado,nombre) values (39,27,'Tula')
insert into municipios (numero,Estado,nombre) values (40,27,'Valle Hermoso')
insert into municipios (numero,Estado,nombre) values (41,27,'Victoria')
insert into municipios (numero,Estado,nombre) values (42,27,'Villagrán')
insert into municipios (numero,Estado,nombre) values (43,27,'Xicoténcatl')


select * from municipios

select municipios.idMunicipio, municipios.numero as NumeroMunicipio,ESTADOS.idEstado,estados.nombre as Estado,
municipios.nombre as Municipio 
from municipios 
join estados on municipios.Estado = estados.idEstado 

insert into localidades (Municipio,nombre,tipo) values(21,'16 de Septiembre',3)
insert into localidades (Municipio,nombre,tipo) values (21,'18 de Febrero',3)
insert into localidades (Municipio,nombre,tipo) values (21,'18 de Marzo',3)
insert into localidades (Municipio,nombre,tipo) values (21,'1ro de Mayo',3)
insert into localidades (Municipio,nombre,tipo) values (21,'20 de Noviembre',3)
insert into localidades (Municipio,nombre,tipo) values (21,'20 de Septiembre',1)
insert into localidades (Municipio,nombre,tipo) values (21,'5 de Mayo',3)
insert into localidades (Municipio,nombre,tipo) values (21,'7 de Noviembre',3)
insert into localidades (Municipio,nombre,tipo) values (21,'Aeropuerto',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Altavista',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Álvaro Obregón',3)
insert into localidades (Municipio,nombre,tipo) values (21,'Anáhuac 1',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Anáhuac 2',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Andalucía',4)
insert into localidades (Municipio,nombre,tipo) values (21,'Aquiles Serdán',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Aurora',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Ayuntamiento',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Azucarera',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Bellavista',3)
insert into localidades (Municipio,nombre,tipo) values (21,'Benito Juárez',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Benito Juárez',3)
insert into localidades (Municipio,nombre,tipo) values (21,'Burócrata',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Campesina',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Campesina 2',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Campestre',4)
insert into localidades (Municipio,nombre,tipo) values (21,'Canoas',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Carlos M del Pino',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Carolina Yucatán Dos',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Celaya',3)
insert into localidades (Municipio,nombre,tipo) values (21,'Cerro del Bernal',4)
insert into localidades (Municipio,nombre,tipo) values (21,'Chapultepec',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Ciudad Mante Centro',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Country Club',4)
insert into localidades (Municipio,nombre,tipo) values (21,'Cuauhtémoc',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Del Bosque',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Del Músico',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Del Valle',1)
insert into localidades (Municipio,nombre,tipo) values (21,'División del Norte',3)
insert into localidades (Municipio,nombre,tipo) values (21,'El Abra',2)
insert into localidades (Municipio,nombre,tipo) values (21,'El Camotero',3)
insert into localidades (Municipio,nombre,tipo) values (21,'El Huastequillo',3)
insert into localidades (Municipio,nombre,tipo) values (21,'El Limón',5)
insert into localidades (Municipio,nombre,tipo) values (21,'El Martillo',1)
insert into localidades (Municipio,nombre,tipo) values (21,'El Olímpico',3)
insert into localidades (Municipio,nombre,tipo) values (21,'El Refugio',3)
insert into localidades (Municipio,nombre,tipo) values (21,'El Triunfo Número 1',3)
insert into localidades (Municipio,nombre,tipo) values (21,'El Triunfo Número 2',3)
insert into localidades (Municipio,nombre,tipo) values (21,'Emiliano Zapata',3)
insert into localidades (Municipio,nombre,tipo) values (21,'Enrique Cárdenas González',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Esfuerzo Obrero',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Faja de Oro',3)
insert into localidades (Municipio,nombre,tipo) values (21,'Faja de Oro',4)
insert into localidades (Municipio,nombre,tipo) values (21,'Felipe Ángeles',3)
insert into localidades (Municipio,nombre,tipo) values (21,'Fomento Nacional',1)
insert into localidades (Municipio,nombre,tipo) values (21,'FOVISSSTE 1',7)
insert into localidades (Municipio,nombre,tipo) values (21,'FOVISSSTE 2',7)
insert into localidades (Municipio,nombre,tipo) values (21,'Francisco I. Madero',3)
insert into localidades (Municipio,nombre,tipo) values (21,'Francisco Villa',3)
insert into localidades (Municipio,nombre,tipo) values (21,'Gerardo Ferrara',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Gonzalez Ortega',3)
insert into localidades (Municipio,nombre,tipo) values (21,'Ignacio Allende',3)
insert into localidades (Municipio,nombre,tipo) values (21,'Ignacio de la Llave',1)
insert into localidades (Municipio,nombre,tipo) values (21,'Independencia',1)


select * from localidades


select localidades.idLocalidad,municipios.idMunicipio as idMunicipio,municipios.nombre as Municipio,
estados.idEstado as idEstado,estados.nombre as Estado,localidades.nombre as Nombre_Localidad,
tiposLocalidad.idTipoLoc as idTipoLocalidad, tiposLocalidad.tipo as Tipo_Localidad from localidades 
join municipios on localidades.Municipio = municipios.idMunicipio 
join estados on municipios.Estado = estados.idEstado
join tiposLocalidad on localidades.tipo = tiposLocalidad.idTipoLoc

insert into calles (Localidad,nombre) values(63,'Hidalgo')
insert into calles (Localidad,nombre) values(2,'Ocampo')

select * from calles


alter table personas add localidades int foreign key references localidades(idLocalidad)
alter table personas alter column fecha_nac date not null


insert into personas (paterno,materno,nombres,fecha_nac,sexo,curp,telefono,numExt,numInt,cp,edoCivil,discapacidad,calle,localidades)
values(
'Ibarra','Pérez','André',CONVERT(datetime,'1998-07-23'),1,'IAPA980723HTSBRN00','8311131562','1410',null,'89888',
1,0,'Hidalgo',63)

insert into personas (paterno,materno,nombres,fecha_nac,sexo,curp,telefono,numExt,numInt,cp,edoCivil,discapacidad,calle,localidades)
values(
'Sobrevilla','Pintor','Veronica',CONVERT(datetime,'1990-05-19'),1,'SOPV900519','8311148648','610',null,'89800',
1,0,'Ocampo',32)

select personas.nombres,personas.paterno,personas.materno, personas.fecha_nac,personas.sexo,personas.curp,
personas.telefono, personas.numExt,personas.numInt,personas.cp,personas.edoCivil,personas.discapacidad,
localidades.idLocalidad,municipios.nombre as municipio,estados.nombre as estado, personas.calle, 
tiposLocalidad.tipo as Tipo_Localidad, localidades.nombre as Nombre_Localidad
from personas
join localidades on personas.localidades = localidades.idLocalidad
join municipios on localidades.Municipio = municipios.idMunicipio 
join estados on municipios.Estado = estados.idEstado
join tiposLocalidad on localidades.tipo = tiposLocalidad.idTipoLoc

select * from academias
select * from empleados
select * from empleos

insert into empleados (idPersona,idEmpleo) values(2,1)

select empleados.idEmpleado,empleados.idPersona,personas.nombres as Nombre, personas.materno as Materno,
personas.paterno as Paterno, personas.curp as Curp, empleados.idEmpleado, empleos.puesto as Puesto
 from empleados 
 join personas on empleados.idPersona = personas.idPersona 
 join empleos on empleados.idEmpleo = empleos.idEmpleo
 
 select * from empleados
 
 insert into profesores (idProfesor,idEmpleado,idAcademia,tipoMemb) values ('VSobrevilla',1,1,1)
 select * from profesores
 
 
 
 
 TABLAS QUE NO TIENEN FOREIGN KEYS

--ACADEMIAS
--EMPLEOS
--ESTADOS
--TIPOSLOCALIDAD

TABLAS QUE NECESITAN DE 1 TABLA LLENA
--ACTIVIDADES -- GRUPOS
--CALLES -- LOCALIDADES
--CARRERAS -- EMPLEADOS
--ESPECIALIDADES -- CARRERAS
--HORARIOS -- GRUPOS
--MATERIAS -- CARRERAS
--MUNICIPIO -- ESTADOS
--PERSONAS -- CALLES

TABLAS QUE NECESITAN DE 2 TABLAS LLENAS
--CALIFICACIONES -- GRUPOS, ALUMNOS
--DETACTIVDADES -- ACTIVIDADES, ALUMNOS
--DETGRUPOS -- GRUPOS, ALUMNOS
--EMPLEADOS -- PERSONAS, EMPLEOS
--GRUPOS -- MATERIAS, PROFESORES
--INASISTENCIAS -- GRUPOS, ALUMNOS
--LOCALIDADES -- MUNICIPIO, TIPOLOCALIDAD
--PROFESORES -- EMPLEADOS, ACADEMIAS

TABLAS QUE NECESITAN DE 4 TABLAS LLENAS
--ALUMNOS -- PERSONAS, CARRERAS, PROFESORES, ESPECIALIDADES


+ACADEMIAS 
+EMPLEOS
+ESTADOS
+TIPOSLOCALIDAD treto
+MUNICIPIO
+LOCALIDADES
+CALLES
+PERSONAS       fili
+EMPLEADOS
+PROFESORES
+CARRERAS
+ESPECIALIDADES monche
+MATERIAS
+GRUPOS
+ALUMNOS
+ACTIVIDADES    macoy
+HORARIOS
+CALIFICACIONES
+DETACTIVIDADES
+DETGRUPOS      
+INASISTENCIAS  oscar






+ACADEMIAS
+EMPLEOS
+ESTADOS
+TIPOSLOCALIDAD
+MUNICIPIO			ESTADOS
+LOCALIDADES			MUNICIPIO		TIPOSLOCALIDAD
NO +CALLES				LOCALIDADES
+PERSONAS			CALLES
+EMPLEADOS			PERSONAS		EMPLEOS
+PROFESORES			EMPLEADOS		ACADEMIA
+CARRERAS			EMPLEADOS		
+ESPECIALIDADES			CARRERAS
+MATERIAS			CARRERAS
+GRUPOS				MATERIAS		PROFESORES
+ALUMNOS			PERSONAS		CARRERAS		PROFESORES		ESPECIALIDADES
+ACTIVIDADES			GRUPOS
+HORARIOS			GRUPOS
+CALIFICACIONES			GRUPOS			ALUMNOS
+DETACTIVIDADES			ACTIVIDADES		ALUMNOS
+DETGRUPOS			GRUPOS			ALUMNOS
+INASISTENCIAS			GRUPOS			ALUMNOS




PROFE					YOMERO
1 Ejido					1 Colonia
2 Colonia				2 Congregación
3 Fraccionamiento			3 Ejido
4 Congregación				4 Fraccionamiento
5 Pueblo				5 Pueblo
6 Unidad habitacional			6 Ranchería
7 Ranchería				7 Unidad habitacional
8 Zona industrial			8 Zona industrial



create table usuarios_Login(
idUsuario int identity(1,1) primary key not null,
nombre varchar(40) not null,
apellidos varchar(80) not null,
email varchar(50) not null,
usuario varchar(15) not null,
pass varchar(10) not null)
USE [master]
GO
/****** Object:  Database [basetec]    Script Date: 10/03/2019 16:56:26 ******/
CREATE DATABASE [basetec] ON  PRIMARY 
( NAME = N'basetec', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\basetec.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'basetec_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\basetec_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [basetec] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [basetec].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [basetec] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [basetec] SET ANSI_NULLS OFF
GO
ALTER DATABASE [basetec] SET ANSI_PADDING OFF
GO
ALTER DATABASE [basetec] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [basetec] SET ARITHABORT OFF
GO
ALTER DATABASE [basetec] SET AUTO_CLOSE ON
GO
ALTER DATABASE [basetec] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [basetec] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [basetec] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [basetec] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [basetec] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [basetec] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [basetec] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [basetec] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [basetec] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [basetec] SET  ENABLE_BROKER
GO
ALTER DATABASE [basetec] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [basetec] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [basetec] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [basetec] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [basetec] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [basetec] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [basetec] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [basetec] SET  READ_WRITE
GO
ALTER DATABASE [basetec] SET RECOVERY SIMPLE
GO
ALTER DATABASE [basetec] SET  MULTI_USER
GO
ALTER DATABASE [basetec] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [basetec] SET DB_CHAINING OFF
GO
USE [basetec]
GO
/****** Object:  Table [dbo].[tiposLocalidad]    Script Date: 10/03/2019 16:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tiposLocalidad](
	[idTipoLoc] [tinyint] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipoLoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tiposLocalidad] ON
INSERT [dbo].[tiposLocalidad] ([idTipoLoc], [tipo]) VALUES (1, N'Congregacion')
INSERT [dbo].[tiposLocalidad] ([idTipoLoc], [tipo]) VALUES (2, N'Fraccionamiento')
INSERT [dbo].[tiposLocalidad] ([idTipoLoc], [tipo]) VALUES (3, N'Colonia')
INSERT [dbo].[tiposLocalidad] ([idTipoLoc], [tipo]) VALUES (4, N'Ejido')
INSERT [dbo].[tiposLocalidad] ([idTipoLoc], [tipo]) VALUES (5, N'Pueblo')
INSERT [dbo].[tiposLocalidad] ([idTipoLoc], [tipo]) VALUES (6, N'Unidad Habitacional')
INSERT [dbo].[tiposLocalidad] ([idTipoLoc], [tipo]) VALUES (7, N'Ranchería')
INSERT [dbo].[tiposLocalidad] ([idTipoLoc], [tipo]) VALUES (8, N'Zona Industrial')
SET IDENTITY_INSERT [dbo].[tiposLocalidad] OFF
/****** Object:  Table [dbo].[empleos]    Script Date: 10/03/2019 16:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleos](
	[idEmpleo] [tinyint] IDENTITY(1,1) NOT NULL,
	[puesto] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEmpleo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[empleos] ON
INSERT [dbo].[empleos] ([idEmpleo], [puesto]) VALUES (1, N'Profesor')
INSERT [dbo].[empleos] ([idEmpleo], [puesto]) VALUES (2, N'Director')
INSERT [dbo].[empleos] ([idEmpleo], [puesto]) VALUES (3, N'Coordinador')
INSERT [dbo].[empleos] ([idEmpleo], [puesto]) VALUES (4, N'Jefe de Servicios Escolares')
INSERT [dbo].[empleos] ([idEmpleo], [puesto]) VALUES (5, N'Jefe de planeación')
SET IDENTITY_INSERT [dbo].[empleos] OFF
/****** Object:  Table [dbo].[academias]    Script Date: 10/03/2019 16:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[academias](
	[idAcademia] [tinyint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](80) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idAcademia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[academias] ON
INSERT [dbo].[academias] ([idAcademia], [nombre]) VALUES (1, N'Ingeniería en Sistemas Computacionales')
INSERT [dbo].[academias] ([idAcademia], [nombre]) VALUES (2, N'Ingeniería en Innovación Agrícola Sustentable')
INSERT [dbo].[academias] ([idAcademia], [nombre]) VALUES (3, N'Ingeniería en Gestión Empresarial')
INSERT [dbo].[academias] ([idAcademia], [nombre]) VALUES (4, N'Ingeniería Industrial')
INSERT [dbo].[academias] ([idAcademia], [nombre]) VALUES (5, N'Ciencias Básicas')
INSERT [dbo].[academias] ([idAcademia], [nombre]) VALUES (6, N'Lengua Extranjera')
SET IDENTITY_INSERT [dbo].[academias] OFF
/****** Object:  Table [dbo].[estados]    Script Date: 10/03/2019 16:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estados](
	[idEstado] [tinyint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](32) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEstado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[estados] ON
INSERT [dbo].[estados] ([idEstado], [nombre]) VALUES (1, N'Tamaulipas')
INSERT [dbo].[estados] ([idEstado], [nombre]) VALUES (2, N'Nuevo León')
INSERT [dbo].[estados] ([idEstado], [nombre]) VALUES (3, N'Veracruz')
INSERT [dbo].[estados] ([idEstado], [nombre]) VALUES (4, N'San Luis Potosí')
SET IDENTITY_INSERT [dbo].[estados] OFF
/****** Object:  Table [dbo].[municipios]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[municipios](
	[idMunicipio] [smallint] IDENTITY(1,1) NOT NULL,
	[numero] [tinyint] NOT NULL,
	[Estado] [tinyint] NOT NULL,
	[nombre] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMunicipio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[municipios] ON
INSERT [dbo].[municipios] ([idMunicipio], [numero], [Estado], [nombre]) VALUES (1, 1, 1, N'Abasolo')
INSERT [dbo].[municipios] ([idMunicipio], [numero], [Estado], [nombre]) VALUES (2, 2, 1, N'Aldama')
INSERT [dbo].[municipios] ([idMunicipio], [numero], [Estado], [nombre]) VALUES (3, 3, 1, N'Altamira')
INSERT [dbo].[municipios] ([idMunicipio], [numero], [Estado], [nombre]) VALUES (4, 4, 1, N'Antiguo Morelos')
INSERT [dbo].[municipios] ([idMunicipio], [numero], [Estado], [nombre]) VALUES (5, 5, 1, N'Burgos')
INSERT [dbo].[municipios] ([idMunicipio], [numero], [Estado], [nombre]) VALUES (6, 6, 1, N'Bustamante')
INSERT [dbo].[municipios] ([idMunicipio], [numero], [Estado], [nombre]) VALUES (7, 7, 1, N'Camargo')
SET IDENTITY_INSERT [dbo].[municipios] OFF
/****** Object:  Table [dbo].[localidades]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[localidades](
	[idLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[Municipio] [smallint] NOT NULL,
	[nombre] [varchar](40) NULL,
	[tipo] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idLocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[localidades] ON
INSERT [dbo].[localidades] ([idLocalidad], [Municipio], [nombre], [tipo]) VALUES (1, 6, N'Independencia', 3)
INSERT [dbo].[localidades] ([idLocalidad], [Municipio], [nombre], [tipo]) VALUES (2, 6, N'Miguel Aleman', 2)
SET IDENTITY_INSERT [dbo].[localidades] OFF
/****** Object:  Table [dbo].[calles]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[calles](
	[idCalle] [int] IDENTITY(1,1) NOT NULL,
	[Localidad] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCalle] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[calles] ON
INSERT [dbo].[calles] ([idCalle], [Localidad], [nombre]) VALUES (1, 2, N'Hidalgo')
INSERT [dbo].[calles] ([idCalle], [Localidad], [nombre]) VALUES (2, 2, N'Ocampo')
SET IDENTITY_INSERT [dbo].[calles] OFF
/****** Object:  Table [dbo].[personas]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[personas](
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[paterno] [varchar](40) NOT NULL,
	[materno] [varchar](40) NULL,
	[nombres] [varchar](40) NOT NULL,
	[fecha_nac] [date] NOT NULL,
	[sexo] [bit] NOT NULL,
	[curp] [char](18) NOT NULL,
	[telefono] [char](10) NULL,
	[idCalle] [int] NOT NULL,
	[numExt] [varchar](5) NOT NULL,
	[numInt] [varchar](5) NULL,
	[cp] [char](5) NULL,
	[edoCivil] [tinyint] NOT NULL,
	[discapacidad] [tinyint] NOT NULL,
	[localidades] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[personas] ON
INSERT [dbo].[personas] ([idPersona], [paterno], [materno], [nombres], [fecha_nac], [sexo], [curp], [telefono], [idCalle], [numExt], [numInt], [cp], [edoCivil], [discapacidad], [localidades]) VALUES (1, N'Ibarra', N'Pérez', N'André', CAST(0xF8210B00 AS Date), 1, N'IAPA980723HTSBRN00', N'8311131562', 1, N'1410', NULL, N'89888', 1, 0, 2)
INSERT [dbo].[personas] ([idPersona], [paterno], [materno], [nombres], [fecha_nac], [sexo], [curp], [telefono], [idCalle], [numExt], [numInt], [cp], [edoCivil], [discapacidad], [localidades]) VALUES (2, N'Ibarra', N'Pérez', N'Brian', CAST(0xB72A0B00 AS Date), 1, N'IAPB040908HTSBRN00', N'8311131562', 1, N'1410', NULL, N'89888', 1, 0, 2)
SET IDENTITY_INSERT [dbo].[personas] OFF
/****** Object:  Table [dbo].[empleados]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[idEmpleado] [smallint] IDENTITY(1,1) NOT NULL,
	[idPersona] [int] NOT NULL,
	[idEmpleo] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[empleados] ON
INSERT [dbo].[empleados] ([idEmpleado], [idPersona], [idEmpleo]) VALUES (1, 2, 1)
SET IDENTITY_INSERT [dbo].[empleados] OFF
/****** Object:  Table [dbo].[profesores]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[profesores](
	[idProfesor] [varchar](40) NOT NULL,
	[idEmpleado] [smallint] NOT NULL,
	[idAcademia] [tinyint] NOT NULL,
	[tipoMemb] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProfesor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[profesores] ([idProfesor], [idEmpleado], [idAcademia], [tipoMemb]) VALUES (N'BIbarra', 1, 1, 1)
/****** Object:  Table [dbo].[carreras]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[carreras](
	[idCarrera] [tinyint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[coordinador] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCarrera] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[carreras] ON
INSERT [dbo].[carreras] ([idCarrera], [nombre], [coordinador]) VALUES (1, N'Ingeniería en Sistemas Computacionales', 1)
SET IDENTITY_INSERT [dbo].[carreras] OFF
/****** Object:  Table [dbo].[materias]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[materias](
	[cveMateria] [char](8) NOT NULL,
	[nombre] [varchar](40) NOT NULL,
	[hTeoricas] [tinyint] NOT NULL,
	[hPracticas] [tinyint] NOT NULL,
	[creditos] [tinyint] NOT NULL,
	[carrera] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cveMateria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[materias] ([cveMateria], [nombre], [hTeoricas], [hPracticas], [creditos], [carrera]) VALUES (N'ABCD1234', N'Matematicas Discretas', 40, 40, 5, 1)
/****** Object:  Table [dbo].[especialidades]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[especialidades](
	[idEspecialidad] [tinyint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](40) NOT NULL,
	[carrera] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEspecialidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[especialidades] ON
INSERT [dbo].[especialidades] ([idEspecialidad], [nombre], [carrera]) VALUES (1, N'Base de Datos', 1)
SET IDENTITY_INSERT [dbo].[especialidades] OFF
/****** Object:  Table [dbo].[alumnos]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[alumnos](
	[matricula] [char](9) NOT NULL,
	[idPersona] [int] NOT NULL,
	[idCarrera] [tinyint] NOT NULL,
	[tutor] [varchar](40) NOT NULL,
	[idEspecialidad] [tinyint] NOT NULL,
	[estatus] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[matricula] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[alumnos] ([matricula], [idPersona], [idCarrera], [tutor], [idEspecialidad], [estatus]) VALUES (N'1601F0062', 1, 1, N'BIbarra', 1, 1)
/****** Object:  Table [dbo].[grupos]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[grupos](
	[cveGrupo] [char](10) NOT NULL,
	[materia] [char](8) NOT NULL,
	[profesor] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cveGrupo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[grupos] ([cveGrupo], [materia], [profesor]) VALUES (N'Discretas1', N'ABCD1234', N'BIbarra')
/****** Object:  Table [dbo].[inasistencias]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inasistencias](
	[idInasistencia] [int] IDENTITY(1,1) NOT NULL,
	[grupo] [char](10) NOT NULL,
	[matricula] [char](9) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[tipoInasistencia] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idInasistencia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[inasistencias] ON
INSERT [dbo].[inasistencias] ([idInasistencia], [grupo], [matricula], [fecha], [tipoInasistencia]) VALUES (1, N'Discretas1', N'1601F0062', CAST(0x0000AAE100000000 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[inasistencias] OFF
/****** Object:  Table [dbo].[horarios]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[horarios](
	[idHorario] [smallint] IDENTITY(1,1) NOT NULL,
	[grupo] [char](10) NOT NULL,
	[dia] [tinyint] NOT NULL,
	[hora] [tinyint] NOT NULL,
	[aula] [varchar](8) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idHorario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[horarios] ON
INSERT [dbo].[horarios] ([idHorario], [grupo], [dia], [hora], [aula]) VALUES (1, N'Discretas1', 5, 3, N'CC2')
SET IDENTITY_INSERT [dbo].[horarios] OFF
/****** Object:  Table [dbo].[calificaciones]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[calificaciones](
	[idCalificacion] [int] IDENTITY(1,1) NOT NULL,
	[grupo] [char](10) NOT NULL,
	[matricula] [char](9) NOT NULL,
	[tema] [tinyint] NOT NULL,
	[calificacion] [float] NOT NULL,
	[tipoEval] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCalificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[calificaciones] ON
INSERT [dbo].[calificaciones] ([idCalificacion], [grupo], [matricula], [tema], [calificacion], [tipoEval]) VALUES (1, N'Discretas1', N'1601F0062', 1, 100, N'O')
SET IDENTITY_INSERT [dbo].[calificaciones] OFF
/****** Object:  Table [dbo].[actividades]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[actividades](
	[idActividad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[grupo] [char](10) NOT NULL,
	[tema] [tinyint] NOT NULL,
	[ponderacion] [tinyint] NOT NULL,
	[fecha] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idActividad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[actividades] ON
INSERT [dbo].[actividades] ([idActividad], [nombre], [descripcion], [grupo], [tema], [ponderacion], [fecha]) VALUES (3, N'Tarea 1', N'Realizar resumen sobre..', N'Discretas1', 1, 5, CAST(0x0000AAE200000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[actividades] OFF
/****** Object:  Table [dbo].[detGrupos]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detGrupos](
	[idDetGpo] [int] IDENTITY(1,1) NOT NULL,
	[cveGrupo] [char](10) NOT NULL,
	[matricula] [char](9) NOT NULL,
	[tipoCurso] [char](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDetGpo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[detGrupos] ON
INSERT [dbo].[detGrupos] ([idDetGpo], [cveGrupo], [matricula], [tipoCurso]) VALUES (1, N'Discretas1', N'1601F0062', N'CN')
SET IDENTITY_INSERT [dbo].[detGrupos] OFF
/****** Object:  Table [dbo].[detActividades]    Script Date: 10/03/2019 16:56:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detActividades](
	[idDetAct] [int] IDENTITY(1,1) NOT NULL,
	[actividad] [int] NOT NULL,
	[matricula] [char](9) NOT NULL,
	[calificacion] [tinyint] NOT NULL,
	[fechaEntrega] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDetAct] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[detActividades] ON
INSERT [dbo].[detActividades] ([idDetAct], [actividad], [matricula], [calificacion], [fechaEntrega]) VALUES (1, 3, N'1601F0062', 5, CAST(0x0000AAE300000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[detActividades] OFF
/****** Object:  ForeignKey [fk_estado]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[municipios]  WITH CHECK ADD  CONSTRAINT [fk_estado] FOREIGN KEY([Estado])
REFERENCES [dbo].[estados] ([idEstado])
GO
ALTER TABLE [dbo].[municipios] CHECK CONSTRAINT [fk_estado]
GO
/****** Object:  ForeignKey [fk_municipio]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[localidades]  WITH CHECK ADD  CONSTRAINT [fk_municipio] FOREIGN KEY([Municipio])
REFERENCES [dbo].[municipios] ([idMunicipio])
GO
ALTER TABLE [dbo].[localidades] CHECK CONSTRAINT [fk_municipio]
GO
/****** Object:  ForeignKey [fk_tipoLoc_localidaes]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[localidades]  WITH CHECK ADD  CONSTRAINT [fk_tipoLoc_localidaes] FOREIGN KEY([tipo])
REFERENCES [dbo].[tiposLocalidad] ([idTipoLoc])
GO
ALTER TABLE [dbo].[localidades] CHECK CONSTRAINT [fk_tipoLoc_localidaes]
GO
/****** Object:  ForeignKey [fk_localidad]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[calles]  WITH CHECK ADD  CONSTRAINT [fk_localidad] FOREIGN KEY([Localidad])
REFERENCES [dbo].[localidades] ([idLocalidad])
GO
ALTER TABLE [dbo].[calles] CHECK CONSTRAINT [fk_localidad]
GO
/****** Object:  ForeignKey [FK__personas__locali__68487DD7]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[personas]  WITH CHECK ADD FOREIGN KEY([localidades])
REFERENCES [dbo].[localidades] ([idLocalidad])
GO
/****** Object:  ForeignKey [fk_calle]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[personas]  WITH CHECK ADD  CONSTRAINT [fk_calle] FOREIGN KEY([idCalle])
REFERENCES [dbo].[calles] ([idCalle])
GO
ALTER TABLE [dbo].[personas] CHECK CONSTRAINT [fk_calle]
GO
/****** Object:  ForeignKey [fk_empleo]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD  CONSTRAINT [fk_empleo] FOREIGN KEY([idEmpleo])
REFERENCES [dbo].[empleos] ([idEmpleo])
GO
ALTER TABLE [dbo].[empleados] CHECK CONSTRAINT [fk_empleo]
GO
/****** Object:  ForeignKey [fk_persona]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD  CONSTRAINT [fk_persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[personas] ([idPersona])
GO
ALTER TABLE [dbo].[empleados] CHECK CONSTRAINT [fk_persona]
GO
/****** Object:  ForeignKey [fk_academia]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[profesores]  WITH CHECK ADD  CONSTRAINT [fk_academia] FOREIGN KEY([idAcademia])
REFERENCES [dbo].[academias] ([idAcademia])
GO
ALTER TABLE [dbo].[profesores] CHECK CONSTRAINT [fk_academia]
GO
/****** Object:  ForeignKey [fk_empleado]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[profesores]  WITH CHECK ADD  CONSTRAINT [fk_empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[empleados] ([idEmpleado])
GO
ALTER TABLE [dbo].[profesores] CHECK CONSTRAINT [fk_empleado]
GO
/****** Object:  ForeignKey [fk_coordinador]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[carreras]  WITH CHECK ADD  CONSTRAINT [fk_coordinador] FOREIGN KEY([coordinador])
REFERENCES [dbo].[empleados] ([idEmpleado])
GO
ALTER TABLE [dbo].[carreras] CHECK CONSTRAINT [fk_coordinador]
GO
/****** Object:  ForeignKey [fk_carrera_materia]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[materias]  WITH CHECK ADD  CONSTRAINT [fk_carrera_materia] FOREIGN KEY([carrera])
REFERENCES [dbo].[carreras] ([idCarrera])
GO
ALTER TABLE [dbo].[materias] CHECK CONSTRAINT [fk_carrera_materia]
GO
/****** Object:  ForeignKey [fk_carrera]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[especialidades]  WITH CHECK ADD  CONSTRAINT [fk_carrera] FOREIGN KEY([carrera])
REFERENCES [dbo].[carreras] ([idCarrera])
GO
ALTER TABLE [dbo].[especialidades] CHECK CONSTRAINT [fk_carrera]
GO
/****** Object:  ForeignKey [fk_carrera_alumno]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[alumnos]  WITH CHECK ADD  CONSTRAINT [fk_carrera_alumno] FOREIGN KEY([idCarrera])
REFERENCES [dbo].[carreras] ([idCarrera])
GO
ALTER TABLE [dbo].[alumnos] CHECK CONSTRAINT [fk_carrera_alumno]
GO
/****** Object:  ForeignKey [fk_especialidad_alumno]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[alumnos]  WITH CHECK ADD  CONSTRAINT [fk_especialidad_alumno] FOREIGN KEY([idEspecialidad])
REFERENCES [dbo].[especialidades] ([idEspecialidad])
GO
ALTER TABLE [dbo].[alumnos] CHECK CONSTRAINT [fk_especialidad_alumno]
GO
/****** Object:  ForeignKey [fk_persona_alumno]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[alumnos]  WITH CHECK ADD  CONSTRAINT [fk_persona_alumno] FOREIGN KEY([idPersona])
REFERENCES [dbo].[personas] ([idPersona])
GO
ALTER TABLE [dbo].[alumnos] CHECK CONSTRAINT [fk_persona_alumno]
GO
/****** Object:  ForeignKey [fk_tutor_alumno]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[alumnos]  WITH CHECK ADD  CONSTRAINT [fk_tutor_alumno] FOREIGN KEY([tutor])
REFERENCES [dbo].[profesores] ([idProfesor])
GO
ALTER TABLE [dbo].[alumnos] CHECK CONSTRAINT [fk_tutor_alumno]
GO
/****** Object:  ForeignKey [fk_materia_grupo]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[grupos]  WITH CHECK ADD  CONSTRAINT [fk_materia_grupo] FOREIGN KEY([materia])
REFERENCES [dbo].[materias] ([cveMateria])
GO
ALTER TABLE [dbo].[grupos] CHECK CONSTRAINT [fk_materia_grupo]
GO
/****** Object:  ForeignKey [fk_profesor_grupo]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[grupos]  WITH CHECK ADD  CONSTRAINT [fk_profesor_grupo] FOREIGN KEY([profesor])
REFERENCES [dbo].[profesores] ([idProfesor])
GO
ALTER TABLE [dbo].[grupos] CHECK CONSTRAINT [fk_profesor_grupo]
GO
/****** Object:  ForeignKey [fk_grupo_inasistencia]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[inasistencias]  WITH CHECK ADD  CONSTRAINT [fk_grupo_inasistencia] FOREIGN KEY([grupo])
REFERENCES [dbo].[grupos] ([cveGrupo])
GO
ALTER TABLE [dbo].[inasistencias] CHECK CONSTRAINT [fk_grupo_inasistencia]
GO
/****** Object:  ForeignKey [fk_matricula_inasistencia]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[inasistencias]  WITH CHECK ADD  CONSTRAINT [fk_matricula_inasistencia] FOREIGN KEY([matricula])
REFERENCES [dbo].[alumnos] ([matricula])
GO
ALTER TABLE [dbo].[inasistencias] CHECK CONSTRAINT [fk_matricula_inasistencia]
GO
/****** Object:  ForeignKey [fk_grupo_horario]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[horarios]  WITH CHECK ADD  CONSTRAINT [fk_grupo_horario] FOREIGN KEY([grupo])
REFERENCES [dbo].[grupos] ([cveGrupo])
GO
ALTER TABLE [dbo].[horarios] CHECK CONSTRAINT [fk_grupo_horario]
GO
/****** Object:  ForeignKey [fk_grupo_calificacion]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[calificaciones]  WITH CHECK ADD  CONSTRAINT [fk_grupo_calificacion] FOREIGN KEY([grupo])
REFERENCES [dbo].[grupos] ([cveGrupo])
GO
ALTER TABLE [dbo].[calificaciones] CHECK CONSTRAINT [fk_grupo_calificacion]
GO
/****** Object:  ForeignKey [fk_matriucla_calificacion]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[calificaciones]  WITH CHECK ADD  CONSTRAINT [fk_matriucla_calificacion] FOREIGN KEY([matricula])
REFERENCES [dbo].[alumnos] ([matricula])
GO
ALTER TABLE [dbo].[calificaciones] CHECK CONSTRAINT [fk_matriucla_calificacion]
GO
/****** Object:  ForeignKey [fk_grupo_actividad]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[actividades]  WITH CHECK ADD  CONSTRAINT [fk_grupo_actividad] FOREIGN KEY([grupo])
REFERENCES [dbo].[grupos] ([cveGrupo])
GO
ALTER TABLE [dbo].[actividades] CHECK CONSTRAINT [fk_grupo_actividad]
GO
/****** Object:  ForeignKey [fk_grupo_detgpo]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[detGrupos]  WITH CHECK ADD  CONSTRAINT [fk_grupo_detgpo] FOREIGN KEY([cveGrupo])
REFERENCES [dbo].[grupos] ([cveGrupo])
GO
ALTER TABLE [dbo].[detGrupos] CHECK CONSTRAINT [fk_grupo_detgpo]
GO
/****** Object:  ForeignKey [fk_matricula_detgpo]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[detGrupos]  WITH CHECK ADD  CONSTRAINT [fk_matricula_detgpo] FOREIGN KEY([matricula])
REFERENCES [dbo].[alumnos] ([matricula])
GO
ALTER TABLE [dbo].[detGrupos] CHECK CONSTRAINT [fk_matricula_detgpo]
GO
/****** Object:  ForeignKey [fk_actividad_detact]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[detActividades]  WITH CHECK ADD  CONSTRAINT [fk_actividad_detact] FOREIGN KEY([actividad])
REFERENCES [dbo].[actividades] ([idActividad])
GO
ALTER TABLE [dbo].[detActividades] CHECK CONSTRAINT [fk_actividad_detact]
GO
/****** Object:  ForeignKey [fk_matricula_detact]    Script Date: 10/03/2019 16:56:30 ******/
ALTER TABLE [dbo].[detActividades]  WITH CHECK ADD  CONSTRAINT [fk_matricula_detact] FOREIGN KEY([matricula])
REFERENCES [dbo].[alumnos] ([matricula])
GO
ALTER TABLE [dbo].[detActividades] CHECK CONSTRAINT [fk_matricula_detact]
GO

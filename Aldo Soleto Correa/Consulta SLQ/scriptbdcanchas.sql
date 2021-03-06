USE [master]
GO
/****** Object:  Database [DBCancha]    Script Date: 30/04/2019 17:56:12 ******/
CREATE DATABASE [DBCancha]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBCancha', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DBCancha.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBCancha_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DBCancha_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBCancha] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBCancha].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBCancha] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBCancha] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBCancha] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBCancha] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBCancha] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBCancha] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBCancha] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBCancha] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBCancha] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBCancha] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBCancha] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBCancha] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBCancha] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBCancha] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBCancha] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBCancha] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBCancha] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBCancha] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBCancha] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBCancha] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBCancha] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBCancha] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBCancha] SET RECOVERY FULL 
GO
ALTER DATABASE [DBCancha] SET  MULTI_USER 
GO
ALTER DATABASE [DBCancha] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBCancha] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBCancha] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBCancha] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DBCancha] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DBCancha]
GO
/****** Object:  Table [dbo].[tbCanchas]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCanchas](
	[idCanchas] [int] NOT NULL,
	[Codigo] [nvarchar](5) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[Tipo] [nvarchar](10) NOT NULL,
	[Capacidad] [nvarchar](5) NOT NULL,
	[Largo] [int] NOT NULL,
	[Ancho] [int] NOT NULL,
	[PrecioDia] [int] NOT NULL,
	[PrecioNoche] [int] NOT NULL,
	[UG] [geography] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCanchas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbCliente]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCliente](
	[idCliente] [int] NOT NULL,
	[Nit] [nvarchar](15) NOT NULL,
	[RazonSocial] [nvarchar](30) NOT NULL,
	[Puntos] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbCtaUsuario]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCtaUsuario](
	[idCtaUsuario] [int] NOT NULL,
	[fkPersona] [int] NOT NULL,
	[FechaRegistro] [date] NOT NULL,
	[Estado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCtaUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbDetallePago]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDetallePago](
	[idDetallePago] [int] NOT NULL,
	[TipoServicio] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDetallePago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbDia]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDia](
	[idDia] [int] NOT NULL,
	[Nombre] [nvarchar](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbHora]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbHora](
	[idHora] [int] NOT NULL,
	[Apertura] [time](7) NOT NULL,
	[Cierre] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idHora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbHorarioAtencion]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbHorarioAtencion](
	[idHorarioAte] [int] NOT NULL,
	[Estado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idHorarioAte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbMensje]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbMensje](
	[idMensaje] [int] NOT NULL,
	[Contenido] [nvarchar](100) NOT NULL,
	[Respuesta] [nvarchar](100) NOT NULL,
	[FechaRecepcion] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idMensaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbPago]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPago](
	[idPago] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Total] [decimal](2, 2) NOT NULL,
	[Descuento] [decimal](2, 2) NOT NULL,
	[TotalPago] [decimal](2, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbPersona]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPersona](
	[idPersona] [int] NOT NULL,
	[Nombre] [nvarchar](25) NOT NULL,
	[Apellido] [nvarchar](25) NOT NULL,
	[Sexo] [int] NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Telefono] [nvarchar](10) NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbPersonal]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPersonal](
	[idPersonal] [int] NOT NULL,
	[Cargo] [nvarchar](23) NOT NULL,
	[Horario] [int] NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPersonal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbPoliDeportivo]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPoliDeportivo](
	[idPoliDeportivo] [int] NOT NULL,
	[Nombre] [nvarchar](25) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[UG] [geography] NOT NULL,
	[Telefono] [nvarchar](10) NOT NULL,
	[Abierto] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPoliDeportivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbReserva]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbReserva](
	[idReserva] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Inicio] [time](7) NOT NULL,
	[Final] [time](7) NOT NULL,
	[Estado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbRol]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbRol](
	[idRol] [int] NOT NULL,
	[TipoUsuario] [nvarchar](23) NOT NULL,
	[Permisos] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbServicios]    Script Date: 30/04/2019 17:56:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbServicios](
	[idServicios] [int] NOT NULL,
	[Detalle] [nvarchar](25) NOT NULL,
	[Precio] [decimal](2, 2) NOT NULL,
	[Disponibilidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idServicios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tbCanchas]  WITH CHECK ADD  CONSTRAINT [FK_tbCanchas_tbPoliDeportivo] FOREIGN KEY([idCanchas])
REFERENCES [dbo].[tbPoliDeportivo] ([idPoliDeportivo])
GO
ALTER TABLE [dbo].[tbCanchas] CHECK CONSTRAINT [FK_tbCanchas_tbPoliDeportivo]
GO
ALTER TABLE [dbo].[tbCliente]  WITH CHECK ADD  CONSTRAINT [FK_tbCliente_tbMensje] FOREIGN KEY([idCliente])
REFERENCES [dbo].[tbMensje] ([idMensaje])
GO
ALTER TABLE [dbo].[tbCliente] CHECK CONSTRAINT [FK_tbCliente_tbMensje]
GO
ALTER TABLE [dbo].[tbCliente]  WITH CHECK ADD  CONSTRAINT [FK_tbCliente_tbPago] FOREIGN KEY([idCliente])
REFERENCES [dbo].[tbPago] ([idPago])
GO
ALTER TABLE [dbo].[tbCliente] CHECK CONSTRAINT [FK_tbCliente_tbPago]
GO
ALTER TABLE [dbo].[tbCtaUsuario]  WITH CHECK ADD  CONSTRAINT [FK_tbCtaUsuario_tbPersona] FOREIGN KEY([idCtaUsuario])
REFERENCES [dbo].[tbPersona] ([idPersona])
GO
ALTER TABLE [dbo].[tbCtaUsuario] CHECK CONSTRAINT [FK_tbCtaUsuario_tbPersona]
GO
ALTER TABLE [dbo].[tbHora]  WITH CHECK ADD  CONSTRAINT [FK_tbHora_tbHorarioAtencion] FOREIGN KEY([idHora])
REFERENCES [dbo].[tbHorarioAtencion] ([idHorarioAte])
GO
ALTER TABLE [dbo].[tbHora] CHECK CONSTRAINT [FK_tbHora_tbHorarioAtencion]
GO
ALTER TABLE [dbo].[tbHorarioAtencion]  WITH CHECK ADD  CONSTRAINT [FK_tbHorarioAtencion_tbDia] FOREIGN KEY([idHorarioAte])
REFERENCES [dbo].[tbDia] ([idDia])
GO
ALTER TABLE [dbo].[tbHorarioAtencion] CHECK CONSTRAINT [FK_tbHorarioAtencion_tbDia]
GO
ALTER TABLE [dbo].[tbPago]  WITH CHECK ADD  CONSTRAINT [FK_tbPago_tbDetallePago] FOREIGN KEY([idPago])
REFERENCES [dbo].[tbDetallePago] ([idDetallePago])
GO
ALTER TABLE [dbo].[tbPago] CHECK CONSTRAINT [FK_tbPago_tbDetallePago]
GO
ALTER TABLE [dbo].[tbPersona]  WITH CHECK ADD  CONSTRAINT [FK_tbPersona_tbCliente] FOREIGN KEY([idPersona])
REFERENCES [dbo].[tbCliente] ([idCliente])
GO
ALTER TABLE [dbo].[tbPersona] CHECK CONSTRAINT [FK_tbPersona_tbCliente]
GO
ALTER TABLE [dbo].[tbPersona]  WITH CHECK ADD  CONSTRAINT [FK_tbPersona_tbPersonal] FOREIGN KEY([idPersona])
REFERENCES [dbo].[tbPersonal] ([idPersonal])
GO
ALTER TABLE [dbo].[tbPersona] CHECK CONSTRAINT [FK_tbPersona_tbPersonal]
GO
ALTER TABLE [dbo].[tbPoliDeportivo]  WITH CHECK ADD  CONSTRAINT [FK_tbPoliDeportivo_tbHorarioAtencion] FOREIGN KEY([idPoliDeportivo])
REFERENCES [dbo].[tbHorarioAtencion] ([idHorarioAte])
GO
ALTER TABLE [dbo].[tbPoliDeportivo] CHECK CONSTRAINT [FK_tbPoliDeportivo_tbHorarioAtencion]
GO
ALTER TABLE [dbo].[tbReserva]  WITH CHECK ADD  CONSTRAINT [FK_tbReserva_tbCanchas] FOREIGN KEY([idReserva])
REFERENCES [dbo].[tbCanchas] ([idCanchas])
GO
ALTER TABLE [dbo].[tbReserva] CHECK CONSTRAINT [FK_tbReserva_tbCanchas]
GO
ALTER TABLE [dbo].[tbRol]  WITH CHECK ADD  CONSTRAINT [FK_tbRol_tbCtaUsuario] FOREIGN KEY([idRol])
REFERENCES [dbo].[tbCtaUsuario] ([idCtaUsuario])
GO
ALTER TABLE [dbo].[tbRol] CHECK CONSTRAINT [FK_tbRol_tbCtaUsuario]
GO
ALTER TABLE [dbo].[tbServicios]  WITH CHECK ADD  CONSTRAINT [FK_tbServicios_tbDetallePago] FOREIGN KEY([idServicios])
REFERENCES [dbo].[tbDetallePago] ([idDetallePago])
GO
ALTER TABLE [dbo].[tbServicios] CHECK CONSTRAINT [FK_tbServicios_tbDetallePago]
GO
USE [master]
GO
ALTER DATABASE [DBCancha] SET  READ_WRITE 
GO

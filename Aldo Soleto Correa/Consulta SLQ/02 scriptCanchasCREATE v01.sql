USE MASTER;
GO

DROP DATABASE bdCancha;
GO

CREATE DATABASE 
ON 
(
	NAME = Cancha_dat,
    FILENAME = 'D:\BaseDatosSQL\dbMedidor_dat.mdf'
)
LOG ON
(
	NAME = Cancha_log,
    FILENAME = 'D:\BaseDatosSQL\dbMedidor_log.ldf'
)
GO

CREATE DATABASE DBCancha

USE DBCancha;



CREATE TABLE tbPersona
(
	idPersona INT PRIMARY KEY NOT NULL,
	Nombre NVARCHAR(25) NOT NULL,
	Apellido NVARCHAR(25) NOT NULL,
	Sexo INT NOT NULL,
	FechaNacimiento DATE NOT NULL,
	Telefono NVARCHAR(10)NOT NULL,
	Usuario NVARCHAR(50) NOT NULL,
	Contraseņa NVARCHAR(15) NOT NULL,
)
GO

CREATE TABLE tbCtaUsuario
(
	idCtaUsuario INT PRIMARY KEY NOT NULL,
	fkPersona INT NOT NULL,	
	FechaRegistro DATE NOT NULL,
	Estado int NOT NULL,
)
GO

CREATE TABLE tbRol
(
	idRol INT PRIMARY KEY NOT NULL,
	TipoUsuario NVARCHAR(23) NOT NULL,
	Permisos INT NOT NULL,	
)
GO

CREATE TABLE tbPersonal
(
	idPersonal INT PRIMARY KEY NOT NULL,
	Cargo NVARCHAR(23) NOT NULL,
	Horario INT NOT NULL,
	Direccion NVARCHAR(50) NOT NULL,
)
GO

CREATE TABLE tbCliente
(
	idCliente INT PRIMARY KEY NOT NULL,
	Nit NVARCHAR(15) NOT NULL,
	RazonSocial NVARCHAR(30) NOT NULL,
	Puntos INT NOT NULL,
)
GO

CREATE TABLE tbPago
(
	idPago INT PRIMARY KEY NOT NULL,
	Fecha DATE NOT NULL,
	Total DECIMAL(2,2) NOT NULL,
	Descuento DECIMAL(2,2) NOT NULL,
	TotalPago DECIMAL(2,2) NOT NULL,
)
GO

CREATE TABLE tbMensje
(
	idMensaje INT PRIMARY KEY NOT NULL,
	Contenido NVARCHAR(100) NOT NULL,
	Respuesta NVARCHAR(100) NOT NULL,
	FechaRecepcion NVARCHAR(50) NOT NULL,
)
GO

CREATE TABLE tbDetallePago
(
	idDetallePago INT PRIMARY KEY NOT NULL,
	TipoServicio int NOT NULL,
	Cantidad int NOT NULL,
)
GO
CREATE TABLE tbServicios
(
	idServicios INT PRIMARY KEY NOT NULL,
	Detalle NVARCHAR(25) NOT NULL,
	Precio DECIMAL(2,2) NOT NULL,
	Disponibilidad int NOT NULL,
)
GO

CREATE TABLE tbHorarioAtencion
(
	idHorarioAte INT PRIMARY KEY NOT NULL,
	Estado INT NOT NULL,
)

CREATE TABLE tbHora
(
	idHora INT PRIMARY KEY NOT NULL,
	Apertura TIME NOT NULL,
	Cierre TIME NOT NULL,
)
CREATE TABLE tbDia
(
	idDia INT PRIMARY KEY NOT NULL,
	Nombre NVARCHAR NOT NULL,
)

CREATE TABLE tbPoliDeportivo
(
	idPoliDeportivo INT PRIMARY KEY NOT NULL,
	Nombre NVARCHAR(25) NOT NULL,
	Direccion NVARCHAR(50) NOT NULL,
	UG GEOGRAPHY NOT NULL,
	Telefono NVARCHAR(10) NOT NULL,
	Abierto BIT NOT NULL,
)

CREATE TABLE tbCanchas
(
	idCanchas INT PRIMARY KEY NOT NULL,
	Codigo NVARCHAR(5) NOT NULL,
	Nombre NVARCHAR(30) NOT NULL,
	Tipo NVARCHAR(10) NOT NULL,
	Capacidad NVARCHAR(5) NOT NULL,
	Largo INT NOT NULL,
	Ancho INT NOT NULL,
	PrecioDia INT NOT NULL,
	PrecioNoche INT NOT NULL,
	UG GEOGRAPHY NOT NULL,
)

CREATE TABLE tbReserva
(
	idReserva INT PRIMARY KEY NOT NULL,
	Fecha DATE NOT NULL,
	Inicio TIME NOT NULL,
	Final TIME NOT NULL,
	Estado INT NOT NULL,
)




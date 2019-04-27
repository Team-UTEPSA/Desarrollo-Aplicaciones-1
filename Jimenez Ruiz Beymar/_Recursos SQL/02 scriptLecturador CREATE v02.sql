USE MASTER;
GO

DROP DATABASE dbMedidor;
GO

CREATE DATABASE dbMedidor
ON 
(
	NAME = Medidor_dat,
    FILENAME = 'D:\BaseDatosSQL\dbMedidor_dat.mdf'
)
LOG ON
(
	NAME = Medidor_log,
    FILENAME = 'D:\BaseDatosSQL\dbMedidor_log.ldf'
)
GO

USE dbMedidor;
GO

CREATE TABLE tblPersona
(
	idPersona INT PRIMARY KEY NOT NULL,
	Apellido NVARCHAR(25) NOT NULL,
	Nombre NVARCHAR(20) NOT NULL,
	CI NVARCHAR(12) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	Sexo BIT NOT NULL,
	Direccion NVARCHAR(50) NOT NULL,
	Telefono NVARCHAR(12),
	Email NVARCHAR(50)
)
GO

CREATE TABLE tblLecturador
(
	idLecturador INT PRIMARY KEY NOT NULL,
	fkPersona INT NOT NULL,	
	FechaIngreso DATE NOT NULL,
	Turno NVARCHAR (6) NOT NULL,
	Usuario NVARCHAR (15) NOT NULL,
	Contrasenia NVARCHAR (15) NOT NULL,
	FOREIGN KEY (fkPersona) REFERENCES tblPersona (idPersona)
)
GO

CREATE TABLE tblDomicilio
(
	idDomicilio INT PRIMARY KEY NOT NULL,
	UV INT NOT NULL,
	MZN INT NOT NULL,
	Direccion NVARCHAR(50) NOT NULL,
	Numero INT,
	Zona INT NOT NULL
)
GO

CREATE TABLE tblCooperativa
(
	idCooperativa INT PRIMARY KEY NOT NULL,
	Nombre NVARCHAR(20) NOT NULL,
	Direccion NVARCHAR(50) NOT NULL,
	Telefono NVARCHAR(12) NOT NULL,
	Email NVARCHAR(60) NOT NULL,
	Servicio NVARCHAR(5) NOT NULL
)
GO

CREATE TABLE tblCategoria
(
	idCategoria INT PRIMARY KEY NOT NULL,
	Nombre NVARCHAR(12) NOT NULL,
	UnidadMedida NVARCHAR(3) NOT NULL,
	Precio MONEY NOT NULL,
	fkCooperativa INT NOT NULL,
	FOREIGN KEY (fkCooperativa) REFERENCES tblCooperativa (idCooperativa) 
)
GO

CREATE TABLE tblMedidor
(
	idMedidor INT PRIMARY KEY NOT NULL,
	CodigoFabrica NVARCHAR(15) NOT NULL,
	Fabricante NVARCHAR(20) NOT NULL,
	Tipo NVARCHAR(5) NOT NULL,
	Estado  NVARCHAR(10) NOT NULL,
	fkCategoria INT NOT NULL,
	FOREIGN KEY (fkCategoria) REFERENCES tblCategoria (idCategoria)
)
GO

CREATE TABLE tblContrato
(
	idContrato INT PRIMARY KEY NOT NULL,
	NumeroContrato INT NOT NULL,
	FechaInicio DATE NOT NULL,
	FechaFin DATE,
	Estado NVARCHAR(10) NOT NULL,
	fkPersona INT NOT NULL,
	fkCooperativa INT NOT NULL,
	fkMedidor INT NOT NULL,
	fkDomicilio INT NOT NULL,
	FOREIGN KEY (fkPersona) REFERENCES tblPersona (idPersona),
	FOREIGN KEY (fkCooperativa) REFERENCES tblCooperativa (idCooperativa),
	FOREIGN KEY (fkMedidor) REFERENCES tblMedidor (idMedidor),
	FOREIGN KEY (fkDomicilio) REFERENCES tblDomicilio (idDomicilio)
)
GO

CREATE TABLE tblLectura
(
	idLectura INT PRIMARY KEY NOT NULL,
	Fecha DATE NOT NULL,
	Hora TIME NOT NULL,
	PeriodoMes INT NOT NULL,
	PeriodoAnio INT NOT NULL,
	Marcacion REAL NOT NULL,
	Consumo REAL NOT NULL,
	Precio MONEY NOT NULL,
	fkLecturador INT NOT NULL,
	fkMedidor INT NOT NULL,
	FOREIGN KEY (fkLecturador) REFERENCES tblLecturador (idLecturador),
	FOREIGN KEY (fkMedidor) REFERENCES tblMedidor (idMedidor)
)









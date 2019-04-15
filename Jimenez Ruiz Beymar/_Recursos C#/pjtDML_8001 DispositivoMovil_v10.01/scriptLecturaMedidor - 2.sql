DROP DATABASE dbLecturaMedidor

DROP TABLE tblCronograma
DROP TABLE tblRegistroLectura
DROP TABLE tblMedidor
DROP TABLE tblCategoria
DROP TABLE tblZona
DROP TABLE tblSocio
DROP TABLE tblLecturador



CREATE DATABASE dbLecturaMedidor
ON 
( NAME = LecturaMedidor_dat,
    FILENAME = 'D:\BaseDatosSQL\dbLecturaMedidor_dat.mdf',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 5 )
LOG ON
( NAME = LecturaMedidor_log,
    FILENAME = 'D:\BaseDatosSQL\dbLecturaMedidor_log.ldf',
    SIZE = 5MB,
    MAXSIZE = 25MB,
    FILEGROWTH = 5MB 
)
GO

USE dbLecturaMedidor
GO

CREATE TABLE tblLecturador
(
  Id INT PRIMARY KEY NOT NULL,
  Nombre NVARCHAR(20) NOT NULL,
  Apellido NVARCHAR(30) NOT NULL,
  Telefono NVARCHAR(15)
)
GO

CREATE TABLE tblSocio
(
  Id INT PRIMARY KEY NOT NULL,
  Nombre NVARCHAR(20) NOT NULL,
  Apellido NVARCHAR(30) NOT NULL,
  Telefono NVARCHAR(15)
)
GO

CREATE TABLE tblPeriodo
(
  Id INT PRIMARY KEY NOT NULL,
  Nombre NVARCHAR(20) NOT NULL
)
GO

CREATE TABLE tblCategoria
(
  Id INT PRIMARY KEY NOT NULL,
  Servicio NVARCHAR(10) NOT NULL,
  Nombre NVARCHAR(15) NOT NULL,
  Unidad NVARCHAR(10) NOT NULL,
  Precio MONEY NOT NULL
)
GO

CREATE TABLE tblZona
(
  Id INT PRIMARY KEY NOT NULL,
  Nombre NVARCHAR(20) NOT NULL,
  IdLecturador INT NOT NULL,
  FOREIGN KEY(IdLecturador) REFERENCES tblLecturador(Id)
)
GO

CREATE TABLE tblMedidor
(
  Id INT PRIMARY KEY NOT NULL,
  Direccion NVARCHAR(30) NOT NULL,
  IdSocio INT NOT NULL,
  IdZona INT NOT NULL,
  IdCategoria INT NOT NULL,
  FOREIGN KEY(IdSocio) REFERENCES tblSocio(Id),
  FOREIGN KEY(IdZona) REFERENCES tblZona(Id),
  FOREIGN KEY(IdCategoria) REFERENCES tblCategoria(Id)
)
GO

CREATE TABLE tblRegistroLectura
(
  Id INT PRIMARY KEY NOT NULL,
  Fecha DATETIME NOT NULL,
  Lectura INT NOT NULL,
  Enviado BIT,
  IdLecturador INT NOT NULL,
  IdPeriodo INT NOT NULL,
  IdMedidor INT NOT NULL,
  FOREIGN KEY(IdLecturador) REFERENCES tblLecturador(Id),
  FOREIGN KEY(IdPeriodo) REFERENCES tblPeriodo(Id),
  FOREIGN KEY(IdMedidor) REFERENCES tblMedidor(Id)
)
GO














USE MASTER;
GO

DROP DATABASE bdCancha
GO

CREATE DATABASE dbCancha
ON 
(
	NAME = Cancha_dat,
    FILENAME = 'D:\BaseDatosSQL\dbCancha_dat.mdf'
)
LOG ON
(
	NAME = Cancha_log,
    FILENAME = 'D:\BaseDatosSQL\dbCancha_log.ldf'
)
GO


USE dbCancha;


CREATE TABLE tblPersona
(
	idPersona INT PRIMARY KEY NOT NULL,
	Nombre NVARCHAR(25) NOT NULL,
	Apellido NVARCHAR(25) NOT NULL,
	Sexo INT NOT NULL,
	FechaNacimiento DATE NOT NULL,
	Telefono NVARCHAR(10)NOT NULL,
	Usuario NVARCHAR(50) NOT NULL,
	Contraseña NVARCHAR(15) NOT NULL,
)
GO


CREATE TABLE tblRol
(
	idRol INT PRIMARY KEY NOT NULL,
	TipoUsuario NVARCHAR(23) NOT NULL,
	Permisos INT NOT NULL	
)
GO


CREATE TABLE tblCuentaUsuario
(
	idCuentaUsuario INT PRIMARY KEY NOT NULL,
	fkPersona INT NOT NULL,
	fkRol INT NOT NULL,
	FechaRegistro DATE NOT NULL,
	Activado BIT NOT NULL,
	Estado INT NOT NULL,
	FOREIGN KEY (fkPersona) REFERENCES tblPersona(idPersona),
	FOREIGN KEY (fkRol) REFERENCES tblRol(idRol)
)
GO


CREATE TABLE tblPersonal
(
	idPersonal INT PRIMARY KEY NOT NULL,
	fkPersona INT NOT NULL,
	Cargo NVARCHAR(23) NOT NULL,
	Horario INT NOT NULL,
	Direccion NVARCHAR(50) NOT NULL,
	FOREIGN KEY (fkPersona) REFERENCES tblPersona(idPersona)
)
GO


CREATE TABLE tblCliente
(
	idCliente INT PRIMARY KEY NOT NULL,
	fkPersona INT NOT NULL,
	NIT NVARCHAR(15) NOT NULL,
	RazonSocial NVARCHAR(30) NOT NULL,
	Puntos INT NOT NULL,
	FOREIGN KEY (fkPersona) REFERENCES tblPersona(idPersona)
)
GO


CREATE TABLE tblMensajes
(
	idMensaje INT PRIMARY KEY NOT NULL,
	fkCliente INT NOT NULL,
	Mensaje NVARCHAR(100) NOT NULL,
	Respuesta NVARCHAR(100) NOT NULL,
	FechaRecepcion DATE NOT NULL,
	Estado INT NOT NULL,
	FOREIGN KEY (fkCliente) REFERENCES tblCliente(idCliente)
)
GO


CREATE TABLE tblPago
(
	idPago INT PRIMARY KEY NOT NULL,
	fkCliente INT NOT NULL,
	Fecha DATE NOT NULL,
	Total DECIMAL(2,2) NOT NULL,
	Descuento DECIMAL(2,2) NOT NULL,
	TotalPagado DECIMAL(2,2) NOT NULL,
	FOREIGN KEY (fkCliente) REFERENCES tblCliente(idCliente)
)
GO


CREATE TABLE tblServicios
(
	idServicios INT PRIMARY KEY NOT NULL,
	Detalle NVARCHAR(25) NOT NULL,
	Precio DECIMAL(2,2) NOT NULL,
	Disponibilidad INT NOT NULL,
)
GO


CREATE TABLE tblDetallePago
(
	idDetallePago INT PRIMARY KEY NOT NULL,
	fkPago INT NOT NULL,
	fkServicios INT NOT NULL,
	TipoServicio INT NOT NULL,
	Cantidad INT NOT NULL,
	FOREIGN KEY (fkPago) REFERENCES tblPago(idPago),
	FOREIGN KEY (fkServicios) REFERENCES tblServicios(idServicios)
)
GO


CREATE TABLE tblPoliDeportivo
(
	idPoliDeportivo INT PRIMARY KEY NOT NULL,
	Nombre NVARCHAR(25) NOT NULL,
	Direccion NVARCHAR(50) NOT NULL,
	Ubicacion GEOGRAPHY NOT NULL,
	Telefono NVARCHAR(10) NOT NULL,
	Abierto BIT NOT NULL,
)
GO


CREATE TABLE tblDia
(
	idDia INT PRIMARY KEY NOT NULL,
	Nombre NVARCHAR NOT NULL,
)
GO


CREATE TABLE tblHora
(
	idHora INT PRIMARY KEY NOT NULL,
	Apertura TIME NOT NULL,
	Cierre TIME NOT NULL,
)
GO


CREATE TABLE tblHorarioAtencion
(
	idHorarioAtencion INT PRIMARY KEY NOT NULL,
	fkPoliDeportivo INT NOT NULL,
	fkDia INT NOT NULL,
	fkHora INT NOT NULL,
	Estado INT NOT NULL,
	FOREIGN KEY (fkPoliDeportivo) REFERENCES tblPoliDeportivo(idPoliDeportivo),
	FOREIGN KEY (fkDia) REFERENCES tblDia(idDia),
	FOREIGN KEY (fkHora) REFERENCES tblHora(idHora)
)
GO


CREATE TABLE tblCancha
(
	idCancha INT PRIMARY KEY NOT NULL,
	fkPoliDeportivo INT NOT NULL,
	Codigo NVARCHAR(5) NOT NULL,
	Nombre NVARCHAR(30) NOT NULL,
	Tipo NVARCHAR(10) NOT NULL,
	Capacidad NVARCHAR(5) NOT NULL,
	Largo INT NOT NULL,
	Ancho INT NOT NULL,
	PrecioDia INT NOT NULL,
	PrecioNoche INT NOT NULL,
	Ubicacion GEOGRAPHY NOT NULL,
	FOREIGN KEY (fkPoliDeportivo) REFERENCES tblPoliDeportivo(idPoliDeportivo)
)
GO


CREATE TABLE tblReserva
(
	idReserva INT PRIMARY KEY NOT NULL,
	fkCancha INT NOT NULL,
	Fecha DATE NOT NULL,
	Inicio TIME NOT NULL,
	Final TIME NOT NULL,
	Estado INT NOT NULL,
	FOREIGN KEY (fkCancha) REFERENCES tblCancha(idCancha)
)
GO


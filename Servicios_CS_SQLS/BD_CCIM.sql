CREATE DATABASE CCIM
USE CCIM

CREATE SCHEMA Persona
CREATE SCHEMA Servicio

CREATE TABLE Persona.Empleado
(
	idUsuario BIGINT IDENTITY(1,1) NOT NULL,
	nombres VARCHAR(100) NOT NULL, 
	apellidoPaterno VARCHAR(100) NOT NULL,
	apellidoMaterno VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL,
	tipo VARCHAR(50) NOT NULL,
	genero BIT NOT NULL,
	fechaNacimiento DATE NOT NULL,

	CONSTRAINT PK_Empleado PRIMARY KEY (idUsuario)
)

CREATE TABLE Persona.Cliente
(
	idCliente BIGINT IDENTITY(1,1) NOT NULL,
	nombres VARCHAR(100) NOT NULL,
	apellidoPaterno VARCHAR(100) NOT NULL,
	apellidoMaterno VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL,
	telefono VARCHAR(50) NOT NULL,

		CONSTRAINT PK_Cliente PRIMARY KEY (idCliente)
)

CREATE TABLE Persona.ClienteFacultad
(
	idCliente BIGINT IDENTITY(1,1) NOT NULL,
	carrera VARCHAR(50) NOT NULL,
	asignatura VARCHAR(50) NOT NULL,
	
	CONSTRAINT FK_Cliente FOREIGN KEY (idCliente) REFERENCES Persona.Cliente(idCliente)
)

CREATE TABLE Persona.ClienteUASLP
(
	idCliente BIGINT IDENTITY(1,1) NOT NULL,
	departamento VARCHAR(50) NOT NULL,
	asignatura VARCHAR(50) NOT NULL,
	
	CONSTRAINT FK_Cliente2 FOREIGN KEY (idCliente) REFERENCES Persona.Cliente(idCliente)
)

DROP TABLE Persona.ClienteUASLP
CREATE TABLE Persona.ClienteExterno
(
	idCliente BIGINT IDENTITY(1,1) NOT NULL,
	empresa VARCHAR(100) NOT NULL,
	rfc VARCHAR(50) NOT NULL,
	
	CONSTRAINT FK_Cliente3 FOREIGN KEY (idCliente) REFERENCES Persona.Cliente(idCliente)
)

CREATE TABLE Servicio.ServicioActividad
(
	idServicio BIGINT IDENTITY(1,1) NOT NULL,
	idCliente BIGINT NOT NULL,
	idUsuario BIGINT NOT NULL,
	costoFinal MONEY NOT NULL,
	autorizacion BIT NOT NULL,
	descripcion VARCHAR(200) NOT NULL,
	fechaCaptura DATE NOT NULL,
	fechaProgramada DATE NOT NULL,
	fechaPropuesta DATE NOT NULL,
	estado VARCHAR(50) NOT NULL,
	tipoServicio VARCHAR(50) NOT NULL,
	total MONEY NOT NULL,

	CONSTRAINT PK_ServicioActividad PRIMARY KEY (idServicio),
	CONSTRAINT FK_Cliente FOREIGN KEY (idCliente) REFERENCES Persona.Cliente(idCliente),
	CONSTRAINT FK_Empleado FOREIGN KEY (idUsuario) REFERENCES Persona.Empleado(idUsuario)
)

CREATE TABLE Servicio.Material
(
	idMaterial BIGINT IDENTITY(1,1) NOT NULL,
	material VARCHAR(100) NOT NULL,
	costo MONEY NOT NULL,

	CONSTRAINT PK_Material PRIMARY KEY (idMaterial)
	
)

CREATE TABLE Servicio.DetalleMaterial
(
	idMaterial BIGINT NOT NULL,
	idServicio BIGINT NOT NULL,
	subtotal Money NOT NULL,
	cantidad INT NOT NULL,

	CONSTRAINT FK_Material FOREIGN KEY (idMaterial) REFERENCES Servicio.Material(idMaterial),
	CONSTRAINT FK_ServicioActividad FOREIGN KEY (idServicio) REFERENCES Servicio.ServicioActividad(idServicio)
)




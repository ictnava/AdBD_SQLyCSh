CREATE DATABASE CCIM
USE CCIM

CREATE SCHEMA Persona
CREATE SCHEMA Servicio

CREATE TABLE Persona.Empleado
(
	idEmpleado BIGINT IDENTITY(1,1) NOT NULL,
	nombres VARCHAR(100) NOT NULL, 
	apellidoPaterno VARCHAR(100) NOT NULL,
	apellidoMaterno VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL,
	tipo VARCHAR(50) NOT NULL,
	genero VARCHAR(10) NOT NULL,
	fechaNacimiento DATE NOT NULL,

	CONSTRAINT U_Email1 UNIQUE(email),
	CONSTRAINT PK_Empleado PRIMARY KEY (idEmpleado)
)

CREATE TABLE Persona.Cliente
(
	idCliente BIGINT IDENTITY(1,1) NOT NULL,
	nombres VARCHAR(100) NOT NULL,
	apellidoPaterno VARCHAR(100) NOT NULL,
	apellidoMaterno VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL,
	telefono VARCHAR(50) NOT NULL,
	tipo VARCHAR(20) NOT NULL
	
	CONSTRAINT U_Email2 UNIQUE(email),
	CONSTRAINT PK_Cliente PRIMARY KEY (idCliente)
)

CREATE TABLE Persona.ClienteFacultad
(
	idCliente BIGINT NOT NULL,
	carrera VARCHAR(50) NOT NULL,
	asignatura VARCHAR(50) NOT NULL,
	
	CONSTRAINT FK_Cliente FOREIGN KEY (idCliente) REFERENCES Persona.Cliente(idCliente)
)

CREATE TABLE Persona.ClienteUASLP
(
	idCliente BIGINT NOT NULL,
	departamento VARCHAR(50) NOT NULL,
	asignatura VARCHAR(50) NOT NULL,
	
	CONSTRAINT FK_Cliente2 FOREIGN KEY (idCliente) REFERENCES Persona.Cliente(idCliente)
)

CREATE TABLE Persona.ClienteExterno
(
	idCliente BIGINT NOT NULL,
	empresa VARCHAR(100) NOT NULL,
	rfc VARCHAR(15) NOT NULL,
	
	CONSTRAINT FK_Cliente3 FOREIGN KEY (idCliente) REFERENCES Persona.Cliente(idCliente)
)

CREATE TABLE Servicio.ServicioActividad
(
	idServicio BIGINT IDENTITY(1,1) NOT NULL,
	idCliente BIGINT NOT NULL,
	idEmpleado BIGINT NOT NULL,
	costoFinal MONEY NOT NULL,
	autorizacion BIT NOT NULL,
	descripcion VARCHAR(200) NOT NULL,
	fechaCaptura DATE NOT NULL,
	fechaProgramada DATE NOT NULL,
	fechaPropuesta DATE NOT NULL,
	estado VARCHAR(50) NOT NULL,
	tipoServicio VARCHAR(50) NOT NULL

	CONSTRAINT PK_ServicioActividad PRIMARY KEY (idServicio),
	CONSTRAINT FK_Cliente FOREIGN KEY (idCliente) REFERENCES Persona.Cliente(idCliente),
	CONSTRAINT FK_Empleado FOREIGN KEY (idEmpleado) REFERENCES Persona.Empleado(idEmpleado)
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

/*Reglas de cadenas*/
CREATE RULE tipoServicio AS @TipoServicio IN ('Prueba de Tension', 'Prueba de Dureza', 'Prueba de Flexión',
												'Prueba de Compresión', 'Capacitación', 'Mantenimiento')
EXEC sp_bindrule 'tipoServicio', 'Servicio.ServicioActividad.tipoServicio';

CREATE RULE tipoCliente AS @TipoCliente IN ('Facultad', 'UASLP', 'Externo');
EXEC sp_bindrule 'tipoCliente', 'Persona.Cliente.tipo';

/*Reglas con restricción numérica*/
CREATE RULE cantidadMaterial AS @cantidad>=0 AND @cantidad<4
EXEC sp_bindrule 'cantidadMaterial','Servicio.DetalleMaterial.cantidad'

/*Disparadores*/
--Disparador 1
CREATE TRIGGER T_ActualizaCostos
ON Servicio.ServicioActividad
AFTER INSERT
AS
BEGIN
	DECLARE @idServicio BIGINT

	SELECT @idServicio=idServicio FROM inserted
	UPDATE Servicio.ServicioActividad SET total = (SELECT subtotal FROM Servicio.DetalleMaterial WHERE
	idServicio = @idServicio) WHERE @idServicio=@idServicio
END

--Disparador 2

--Disparador 3

--Disparador 4

--Disparador 5

--Disparador 6

SELECT * FROM Persona.Empleado;

/*Ejemplo de como obtener el registro recién insertado
para el caso de los clientes*/
INSERT INTO Persona.Cliente (nombres, apellidoPaterno, apellidoMaterno, email, telefono, tipo)
VALUES ('Isauro', 'Nava', 'Torres', 'ictorna@gmail.com', '1234567', 'Facultad');
INSERT INTO Persona.ClienteFacultad(idCliente, carrera, asignatura) VALUES (1, 'Informática', 'BD');
SELECT SCOPE_IDENTITY();

INSERT INTO Persona.Cliente (nombres, apellidoPaterno, apellidoMaterno, email, telefono, tipo)
VALUES ('Nestor', 'Mendez', 'Gutierrez', 'nexus125@gmail.com', '1234567', 'UASLP');
INSERT INTO Persona.ClienteUASLP(idCliente, departamento, asignatura) VALUES (2, 'Computación', 'BD');

INSERT INTO Persona.Cliente (nombres, apellidoPaterno, apellidoMaterno, email, telefono, tipo)
VALUES ('Gerardo', 'Nava', 'Torres', 'gnsdf@gmail.com', '12345577', 'Externo');
INSERT INTO Persona.ClienteExterno(idCliente, empresa, rfc) VALUES (3, 'Empresa1', '12354554724');

SELECT * FROM Persona.Cliente JOIN Persona.ClienteFacultad ON Persona.Cliente.idCliente = Persona.ClienteFacultad.idCliente 
UNION SELECT * FROM Persona.Cliente JOIN Persona.ClienteUASLP ON Persona.Cliente.idCliente = Persona.ClienteUASLP.idCliente
UNION SELECT * FROM Persona.Cliente  JOIN Persona.ClienteExterno ON Persona.Cliente.idCliente = Persona.ClienteExterno.idCliente;

DELETE FROM Persona.Cliente WHERE idCliente = 8
SELECT * FROM Persona.ClienteUASLP
SELECT * FROM Persona.Cliente
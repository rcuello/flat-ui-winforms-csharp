CREATE TABLE Usuarios
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	Usuario VARCHAR(50),
	NombreCompleto VARCHAR(50),
	Correo VARCHAR(50),
	Clave VARCHAR(50),
	Estado BIT,
	FechaRegistro DATETIME DEFAULT GETDATE()
)
use Login_csharp

CREATE TABLE [dbo].[Usuarios]
(
    [ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), --ID clave primaria 
    [Name] VARCHAR(50) NULL, -- Nombre de la persona
    [User] VARCHAR(50) NULL, -- Nombre del usuario
    [Password] VARCHAR(50) NULL, -- Contraseña del usuario
    [User_type] VARCHAR(50) NULL, -- Tipo de usuario
)

SELECT * FROM Usuarios -- Seleccionando los datos de la base de datos

INSERT INTO Usuarios VALUES ('Jesus', 'Jesus004', '12345', 'Admin'), -- Insertando valores
                            ('Ricardo', 'Ricardo007', '54321', 'User'); -- Insertando valores
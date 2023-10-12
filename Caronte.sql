CREATE DATABASE CaronteSQL

USE CaronteSQL

CREATE TABLE Users(
	id_user INT PRIMARY KEY IDENTITY(1,1),
	nombre_completo VARCHAR(70) NOT NULL,
	userName VARCHAR(50) NOT NULL,
	pass VARCHAR(8) NOT NULL,
	FechaCreacion DATETIME DEFAULT GETDATE() NOT NULL,
	rol VARCHAR(2) NOT NULL
)

INSERT INTO dbo.Users
(
    nombre_completo,
    userName,
    pass,
    FechaCreacion,
    rol
)
VALUES
(   'Angel Vargas',      -- nombre_completo - varchar(70)
    'rootkit',      -- userName - varchar(50)
    '12345678',      -- pass - varchar(8)
    DEFAULT, -- FechaCreacion - datetime
    'ad'       -- rol - varchar(2)
    )

SELECT * FROM dbo.Users



Use dbEventos
Go

IF OBJECT_ID('dbo.USP_Participantes_Insert', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Participantes_Insert
Go
CREATE PROCEDURE dbo.USP_Participantes_Insert
@codParticipante int OUT,
@nombres nvarchar(60),
@apellidos nvarchar(60),
@dni char(8),
@fechaNac date,
@direccion nvarchar(200),
@correo nvarchar(60),
@telefono nvarchar(60),
@distrito nvarchar(60),
@codTipoParticipante int
as
INSERT [dbo].[Participantes]
(
nombres,
apellidos,
dni,
fechaNac,
direccion,
correo,
telefono,
distrito,
codTipoParticipante
)
values
(
@nombres,
@apellidos,
@dni,
@fechaNac,
@direccion,
@correo,
@telefono,
@distrito,
@codTipoParticipante
)
Go

IF OBJECT_ID('dbo.USP_Participantes_Update', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Participantes_Update
Go
CREATE PROCEDURE dbo.USP_Participantes_Update
@codParticipante int,
@nombres nvarchar(60),
@apellidos nvarchar(60),
@dni char(8),
@fechaNac date,
@direccion nvarchar(200),
@correo nvarchar(60),
@telefono nvarchar(60),
@distrito nvarchar(60),
@codTipoParticipante int
as
UPDATE [dbo].[Participantes] SET 
nombres = @nombres,
apellidos = @apellidos,
dni = @dni,
fechaNac = @fechaNac,
direccion = @direccion,
correo = @correo,
telefono = @telefono,
distrito = @distrito,
codTipoParticipante = @codTipoParticipante
where
codParticipante = @codParticipante
Go

IF OBJECT_ID('dbo.USP_Participantes_SelectAll', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Participantes_SelectAll
Go
CREATE PROCEDURE dbo.USP_Participantes_SelectAll
as
SELECT
codParticipante,
nombres,
apellidos,
dni,
fechaNac,
direccion,
correo,
telefono,
distrito,
codTipoParticipante
FROM [dbo].[Participantes]
where estatado='A'
Go 

IF OBJECT_ID('dbo.USP_Participantes_SelectById', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Participantes_SelectById
Go
CREATE PROCEDURE dbo.USP_Participantes_SelectById
@codParticipante int
as
SELECT
codParticipante,
nombres,
apellidos,
dni,
fechaNac,
direccion,
correo,
telefono,
distrito,
codTipoParticipante
FROM [dbo].[Participantes]
where
codParticipante = @codParticipante
Go

IF OBJECT_ID('dbo.USP_Participantes_Delete', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Participantes_Delete
Go
CREATE PROCEDURE dbo.USP_Participantes_Delete
@codParticipante int
as
UPDATE [dbo].[Participantes] SET
estado= 'E'
where
codParticipante = @codParticipante
Go

 
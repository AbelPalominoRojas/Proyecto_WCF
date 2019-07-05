
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
p.codParticipante,
p.nombres,
p.apellidos,
p.dni,
p.fechaNac,
p.direccion,
p.correo,
p.telefono,
p.distrito,
p.codTipoParticipante,
t.nombreTipoParticipante
FROM [dbo].[Participantes] AS p
INNER JOIN [dbo].[TipoParticipantes] AS t
ON p.codTipoParticipante = t.codTipoParticipante
where p.estado='A'
order by codParticipante desc
Go 

IF OBJECT_ID('dbo.USP_Participantes_SelectById', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Participantes_SelectById
Go
CREATE PROCEDURE dbo.USP_Participantes_SelectById
@codParticipante int
as
SELECT
p.codParticipante,
p.nombres,
p.apellidos,
p.dni,
p.fechaNac,
p.direccion,
p.correo,
p.telefono,
p.distrito,
p.codTipoParticipante,
t.nombreTipoParticipante
FROM [dbo].[Participantes] AS p
INNER JOIN [dbo].[TipoParticipantes] AS t
ON p.codTipoParticipante = t.codTipoParticipante
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

IF OBJECT_ID('dbo.USP_Participantes_Search', 'P') IS NOT NULL
	DROP PROCEDURE dbo.USP_Participantes_Search
Go
CREATE PROCEDURE dbo.USP_Participantes_Search
@nombres nvarchar(60),
@apellidos nvarchar(60),
@dni varchar(8)
as
SELECT
p.codParticipante,
p.nombres,
p.apellidos,
p.dni,
p.fechaNac,
p.direccion,
p.correo,
p.telefono,
p.distrito,
p.codTipoParticipante,
t.nombreTipoParticipante
FROM [dbo].[Participantes] AS p
INNER JOIN [dbo].[TipoParticipantes] AS t
ON p.codTipoParticipante = t.codTipoParticipante
where p.estado = 'A'
	and p.nombres like +'%'+ ISNULL(@nombres, p.nombres) +'%'
	and p.apellidos like +'%'+ ISNULL(@apellidos,p.apellidos) +'%'
	and p.dni like +'%'+ ISNULL(@dni,p.dni) +'%'
order by p.codParticipante desc
Go


IF OBJECT_ID('dbo.USP_Participantes_SelectByIdEvento', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Participantes_SelectByIdEvento
Go
CREATE PROCEDURE dbo.USP_Participantes_SelectByIdEvento
@codEvento int
as
SELECT
p.codParticipante,
p.nombres,
p.apellidos,
p.dni,
p.fechaNac,
p.direccion,
p.correo,
p.telefono,
p.distrito,
p.codTipoParticipante,
t.nombreTipoParticipante
FROM [dbo].[Participantes] AS p
INNER JOIN [dbo].[TipoParticipantes] AS t
ON p.codTipoParticipante = t.codTipoParticipante
INNER JOIN [dbo].[EventoParticipantes] AS ep
ON p.codParticipante = ep.codParticipante
where
ep.codEvento = @codEvento
Go
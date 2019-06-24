
Use dbEventos
Go

IF OBJECT_ID('dbo.USP_EventoParticipantes_Insert', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_EventoParticipantes_Insert
Go
CREATE PROCEDURE dbo.USP_EventoParticipantes_Insert
@codEvento int,
@codParticipante int,
@fechaRegistro datetime,
@participanteAsistio bit,
@codUsuario int,
@estado char(1)
as
INSERT [dbo].[EventoParticipantes]
(
codEvento,
codParticipante,
fechaRegistro,
participanteAsistio,
codUsuario,
estado
)
values
(
@codEvento,
@codParticipante,
@fechaRegistro,
@participanteAsistio,
@codUsuario,
@estado
)
Go

IF OBJECT_ID('dbo.USP_EventoParticipantes_Update', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_EventoParticipantes_Update
Go
CREATE PROCEDURE dbo.USP_EventoParticipantes_Update
@codEvento int,
@codParticipante int,
@fechaRegistro datetime,
@participanteAsistio bit,
@codUsuario int,
@estado char(1)
as
UPDATE [dbo].[EventoParticipantes] SET 
fechaRegistro = @fechaRegistro,
participanteAsistio = @participanteAsistio,
codUsuario = @codUsuario,
estado = @estado
where
codEvento = @codEvento and 
codParticipante = @codParticipante
Go

IF OBJECT_ID('dbo.USP_EventoParticipantes_SelectAll', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_EventoParticipantes_SelectAll
Go
CREATE PROCEDURE dbo.USP_EventoParticipantes_SelectAll
as
SELECT
codEvento,
codParticipante,
fechaRegistro,
participanteAsistio,
codUsuario,
estado
FROM [dbo].[EventoParticipantes]
where estado='A'
Go 

IF OBJECT_ID('dbo.USP_EventoParticipantes_SelectById', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_EventoParticipantes_SelectById
Go
CREATE PROCEDURE dbo.USP_EventoParticipantes_SelectById
@codEvento int,
@codParticipante int
as
SELECT
codEvento,
codParticipante,
fechaRegistro,
participanteAsistio,
codUsuario,
estado
FROM [dbo].[EventoParticipantes]
where
codEvento = @codEvento and 
codParticipante = @codParticipante
Go

IF OBJECT_ID('dbo.USP_EventoParticipantes_Delete', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_EventoParticipantes_Delete
Go
CREATE PROCEDURE dbo.USP_EventoParticipantes_Delete
@codEvento int,
@codParticipante int
as
UPDATE [dbo].[EventoParticipantes] SET
estado = 'E'
where
codEvento = @codEvento and 
codParticipante = @codParticipante
Go


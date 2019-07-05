
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
order by codEvento desc
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


IF OBJECT_ID('dbo.UTRG_EventoParticipantes_Insert', 'TR') IS NOT NULL
   DROP TRIGGER dbo.UTRG_EventoParticipantes_Insert
Go

CREATE TRIGGER UTRG_EventoParticipantes_Insert ON  [dbo].[EventoParticipantes]
FOR INSERT
AS  
begin
	declare @codEvento int 
	declare @lugaresUcupados int 

	set @codEvento =  (SELECT distinct codEvento from inserted)
	set @lugaresUcupados = (SELECT COUNT(codParticipante) from [dbo].[EventoParticipantes] where codEvento = @codEvento)

	 UPDATE [dbo].[Eventos] SET 
		lugaresDisponibles = (limiteParticipantes - @lugaresUcupados)
	where
		codEvento = @codEvento		
end
go
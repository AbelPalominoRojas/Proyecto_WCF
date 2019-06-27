
Use dbEventos
Go

IF OBJECT_ID('dbo.USP_Eventos_Insert', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Eventos_Insert
Go
CREATE PROCEDURE dbo.USP_Eventos_Insert
@codEvento int OUT,
@codAreaTematica int,
@nombreEvento nvarchar(80),
@descripcionEvento nvarchar(200),
@fechaEvento datetime,
@expositor nvarchar(150),
@lugarEvento nvarchar(200),
@limiteParticipantes int,
@lugaresDisponibles int,
@codUsuario int,
@estado char(1)
as
INSERT [dbo].[Eventos]
(
codAreaTematica,
nombreEvento,
descripcionEvento,
fechaEvento,
expositor,
lugarEvento,
limiteParticipantes,
lugaresDisponibles,
codUsuario,
estado
)
values
(
@codAreaTematica,
@nombreEvento,
@descripcionEvento,
@fechaEvento,
@expositor,
@lugarEvento,
@limiteParticipantes,
@lugaresDisponibles,
@codUsuario,
@estado
)
Go

IF OBJECT_ID('dbo.USP_Eventos_Update', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Eventos_Update
Go
CREATE PROCEDURE dbo.USP_Eventos_Update
@codEvento int,
@codAreaTematica int,
@nombreEvento nvarchar(80),
@descripcionEvento nvarchar(200),
@fechaEvento datetime,
@expositor nvarchar(150),
@lugarEvento nvarchar(200),
@limiteParticipantes int,
@codUsuario int,
@estado char(1)
as
UPDATE [dbo].[Eventos] SET 
codAreaTematica = @codAreaTematica,
nombreEvento = @nombreEvento,
descripcionEvento = @descripcionEvento,
fechaEvento = @fechaEvento,
expositor = @expositor,
lugarEvento = @lugarEvento,
limiteParticipantes = @limiteParticipantes,
codUsuario = @codUsuario,
estado = @estado
where
codEvento = @codEvento
Go

IF OBJECT_ID('dbo.USP_Eventos_SelectAll', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Eventos_SelectAll
Go
CREATE PROCEDURE dbo.USP_Eventos_SelectAll
as
SELECT
e.codEvento,
e.codAreaTematica,
e.nombreEvento,
e.descripcionEvento,
e.fechaEvento,
e.expositor,
e.lugarEvento,
e.limiteParticipantes,
e.lugaresDisponibles,
e.codUsuario,
a.nombreAreaTematica,
e.estado
FROM [dbo].[Eventos] e
INNER JOIN [dbo].[AreaTematicas] a ON e.codAreaTematica = a.codAreaTematica
where e.estado='A'
Go 

IF OBJECT_ID('dbo.USP_Eventos_SelectById', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Eventos_SelectById
Go
CREATE PROCEDURE dbo.USP_Eventos_SelectById
@codEvento int
as
SELECT
e.codEvento,
e.codAreaTematica,
e.nombreEvento,
e.descripcionEvento,
e.fechaEvento,
e.expositor,
e.lugarEvento,
e.limiteParticipantes,
e.lugaresDisponibles,
e.codUsuario,
a.nombreAreaTematica,
e.estado
FROM [dbo].[Eventos] AS e
INNER JOIN [dbo].[AreaTematicas] As a on a.codAreaTematica = e.codAreaTematica
WHERE codEvento = @codEvento
Go

IF OBJECT_ID('dbo.USP_Eventos_Delete', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Eventos_Delete
Go
CREATE PROCEDURE dbo.USP_Eventos_Delete
@codEvento int
as
UPDATE [dbo].[Eventos] SET 
estado = 'E'
where
codEvento = @codEvento
Go



Use dbEventos
Go

IF OBJECT_ID('dbo.USP_TipoParticipantes_Insert', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_TipoParticipantes_Insert
Go
CREATE PROCEDURE dbo.USP_TipoParticipantes_Insert
@codTipoParticipante int OUT,
@nombreTipoParticipante nvarchar(50),
@estado char(1)
as
INSERT [dbo].[TipoParticipantes]
(
nombreTipoParticipante,
estado
)
values
(
@nombreTipoParticipante,
@estado
)
Go

IF OBJECT_ID('dbo.USP_TipoParticipantes_Update', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_TipoParticipantes_Update
Go
CREATE PROCEDURE dbo.USP_TipoParticipantes_Update
@codTipoParticipante int,
@nombreTipoParticipante nvarchar(50),
@estado char(1)
as
UPDATE [dbo].[TipoParticipantes] SET 
nombreTipoParticipante = @nombreTipoParticipante,
estado = @estado
where
codTipoParticipante = @codTipoParticipante
Go

IF OBJECT_ID('dbo.USP_TipoParticipantes_SelectAll', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_TipoParticipantes_SelectAll
Go
CREATE PROCEDURE dbo.USP_TipoParticipantes_SelectAll
as
SELECT
codTipoParticipante,
nombreTipoParticipante,
estado
FROM [dbo].[TipoParticipantes]
where estado='A'
order by codTipoParticipante desc
Go 

IF OBJECT_ID('dbo.USP_TipoParticipantes_SelectById', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_TipoParticipantes_SelectById
Go
CREATE PROCEDURE dbo.USP_TipoParticipantes_SelectById
@codTipoParticipante int
as
SELECT
codTipoParticipante,
nombreTipoParticipante,
estado
FROM [dbo].[TipoParticipantes]
where
codTipoParticipante = @codTipoParticipante
Go

IF OBJECT_ID('dbo.USP_TipoParticipantes_Delete', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_TipoParticipantes_Delete
Go
CREATE PROCEDURE dbo.USP_TipoParticipantes_Delete
@codTipoParticipante int
as
UPDATE [dbo].[TipoParticipantes] SET 
estado = 'E'
where
codTipoParticipante = @codTipoParticipante
Go


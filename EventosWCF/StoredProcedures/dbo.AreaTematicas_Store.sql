
Use dbEventos
Go

IF OBJECT_ID('dbo.USP_AreaTematicas_Insert', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_AreaTematicas_Insert
Go
CREATE PROCEDURE dbo.USP_AreaTematicas_Insert
@codAreaTematica int OUT,
@nombreAreaTematica nvarchar(50),
@estado char(1)
as
INSERT [dbo].[AreaTematicas]
(
nombreAreaTematica,
estado
)
values
(
@nombreAreaTematica,
@estado
)
Go

IF OBJECT_ID('dbo.USP_AreaTematicas_Update', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_AreaTematicas_Update
Go
CREATE PROCEDURE dbo.USP_AreaTematicas_Update
@codAreaTematica int,
@nombreAreaTematica nvarchar(50),
@estado char(1)
as
UPDATE [dbo].[AreaTematicas] SET 
nombreAreaTematica = @nombreAreaTematica,
estado = @estado
where
codAreaTematica = @codAreaTematica
Go

IF OBJECT_ID('dbo.USP_AreaTematicas_SelectAll', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_AreaTematicas_SelectAll
Go
CREATE PROCEDURE dbo.USP_AreaTematicas_SelectAll
as
SELECT
codAreaTematica,
nombreAreaTematica,
estado
FROM [dbo].[AreaTematicas]
where estado='A'
Go 

IF OBJECT_ID('dbo.USP_AreaTematicas_SelectById', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_AreaTematicas_SelectById
Go
CREATE PROCEDURE dbo.USP_AreaTematicas_SelectById
@codAreaTematica int
as
SELECT
codAreaTematica,
nombreAreaTematica,
estado
FROM [dbo].[AreaTematicas]
where
codAreaTematica = @codAreaTematica
Go

IF OBJECT_ID('dbo.USP_AreaTematicas_Delete', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_AreaTematicas_Delete
Go
CREATE PROCEDURE dbo.USP_AreaTematicas_Delete
@codAreaTematica int
as
UPDATE [dbo].[AreaTematicas] SET
estado = 'E'
where
codAreaTematica = @codAreaTematica
Go


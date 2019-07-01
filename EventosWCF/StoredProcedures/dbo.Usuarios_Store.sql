
Use dbEventos
Go

IF OBJECT_ID('dbo.USP_Usuarios_Insert', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Usuarios_Insert
Go
CREATE PROCEDURE dbo.USP_Usuarios_Insert
@codUsuario int OUT,
@nombres nvarchar(40),
@apellidos nvarchar(60),
@email nvarchar(60),
@password nvarchar(100),
@estado char(1)
as
INSERT [dbo].[Usuarios]
(
nombres,
apellidos,
email,
password,
estado
)
values
(
@nombres,
@apellidos,
@email,
@password,
@estado
)
Go

IF OBJECT_ID('dbo.USP_Usuarios_Update', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Usuarios_Update
Go
CREATE PROCEDURE dbo.USP_Usuarios_Update
@codUsuario int,
@nombres nvarchar(40),
@apellidos nvarchar(60),
@email nvarchar(60)
as
UPDATE [dbo].[Usuarios] SET 
nombres = @nombres,
apellidos = @apellidos,
email = @email
where
codUsuario = @codUsuario
Go

IF OBJECT_ID('dbo.USP_Usuarios_SelectAll', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Usuarios_SelectAll
Go
CREATE PROCEDURE dbo.USP_Usuarios_SelectAll
as
SELECT
codUsuario,
nombres,
apellidos,
email,
estado
FROM [dbo].[Usuarios]
order by codUsuario desc
Go 

IF OBJECT_ID('dbo.USP_Usuarios_SelectById', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Usuarios_SelectById
Go
CREATE PROCEDURE dbo.USP_Usuarios_SelectById
@codUsuario int
as
SELECT
codUsuario,
nombres,
apellidos,
email,
estado
FROM [dbo].[Usuarios]
where
codUsuario = @codUsuario
Go

IF OBJECT_ID('dbo.USP_Usuarios_Delete', 'P') IS NOT NULL
   DROP PROCEDURE dbo.USP_Usuarios_Delete
Go
CREATE PROCEDURE dbo.USP_Usuarios_Delete
@codUsuario int
as
UPDATE [dbo].[Usuarios] SET 
estado = 'E'
where
codUsuario = @codUsuario
Go


CREATE PROCEDURE dbo.USP_Usuarios_login
@email nvarchar(60),
@password nvarchar(100)
as
SELECT
codUsuario,
nombres,
apellidos,
email,
estado
FROM [dbo].[Usuarios]
where
email = @email and password=@password and estado='A'
Go

USP_Usuarios_login 'mramirez@hotmail.com','@123'

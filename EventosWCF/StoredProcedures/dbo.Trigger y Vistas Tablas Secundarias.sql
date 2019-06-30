use dbEventos
go
-- Logica Auditoria de Sistema de Evento
create table dbo.Auditoria_Paticipante_por_Usuario(
codAuditoriaPart_User int identity,
email_usuario nvarchar(30),
codParticipante int,
fecha datetime,
accion nvarchar(30)
)

--Ejemplo
-- 1,'Marleni@gmail.com',3,'25/12/2019','Grabar'
go
create table dbo.Auditoria_Evento_por_Usuario(
codAuditoriaEvento_User int identity,
email_usuario nvarchar(30),
codEvento int,
fecha datetime,
accion nvarchar(30)
)
--Ejemplo
-- 1,1,'28/06/2019','Grabar'
go
create table dbo.Auditoria_Acciones_de_Usuario(
codAuditoriaAcciones_User int identity,
email_usuario nvarchar(30),
codUsuario int,
fecha datetime,
accion nvarchar(30)
)

go
-- Vistas para reporteria
create view Vista_de_Reporte_Seguimiento_Usuarios
as
select Usuarios.email,Usuarios.nombres,Usuarios.apellidos, Auditoria_Acciones_de_Usuario.fecha,
Auditoria_Acciones_de_Usuario.accion
from Usuarios inner join Auditoria_Acciones_de_Usuario 
on  Usuarios.codUsuario=Auditoria_Acciones_de_Usuario.codUsuario 
go
create view Vista_de_Reporte_Seguimiento_por_Participante
as
select Auditoria_Paticipante_por_Usuario.email_usuario,Participantes.nombres,Participantes.apellidos, 
Auditoria_Paticipante_por_Usuario.fecha, Auditoria_Paticipante_por_Usuario.accion
 from Auditoria_Paticipante_por_Usuario inner join Participantes 
on Auditoria_Paticipante_por_Usuario.codParticipante =Participantes.codParticipante
go

create view Vista_de_Reporte_Seguimiento_por_Evento
as
select  Auditoria_Evento_por_Usuario.email_usuario,Eventos.nombreEvento,Eventos.lugarEvento,
Eventos.limiteParticipantes,Eventos.expositor,Auditoria_Evento_por_Usuario.fecha,Auditoria_Evento_por_Usuario.accion
from Auditoria_Evento_por_Usuario inner join Eventos 
on Auditoria_Evento_por_Usuario .codEvento=Eventos.codEvento 
go
select * from Vista_de_Reporte_Seguimiento_por_Participante
go
select * from Vista_de_Reporte_Seguimiento_por_Evento
go
select * from Vista_de_Reporte_Seguimiento_Usuarios
go
-- Disparador de Seguimiento CRUD Usuario a Participante
Create Trigger dbo.TR_DISPARADOR_Participante_User
ON Participantes
AFTER INSERT
AS
BEGIN
	INSERT INTO Auditoria_Paticipante_por_Usuario(email_usuario,codParticipante,fecha,accion)
	SELECT u.email,ep.codParticipante,getdate(),'Nuevo Participante' from EventoParticipantes ep inner join Usuarios u on ep.codUsuario=u.codUsuario
END
go
-- Disparador de Seguimiento CRUD Usuario a Evento
Create Trigger dbo.TR_DISPARADOR_Evento_User
ON Eventos
AFTER INSERT
AS
BEGIN
	INSERT INTO Auditoria_Evento_por_Usuario(email_usuario,codEvento,fecha,accion)
	 SELECT u.email,e.CodEvento,getdate() as Fecha,'Nuevo Evento' as Accion from Eventos e inner join Usuarios u on e.codUsuario=u.codUsuario
END
go
-- Disparador de Seguimiento CRUD Usuario a Evento
Create Trigger dbo.TR_DISPARADOR_Acciones_User
ON Usuarios
AFTER INSERT
AS
BEGIN
	INSERT INTO Auditoria_Acciones_de_Usuario(email_usuario,codUsuario,fecha,accion)
	 SELECT email, codUsuario,getdate() as Fecha,'Nuevo Usuario' as Accion from inserted
END
go

CREATE procedure [dbo].[USP_Auditoria_Paticipante_por_Usuario_Insert]
@email_usuario nvarchar(30),
@codParticipante int,
@fecha datetime,
@accion varchar(30)
AS BEGIN
INSERT INTO Auditoria_Paticipante_por_Usuario(email_usuario,codParticipante,fecha,accion) 
VALUES (@email_usuario,@codParticipante,@fecha,@accion)
END


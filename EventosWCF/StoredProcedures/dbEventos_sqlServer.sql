use master
go

-- Creando base de datos Proyecto Final dbEventos
create database dbEventos
go

use dbEventos
go

Create table TipoParticipantes
(
	codTipoParticipante int identity,
	nombreTipoParticipante nvarchar(50) not null,
	estado char(1) not null default 'A'

	constraint pk_TipoParticipantes primary key(codTipoParticipante),
	constraint ak_nombreTipoParticipante_estado__TipoParticipantes unique(nombreTipoParticipante, estado)
)
go


create table Participantes
(
	codParticipante int identity,
	nombres nvarchar(60) not null,
	apellidos nvarchar(60) not null,
	dni char(8) not null,
	fechaNac date,
	direccion nvarchar(200) null,
	correo nvarchar(60) not null,
	telefono nvarchar(60) null,
	distrito nvarchar(60) null,
	codTipoParticipante int  not null,
	estado char(1) not null default 'A'

	constraint pk_Participantes  primary key (codParticipante),
	constraint ak_dni__Participantes unique(codParticipante),
	constraint fk_codTipoParticipante__Participantes foreign key (codTipoParticipante) references TipoParticipantes(codTipoParticipante)
)
go


create table Usuarios
(
	codUsuario int identity,
	nombres nvarchar(40) not null,
	apellidos nvarchar(60) not null,
	email nvarchar(60) not null,
	password nvarchar(100) not null,
	estado char(1) not null default 'A'

	constraint pk_Usuarios primary key (codUsuario),
	constraint ak_codUsuario__Usuarios unique(email)
)
go


create table AreaTematicas
(
	codAreaTematica int identity,
	nombreAreaTematica nvarchar(50) not null,
	estado char(1) not null default 'A'

	constraint pk_TipoEventos primary key (codAreaTematica),
	constraint ak_nombreAreaTematica_estado__TipoEventos unique(nombreAreaTematica, estado)
)
go


create table Eventos
(
	codEvento int identity,
	codAreaTematica int not null,
	nombreEvento nvarchar(80) not null,
	descripcionEvento nvarchar(200),
	fechaEvento datetime not null,
	expositor nvarchar(150)not null,
	lugarEvento nvarchar(200) not null,
	limiteParticipantes int not null,
	lugaresDisponibles int not null,
	codUsuario int not null,
	estado char(1) not null default 'A'

	constraint pk_Eventos  primary key(codEvento),
	constraint fk_codAreaTematica__Eventos foreign key (codAreaTematica) references AreaTematicas(codAreaTematica),
	constraint fk_codUsuario__Eventos foreign key (codUsuario) references Usuarios(codUsuario)
)
go


create table EventoParticipantes
(
	codEvento int not null,
	codParticipante int not null,
	fechaRegistro datetime not null,
	participanteAsistio bit not null default 0,
	codUsuario int not null,
	estado char(1) default 'A'

	constraint pk_EventoParticipantes  primary key(codEvento,codParticipante),
	constraint fk_codParticipante__EventoParticipantes foreign key (codParticipante) references Participantes(codParticipante),
	constraint pk_codEvento__EventoParticipantes foreign key (codEvento) references Eventos(codEvento),
	constraint fk_codUsuario__EventoParticipantes foreign key (codUsuario) references Usuarios(codUsuario)
)
go


/*Data*/
SET IDENTITY_INSERT dbo.AreaTematicas ON; 
Insert Into AreaTematicas(codAreaTematica,nombreAreaTematica)values
(1,	'Software y Sistema'),
(2,	'Redes y Seguridad Informatica'),
(3,	'Diseño Web'),
(4,	'Marketing'),
(5,	'Ciencias Empresariales'),
(6,	'Negocios Internacionales'),
(7,	'General')
SET IDENTITY_INSERT dbo.AreaTematicas OFF; 
go

SET IDENTITY_INSERT dbo.TipoParticipantes ON; 
Insert Into TipoParticipantes(codTipoParticipante,nombreTipoParticipante)values
(1,	'Alumno Sise'),
(2,	'Egresado Sise'),
(3,	'Otros')
SET IDENTITY_INSERT dbo.TipoParticipantes OFF; 
go

SET IDENTITY_INSERT dbo.Participantes ON; 
Insert Into Participantes(codParticipante,nombres,apellidos,dni,fechaNac,direccion,correo,telefono,distrito,codTipoParticipante)values
(1,	'Yanet Marleni','Inga Rojas',75228456,'12-08-1999','Av. Jardine Este 562','Marleni@gmail.com',910118596,'San Juan Lurigancho',1)
SET IDENTITY_INSERT dbo.Participantes OFF; 
go
SET IDENTITY_INSERT dbo.Participantes ON; 
Insert Into Participantes(codParticipante,nombres,apellidos,dni,fechaNac,direccion,correo,telefono,distrito,codTipoParticipante)values
(2,'Marcos','Paredes Rios','45257859','01-02-1990','Av. Sarita Colonia 120','mparedesr@gmail.com','014587549','El Agustino',1)
SET IDENTITY_INSERT dbo.Participantes OFF; 
go
SET IDENTITY_INSERT dbo.Participantes ON; 
Insert Into Participantes(codParticipante,nombres,apellidos,dni,fechaNac,direccion,correo,telefono,distrito,codTipoParticipante)values
(3,'Adela','Quintana Ro','42823559','08-08-1994','Av. Circunvalación 270','aquintana@gmail.com','013265689','Cercado de Lima',1)
SET IDENTITY_INSERT dbo.Participantes OFF; 
go
SET IDENTITY_INSERT dbo.Participantes ON; 
Insert Into Participantes(codParticipante,nombres,apellidos,dni,fechaNac,direccion,correo,telefono,distrito,codTipoParticipante)values
(4,'Melissa','Cortez Rodriguez','25457896','10-02-1991','Av. Los Conquistadores 258','melicortez2@hotmail.com','012568977','San Juan de Lurigancho',1)
SET IDENTITY_INSERT dbo.Participantes OFF; 
go
SET IDENTITY_INSERT dbo.Participantes ON; 
Insert Into Participantes(codParticipante,nombres,apellidos,dni,fechaNac,direccion,correo,telefono,distrito,codTipoParticipante)values
(5,'Adriano','Rodriguez Toro','38565478','10-02-1991','Av. Santa Rosa 3240','arodriguezt@padin.com.pe','015824568','San Juan de Lurigancho',2)
SET IDENTITY_INSERT dbo.Participantes OFF; 
go
SET IDENTITY_INSERT dbo.Participantes ON; 
Insert Into Participantes(codParticipante,nombres,apellidos,dni,fechaNac,direccion,correo,telefono,distrito,codTipoParticipante)values
(6,'Neyda','Quispe Titto','42578596','10/02/1998','Av. Los Cipreses 478','nquispe98@gmail.com','012536987','San Juan de Lurigancho',2)
SET IDENTITY_INSERT dbo.Participantes OFF; 
go

SET IDENTITY_INSERT dbo.Usuarios ON; 
Insert Into Usuarios(codUsuario,nombres,apellidos,email,password)values
(1,'Mercedes','Vargas Guerrero','mvargas@hotmail.com','A123456@'),
(2,'Pedro','Moral Rojas','pedritomoral@hotmail.com','ABC123456#'),
(3,'Marcia','Vale Pelaez','mvalep@hotmail.com','A123456@'),
(4,'Sandra','Morales Porras','sandra2518@hotmail.com','123456#ABC'),
(5,'Leonor','Villanueva Villarreal','lvillanueva2008@hotmail.com','ABC@123')
SET IDENTITY_INSERT dbo.Usuarios OFF; 
go

SET IDENTITY_INSERT dbo.Eventos ON; 
Insert Into Eventos(codEvento,codAreaTematica,nombreEvento,descripcionEvento,fechaEvento,expositor,lugarEvento,limiteParticipantes,lugaresDisponibles,codUsuario)values
(1,4,'Marketing 3.0','Marketing para Marketeros','2019-06-12 10:00','Juan Ordoñez','SISE SJL',250,250,1)
SET IDENTITY_INSERT dbo.Eventos OFF; 
go
SET IDENTITY_INSERT dbo.Eventos ON; 
Insert Into Eventos(codEvento, codAreaTematica,nombreEvento,descripcionEvento,fechaEvento,expositor,lugarEvento,limiteParticipantes,lugaresDisponibles,codUsuario)values
(2,4,'Transformación digital','Automatización la nueva era','2019-07-12 10:00','Sandra Huangal','SISE SJL',350,350,1)
SET IDENTITY_INSERT dbo.Eventos OFF; 
go
SET IDENTITY_INSERT dbo.Eventos ON; 
Insert Into Eventos(codEvento, codAreaTematica,nombreEvento,descripcionEvento,fechaEvento,expositor,lugarEvento,limiteParticipantes,lugaresDisponibles,codUsuario)values
(3,4,'Digitalización','El Marketing como pilar de negocio','2019-07-05 17:00','Ram Vega','SISE SJL',350,350,1)
SET IDENTITY_INSERT dbo.Eventos OFF; 
go
SET IDENTITY_INSERT dbo.Eventos ON; 
Insert Into Eventos(codEvento, codAreaTematica,nombreEvento,descripcionEvento,fechaEvento,expositor,lugarEvento,limiteParticipantes,lugaresDisponibles,codUsuario)values
(4,4,'Redes Sociales','Campañas en Facebook e Instagram','2019-07-12 17:00','Marcos Ronstaing','SISE SJL',350,350,1)
SET IDENTITY_INSERT dbo.Eventos ON; 
go
Insert Into Eventos(codEvento, codAreaTematica,nombreEvento,descripcionEvento,fechaEvento,expositor,lugarEvento,limiteParticipantes,lugaresDisponibles,codUsuario)values
(5,4,'CRM para los negocios','KPI´s Empresariales','2019-07-22 17:00','Hilda Moango','SISE SJL',300,300,1)
SET IDENTITY_INSERT dbo.Eventos OFF; 
go





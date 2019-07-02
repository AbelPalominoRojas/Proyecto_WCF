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
(4,	'Ciencias Empresariales'),
(5,	'Negocios Internacionales'),
(6,	'General')
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
(1,	'Yanet Marleni','Inga Rojas',75228456,'12/08/1999','Av. Jardine Este 562','Marleni@gmail.com',910118596,'San Juan Lurigancho',1)
SET IDENTITY_INSERT dbo.Participantes OFF; 
go




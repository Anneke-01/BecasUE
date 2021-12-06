create database BecasEstudioUE
use BecasEstudioUE
create table Candidato(
IDCandidato int not null primary key identity(1,1),
PrimerNombre nvarchar(50) not null,
SegundoNombre nvarchar(50),
PrimerApellido nvarchar(50) not null,
SegundoApellido nvarchar(50),
IDPais int not null,
Correo nvarchar(100) not null,
NoPasaporte nvarchar(50)
)

create table Pais(
IDPais int not null primary key identity(1,1),
IDCiudad int not null foreign key references Ciudad(IDCiudad),
NombrePais nvarchar(50) not null
)
create table Ciudad(
IDCiudad int not null primary key identity(1,1),
NombreCiudad nvarchar(50) not null
)
create table HistorialAcademico(
IDHistAcademico int not null primary key identity(1,1),
IDCandidato int not null foreign key references Candidato(IDCandidato),
TituloObtenido nvarchar(75) not null,
FechaInicio date not null,
FechaFin date not null
)
create table HistorialLaboral(
IDHistLaboral int not null primary key identity(1,1),
Puesto nvarchar(75) not null,
Entidad nvarchar(50) not null,
FechaInicio date not null,
FechaFin date not null,
IDCandidato int not null foreign key references Candidato(IDCandidato)
)
create table Usuario(
IDUsuario int not null primary key identity(1,1),
Usuario nvarchar(30) not null,
Contraseña nvarchar(30) not null,
Rol nvarchar(25) not null,
Estado nvarchar(25) not null,
FechaAcceso datetime not null,
FechaModificacion datetime not null
)
alter table Candidato drop column IDPais
alter table Candidato add IDUsuario int not null foreign key references Usuario(IDUsuario)
alter table Candidato add IDPais int not null foreign key references Pais(IDPais)
create table Solicitud(
IDSolicitud int not null primary key identity(1,1),
Estado nvarchar(15) not null,
Resumen nvarchar(140) not null,
IDCantidato int not null foreign key references Candidato(IDCandidato)
)
create table Programa(
IDPrograma int not null primary key identity(1,1),
TituloPrograma nvarchar(70) not null,
TipoEspecialidad nvarchar(40) not null,
Creditos int not null,
Diplomados int not null,
Duracion nvarchar(15) not null
)
create table Oferta(
IDOferta int not null primary key identity(1,1),
FechaInicio date not null,
FechaFin date not null,
Monto float not null,
MontoFinanciamiento float not null,
IDPrograma int not null foreign key references Programa(IDPrograma)
)
create table Planificacion(
IDPlanificacion int not null primary key identity(1,1),
Año int not null, 
FechaApertura date not null,
FechaCierre date not null,
FechaCreacion date not null,
FechaAprobado date not null,
CantidadUniversidades date not null,
Estado nvarchar(15) not null,
IDPais int not null foreign key references Pais(IDPais)
)
create table Universidad(
IDUniversidad int not null primary key identity(1,1),
NombreUni nvarchar(80) not null,
IDCiudad int not null foreign key references Ciudad(IDCiudad),
Calle nvarchar(60) not null,
NumeroCalle int not null,
Distrito nvarchar(40) not null,
Telefono nvarchar(15) not null
)
alter table Universidad add IDPais int not null foreign key references Pais(IDPais)
alter table Oferta add IDUniversidad int not null foreign key references Universidad(IDUniversidad)
alter table Oferta add IDPlanificacion int not null foreign key references Planificacion(IDPlanificacion)
alter table Solicitud add IDOferta int not null foreign key references Oferta(IDOferta)
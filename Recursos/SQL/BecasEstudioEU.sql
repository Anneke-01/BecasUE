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


alter table Oferta add IDUniversidad int not null foreign key references Universidad(IDUniversidad)
alter table Oferta add IDPlanificacion int not null foreign key references Planificacion(IDPlanificacion)
alter table Solicitud add IDOferta int not null foreign key references Oferta(IDOferta)


select * from Usuario
insert into Usuario values ('Anneke','123','Habilitado',GETDATE(), GETDATE(), 'TRUE')

alter procedure Insertar_Usuario
@Usuario nvarchar(30),
@Contraseña nvarchar(30),
@Rol nvarchar(25)
as insert into Usuario(Usuario,Contraseña,Rol,Estado,FechaAcceso,FechaModificacion)
values (@Usuario, ENCRYPTBYPASSPHRASE(@Contraseña, @Contraseña), @Rol,'Habilitado',
GETDATE(),GETDATE())

Execute Insertar_Usuario 'Anneke','123','Administrador'
Execute Insertar_Usuario 'Anneke','123','Estudiante'
select * from Usuario

create or alter procedure Validar_Acceso
@Usuario nvarchar(30),
@Contrasena nvarchar(30),
@Rol nvarchar(25)
as
if exists (select Usuario from Usuario where
CAST(DECRYPTBYPASSPHRASE(@Contrasena, Contraseña) as nvarchar(30)) = @Contrasena and
Usuario=@Usuario and Rol=@Rol and Estado='Habilitado')
select 'Acceso Exitoso' as Resultado
else
select 'Acceso Denegado' as Resultado

Execute Validar_Acceso 'Anneke','123','Administrador'

create login AdminBecas with password = 'Becas2021*'
sp_adduser AdminBecas,AdminBecas
Grant execute on Validar_Acceso to AdminBecas
SELECT * FROM Usuario

SELECT LEN(Contraseña) FROM Usuario WHERE IDUsuario = 1
SELECT CAST(DECRYPTBYPASSPHRASE('123', Contraseña) AS nvarchar) FROM Usuario WHERE IDUsuario = 1

create procedure Insertar_Programas
@TituloPrograma nvarchar(70),
@TipoEspecialidad nvarchar(40),
@Creditos int,
@Diplomados int,
@Duracion nvarchar(15)
as insert into Programa(TituloPrograma,TipoEspecialidad,Creditos,Diplomados,Duracion)
values (@TituloPrograma,@TipoEspecialidad,@Creditos,@Diplomados,@Duracion)

Execute Insertar_Programas 'Especialista Universitario en Enseñanza de Español como Lengua Extranjera','Máster',2,1,'12 Meses'
Execute Insertar_Programas 'Ciencias de la Actividad Física y Deporte', 'Doctorado',1,1,'24 Meses'
Execute Insertar_Programas 'Ingeniería Mecánica: Diseño y Fabricación', 'Doctorado', 2,1, '24 Meses'
Execute Insertar_Programas 'Doctorado en Neurociencias', 'Doctorado', 2,2, '36 Meses'
Execute Insertar_Programas 'Experto en Mamografía con Contraste', 'Posgrado', 2,2,'6 Meses'
Execute Insertar_Programas 'Experto en Enfermería en el Soporte Vital Avanzado y paciente crítico', 'Posgrado', 2,2,'1 Mes'
Execute Insertar_Programas 'MBA Dirección y Gestión de Entidades Deportivas', 'Máster', 1,1, '2 Mes'
Execute Insertar_Programas 'Experto Universitario de Monitorización y Comunicación', 'Posgrado',18,1,'6 Meses'
Execute Insertar_Programas 'Diploma de Especialización Universitaria en Mantenimiento Electrónico', 'Posgrado',5,2,'6 Meses'
Execute Insertar_Programas 'Biología de las Plantas', 'Doctorado',3,2,'7 Meses'
Execute Insertar_Programas 'Diseño y Creación Digital (UOC)', 'Grado', 180,2,'36 Meses'
Execute Insertar_Programas 'Mención en Artes Plásticas del Grado en Educación Primaria', 'Grado',30,3,'12 Meses'
Execute Insertar_Programas 'Carrera Senior Videogame Programmer','Grado', 180,2,'48 Meses'
Execute Insertar_Programas 'Educación Primaria','Grado',240,3,'48 Meses'
Execute Insertar_Programas 'Diseño Gráfico', 'Grado',180,2,'48 Meses'
Execute Insertar_Programas 'Criminología', 'Grado',180,2,'48 Meses'
Execute Insertar_Programas 'Administración de Empresas', 'Grado', 180,2,'48 Meses'
Execute Insertar_Programas 'Comunicación', 'Grado', 240,2, '36 Meses'
Execute Insertar_Programas 'Carrera de Senior Videogame Artist', 'Grado',180,3,'48 Meses'
Execute Insertar_Programas 'Ciencias Biomédicas', 'Grado',240,3,'48 Meses'

Select * from Programa

insert into Pais(NombrePais) values('Colombia')
insert into Pais(NombrePais) values('Francia')
insert into Pais(NombrePais) values('España')
insert into Pais(NombrePais) values('Portugal')
insert into Pais(NombrePais) values('China')
insert into Pais(NombrePais) values('Nicaragua')
insert into Pais(NombrePais) values('Costa Rica')
insert into Pais(NombrePais) values('Honduras')
insert into Pais(NombrePais) values('Guatemala')
insert into Pais(NombrePais) values('Panamá')
insert into Pais(NombrePais) values('República Dominicana')
insert into Pais(NombrePais) values('Puerto Rico')
insert into Pais(NombrePais) values('México')
insert into Pais(NombrePais) values('Estados Unidos')
insert into Pais(NombrePais) values('Canadá')
insert into Pais(NombrePais) values('Belice')
insert into Pais(NombrePais) values('El Salvador')
insert into Pais(NombrePais) values('Uruguay')
insert into Pais(NombrePais) values('Paraguay')
insert into Pais(NombrePais) values('Argentina')
insert into Pais(NombrePais) values('Chile')
insert into Pais(NombrePais) values('Perú')
insert into Pais(NombrePais) values('Venezuela')
insert into Pais(NombrePais) values('Ecuador')
insert into Pais(NombrePais) values('Armenia')
insert into Pais(NombrePais) values('Finlandia')
insert into Pais(NombrePais) values('Singapur')
insert into Pais(NombrePais) values('Ucrania')
insert into Pais(NombrePais) values('Trinidad y Tobago')
insert into Pais(NombrePais) values('Indonesia')
insert into Pais(NombrePais) values('Brasil')
insert into Pais(NombrePais) values('Vietnam')
insert into Pais(NombrePais) values('Jamaica')
insert into Pais(NombrePais) values('Polonia')
insert into Pais(NombrePais) values('Bolivia')
insert into Pais(NombrePais) values('Rusia')
insert into Pais(NombrePais) values('Filipinas')
insert into Pais(NombrePais) values('Eslovenia')
insert into Pais(NombrePais) values('Malasia')
insert into Pais(NombrePais) values('Japón')

insert into Ciudad(NombreCiudad) values('San Luis')
insert into Ciudad(NombreCiudad) values('Paris')
insert into Ciudad(NombreCiudad) values('Wucheng')
insert into Ciudad(NombreCiudad) values('Kouqian')
insert into Ciudad(NombreCiudad) values('Youlongchuan')
insert into Ciudad(NombreCiudad) values('Juncalito Abajo')
insert into Ciudad(NombreCiudad) values('Tuanjie')
insert into Ciudad(NombreCiudad) values('Canalete')
insert into Ciudad(NombreCiudad) values('Tijuana')
insert into Ciudad(NombreCiudad) values('Queretaro')
insert into Ciudad(NombreCiudad) values('Quito')
insert into Ciudad(NombreCiudad) values('Metz')
insert into Ciudad(NombreCiudad) values('Tours')
insert into Ciudad(NombreCiudad) values('Purificación')
insert into Ciudad(NombreCiudad) values('Managua')
insert into Ciudad(NombreCiudad) values('Ciudad de Panamá')
insert into Ciudad(NombreCiudad) values('San José')
insert into Ciudad(NombreCiudad) values('Tegucigalpa')
insert into Ciudad(NombreCiudad) values('San Salvador')
insert into Ciudad(NombreCiudad) values('Stepanivka')
insert into Ciudad(NombreCiudad) values('Gojō')
insert into Ciudad(NombreCiudad) values('Kirs')
insert into Ciudad(NombreCiudad) values('Gojō')
insert into Ciudad(NombreCiudad) values('Syrskoye')
insert into Ciudad(NombreCiudad) values('Buenos Aires')
insert into Ciudad(NombreCiudad) values('Santiago')
insert into Ciudad(NombreCiudad) values('Mendoza')
insert into Ciudad(NombreCiudad) values('Santa Rita')
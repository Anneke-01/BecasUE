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

-- Procedimiento para insertar usuarios
alter procedure Insertar_Usuario
@Usuario nvarchar(30), @Contraseña nvarchar(30),@Rol nvarchar(25)
as insert into Usuario(Usuario,Contraseña,Rol,Estado,FechaAcceso,FechaModificacion)
values (@Usuario, ENCRYPTBYPASSPHRASE(@Contraseña, @Contraseña), @Rol,'Habilitado',
GETDATE(),GETDATE())

create or alter procedure Validar_Acceso
@Usuario nvarchar(30),
@Contrasena nvarchar(30),
@Rol nvarchar(25)
as
if exists (select Usuario from Usuario where
CAST(DECRYPTBYPASSPHRASE(@Contrasena, Contraseña) as nvarchar(30)) = @Contrasena and
Usuario=@Usuario and Rol=@Rol and Estado='Habilitado')
select 'Acceso Exitoso' as Resultado,
(select top 1 IDUsuario from Usuario where Usuario=@Usuario and Rol=@Rol) as IdUsuario 
else
select 'Acceso Denegado' as Resultado


/*PROCEDIMIENTO PARA LISTAR PAISES*/
create procedure Listar_Pais
as
select * from Pais order by NombrePais asc

/*PROCEDIMIENTOS ALMACENADOS PARA PROGRAMAS*/

create procedure Leer_Programas
as select TituloPrograma,TipoEspecialidad,Creditos,Diplomados,Duracion from Programa 
-------------------------------------------
create procedure Insertar_Programas
@TituloPrograma nvarchar(70), @TipoEspecialidad nvarchar(40), @Creditos int,
@Diplomados int, @Duracion nvarchar(15)
as insert into Programa(TituloPrograma,TipoEspecialidad,Creditos,Diplomados,Duracion)
values (@TituloPrograma,@TipoEspecialidad,@Creditos,@Diplomados,@Duracion)
----------------------------------
create procedure Editar_Programas
@IDPrograma int, @TituloPrograma nvarchar(70), @TipoEspecialidad nvarchar(40), @Creditos int,
@Diplomados int,@Duracion nvarchar(15)
as update Programa set TituloPrograma=@TituloPrograma, TipoEspecialidad=@TipoEspecialidad,
Creditos=@Creditos, Diplomados=@Diplomados,Duracion=@Duracion
where IDPrograma=@IDPrograma
-------------------------------------
create procedure Eliminar_Programa
@IDPrograma int 
as delete from Programa where IDPrograma=@IDPrograma
---------------------------
 /*PROCEDIMIENTOS ALMACENADOS PARA CANDIDATOS*/
 create procedure Insertar_Candidatos
 @PrimerNombre nvarchar(50),@SegundoNombre nvarchar(50),@PrimerApellido nvarchar(50),
 @SegundoApellido nvarchar(50),@Correo nvarchar(50),@NoPasaporte nvarchar(50),@IDUsuario int,@IDPais int
as insert into Candidato 
values(@PrimerNombre,@SegundoNombre,@PrimerApellido,@SegundoApellido,
@Correo,@NoPasaporte,@IDUsuario,@IDPais)
---------------------

--------------
alter procedure EditarDatos_Candidatos
@IDUsuario int, @PrimerNombre nvarchar(50), @SegundoNombre nvarchar(50), @PrimerApellido nvarchar(50),
@SegundoApellido nvarchar(50),@Correo nvarchar(50), @NoPasaporte nvarchar(50), @IDPais int
as update Candidato set  PrimerNombre=@PrimerNombre, SegundoNombre=@SegundoNombre,PrimerApellido=@PrimerApellido,
SegundoApellido=@SegundoApellido, Correo=@Correo,NoPasaporte=@NoPasaporte,IDPais=@IDPais 
where IDUsuario=@IDUsuario

----
alter procedure Obtener_Candidato
@IDCandidato int
as select c.*, p.NombrePais from Candidato c
inner join Pais p on c.IDPais = p.IDPais
where IDUsuario=@IDCandidato
----
create procedure ListarDatosCompletosCandidatos
as
select c.PrimerNombre,c.SegundoNombre,c.PrimerApellido,c.SegundoApellido,
c.Correo,c.NoPasaporte,p.NombrePais, ha.TituloObtenido,ha.FechaInicio,ha.FechaFin, hl.Puesto, hl.Entidad,hl.FechaInicio,
hl.FechaFin
from HistorialAcademico ha 
inner join Candidato c on c.IDCandidato=ha.IDCandidato
inner join HistorialLaboral hl on c.IDCandidato=hl.IDCandidato
inner join Pais p on p.IDPais = c.IDPais order by c.IDCandidato asc
----

create procedure InsertarHistorial_Academico
@IDCandidato int,@TituloObtenido nvarchar(75),@FechaInicio date,@FechaFin date
as insert into HistorialAcademico values(@IDCandidato,@TituloObtenido,@FechaInicio,@FechaFin)




------------- PRUEBAS
Execute Insertar_Candidatos 'Anneke', 'Paulina','Morales','López','annekemorales@gmail.com','C1359690',5,7
Select * from Candidato
Execute EditarDatos_Candidatos 5, 'Ana','Paulina','Mora','Colapso','anamorales@gmail.com','C1359690',7
Execute Listar_Candidatos






create or alter procedure Insertar_HistorialAcademico
@IDCandidato int,@TituloOBtenido nvarchar(75),@FechaInicio date,@FechaFin date
as
insert into HistorialAcademico values(@IDCandidato,@TituloOBtenido,@FechaInicio,@FechaFin) 

Execute Insertar_HistorialAcademico 1,'Bachiller', '2020-03-03','2020-03-03'

Insert into HistorialAcademico values(1,'Bachiller','2005-03-03','2018-12-01')
Insert into HistorialLaboral values('Gerente general','UNI','2005-03-03','2018-12-01',1)


--select c.PrimerNombre,c.SegundoNombre,c.PrimerApellido,c.SegundoApellido,
--c.Correo,c.NoPasaporte,p.NombrePais, ha.TituloObtenido,ha.FechaInicio,ha.FechaFin, hl.Puesto, hl.Entidad,hl.FechaInicio,
--hl.FechaFin
--from HistorialAcademico ha 
--inner join Candidato c on c.IDCandidato=ha.IDCandidato
--inner join HistorialLaboral hl on c.IDCandidato=hl.IDCandidato
--inner join Pais p on p.IDPais = c.IDPais order by c.IDCandidato asc

/* pruebas */

Execute Insertar_Programas 'Prueba','jasjd',2,3,'12 meses'
Execute Editar_Programas 22,'asdsd','ana',2,1,'14 Meses'
Execute Eliminar_Programa 22
 select * from Programa

Execute Validar_Acceso 'Anneke','123','Estudiante'
Execute Insertar_Usuario 'Anneke','123','Administrador'
Execute Insertar_Usuario 'Anneke','123','Estudiante'
select * from Usuario

--- No insertar datos repetidos con unique constraint en la columna Usuario
create login AdminBecas with password = 'Becas2021*'
sp_adduser AdminBecas,AdminBecas
Grant execute on Validar_Acceso to AdminBecas
SELECT * FROM Usuario

SELECT LEN(Contraseña) FROM Usuario WHERE IDUsuario = 1
SELECT CAST(DECRYPTBYPASSPHRASE('123', Contraseña) AS nvarchar) FROM Usuario WHERE IDUsuario = 5
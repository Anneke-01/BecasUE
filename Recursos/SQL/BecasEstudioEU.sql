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
-- PROCEDIMIENTO ALMACENADO PARA INSERTAR USUARIOS
alter procedure Insertar_Usuario
@Usuario nvarchar(30), @Contraseña nvarchar(30),@Rol nvarchar(25)
as insert into Usuario(Usuario,Contraseña,Rol,Estado,FechaAcceso,FechaModificacion)
values (@Usuario, ENCRYPTBYPASSPHRASE(@Contraseña, @Contraseña), @Rol,'Habilitado',
GETDATE(),GETDATE())
--- PROCEDIMIENTO ALMACENADO PARA VALIDAR EL ACCESO A LOS USUARIOS
create or alter procedure Validar_Acceso
@Usuario nvarchar(30),
@Contrasena nvarchar(30),
@Rol nvarchar(25)
as
if exists (select Usuario from Usuario where
CAST(DECRYPTBYPASSPHRASE(@Contrasena, Contraseña) as nvarchar(30)) = @Contrasena and
Usuario=@Usuario and Rol=@Rol and Estado='Habilitado')
begin
declare @IdUsuario int
set @IdUsuario = (select top 1 IDUsuario from Usuario where Usuario=@Usuario and Rol=@Rol)
select 'Acceso Exitoso' as Resultado,
(select top 1 IDUsuario from Usuario where Usuario=@Usuario and Rol=@Rol) as IdUsuario,
(select top 1 c.IDCandidato from Candidato c where IDUsuario=@IdUsuario) as IdCandidato
end
else
begin
select 'Acceso Denegado' as Resultado
end

/*PROCEDIMIENTO PARA LISTAR PAISES*/
create procedure Listar_Pais
as
select * from Pais order by NombrePais asc

-----------------------
create or alter procedure Listar_Universidades as
Select * from Universidad order by NombreUni asc

-------------
/*PROCEDIMIENTOS ALMACENADOS PARA PROGRAMAS*/

create or alter procedure Leer_Programas
as select TituloPrograma as [Título del Programa],
TipoEspecialidad as [Tipo de especialidad],
Creditos as [Créditos],
Diplomados as [Diplomados],Duracion as [Duración] from Programa 
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

Create procedure Buscar_Programa
@Dato varchar(70)
as
SELECT TOP (50) [IDPrograma],
TituloPrograma as [Título del Programa],
TipoEspecialidad as [Tipo de especialidad],
Creditos as [Créditos],
Diplomados as [Diplomados],Duracion as [Duración]
FROM Programa
where 
TituloPrograma like @Dato +'%' or
TipoEspecialidad like @Dato +'%' or
Creditos like @Dato +'%' or   
Diplomados like @Dato +'%' or   
Duracion like @Dato +'%' 

Buscar_Programa A
---------------------------
 /*PROCEDIMIENTOS ALMACENADOS PARA CANDIDATOS*/
 create procedure Insertar_Candidatos
 @PrimerNombre nvarchar(50),@SegundoNombre nvarchar(50),@PrimerApellido nvarchar(50),
 @SegundoApellido nvarchar(50),@Correo nvarchar(50),@NoPasaporte nvarchar(50),@IDUsuario int,@IDPais int
as insert into Candidato 
values(@PrimerNombre,@SegundoNombre,@PrimerApellido,@SegundoApellido,
@Correo,@NoPasaporte,@IDUsuario,@IDPais)
---------------------
create procedure ListarCandidatos
as select PrimerNombre as [Primer Nombre],
SegundoNombre as [Segundo Nombre],
PrimerApellido as [Primer Apellido],
SegundoApellido as [Segundo Apellido],
Correo as [Correo], NoPasaporte as [Número de Pasaporte]
from Candidato
--------------
alter procedure EditarDatos_Candidatos
@IDUsuario int, @PrimerNombre nvarchar(50), @SegundoNombre nvarchar(50), @PrimerApellido nvarchar(50),
@SegundoApellido nvarchar(50),@Correo nvarchar(50), @NoPasaporte nvarchar(50), @IDPais int
as 
if exists (select * from Candidato where IDUsuario=@IDUsuario)
begin
update Candidato set  PrimerNombre=@PrimerNombre, SegundoNombre=@SegundoNombre,PrimerApellido=@PrimerApellido,
SegundoApellido=@SegundoApellido, Correo=@Correo,NoPasaporte=@NoPasaporte,IDPais=@IDPais 
where IDUsuario=@IDUsuario
end
else
begin
execute Insertar_Candidatos @PrimerNombre,@SegundoNombre,@PrimerApellido,@SegundoApellido,@Correo,@NoPasaporte,@IDUsuario,@IDPais
end
----
Execute EditarDatos_Candidatos 5,'CasimiraA','PaulinaA','Morales','López','ana@gmail.com','Ac12334',7


select * from Candidato where IDCandidato = 7
select * from Candidato
select * from HistorialAcademico
select * from HistorialLaboral
select * from Usuario
alter procedure Obtener_Candidato
@IDUsuario int
as select c.*, p.NombrePais from Candidato c
inner join Pais p on c.IDPais = p.IDPais
where IDUsuario=@IDUsuario
----
Execute Obtener_Candidato 5

--create procedure ListarDatosCompletosCandidatos
--as
--select c.PrimerNombre,c.SegundoNombre,c.PrimerApellido,c.SegundoApellido,
--c.Correo,c.NoPasaporte,p.NombrePais, ha.TituloObtenido,ha.FechaInicio,ha.FechaFin, hl.Puesto, hl.Entidad,hl.FechaInicio,
--hl.FechaFin
--from HistorialAcademico ha 
--inner join Candidato c on c.IDCandidato=ha.IDCandidato
--inner join HistorialLaboral hl on c.IDCandidato=hl.IDCandidato
--inner join Pais p on p.IDPais = c.IDPais order by c.IDCandidato asc
---
---------



create procedure InsertarHistorial_Academico
@IDCandidato int,@TituloObtenido nvarchar(75),@FechaInicio date,@FechaFin date
as insert into HistorialAcademico values(@IDCandidato,@TituloObtenido,@FechaInicio,@FechaFin)

create or alter procedure Editar_HistorialAcademico
@ID int,
@TituloObtenido nvarchar(75), @FechaInicio date, @FechaFin date
as update HistorialAcademico set TituloObtenido=@TituloObtenido,FechaInicio=@FechaInicio,FechaFin=@FechaFin
where IDHistAcademico=@ID

Execute InsertarHistorial_Academico 3,'Técnico','2005-02-02','2019-02-02'
Execute Editar_HistorialAcademico 5,'Técnico','2001-01-01','2018-01-01'
select * from HistorialAcademico

create or alter procedure Editar_HistorialLaboral
@ID int,
@Puesto nvarchar(75),@Entidad nvarchar(50),@FechaInicio date,@FechaFin date
as update HistorialLaboral set Puesto=@Puesto,Entidad=@Entidad,FechaInicio=@FechaInicio,
FechaFin=@FechaFin where IDHistLaboral=@ID

select * from HistorialLaboral
Execute Editar_HistorialLaboral 4,'HALA','MAdrid','2020-04-04','2020-04-04'

create or alter procedure ListarHistorialAcademico
@IDCandidato int
as
select  IDHistAcademico as [ID],TituloObtenido as [Título Obtenido], FechaInicio as [Fecha de Inicio],
FechaFin as [Finalización]
from HistorialAcademico where IDCandidato=@IDCandidato

execute ListarHistorialAcademico 3
select * from HistorialAcademico where IDCandidato = 3


create procedure ListarHistorialLaboral
@IDCandidato int
as
select Puesto as [Puesto], Entidad as [Entidad],
FechaInicio as [Fecha de Inicio],
FechaFin as [Finalización]
from HistorialLaboral where IDCandidato=@IDCandidato

ListarHistorialLaboral 8
--create or alter procedure Mostrar_HistorialAcademic
--as
--select h.IDCandidato, h.TituloObtenido,h.FechaInicio,h.FechaFin from HistorialAcademico h
--inner join Candidato c on c.IDCandidato = h.IDCandidato

select * from HistorialAcademico
delete from HistorialAcademico where IDCandidato = 2

create procedure InsertarHistorial_Laboral
@Puesto nvarchar(75),@Entidad nvarchar(50), @FechaInicio date, @FechaFin date,@IDCandidato int
as insert into HistorialLaboral values(@Puesto,@Entidad,@FechaInicio,@FechaFin,@IDCandidato)
select * from Usuario

select * from HistorialAcademico
select * from HistorialLaboral
select * from Usuario
select * from Candidato
delete from HistorialLaboral where IDCandidato = 2



create or alter procedure CambiarContraseña
@IDUsuario int,
@Contrasena nvarchar(30),
@NuevaContrasenia nvarchar(30)
as
if exists (select Usuario from Usuario where
CAST(DECRYPTBYPASSPHRASE(@Contrasena, Contraseña) as nvarchar(30)) = @Contrasena and
IDUsuario=@IDUsuario  and Estado='Habilitado')
begin
select 'Contraseña cambiada con éxito.' as Resultado
update Usuario set Contraseña = ENCRYPTBYPASSPHRASE(@NuevaContrasenia,@NuevaContrasenia) where IDUsuario =@IDUsuario
end
else
begin
select 'Credenciales incorrectos.' as Resultado
end

select * from Usuario
Execute CambiarContraseña 13,'1234','12345'
Execute Validar_Acceso 'Mateo','12345','Estudiante'

--ALTER TABLE Planificacion ALTER COLUMN CantidadUniversidades int
--alter table Planificacion add  CantidadUniversidades int 
------------------------------------------ PLANIFICACIÓN
create or alter procedure Insertar_Planificacion
@Año int, @FechaApertura date, @FechaCierre date,@FechaCreación date,@FechaAprobado date,
@Estado nvarchar(15), @IDPais int, @CantidadUniversidades int as
insert into Planificacion values(@Año,@FechaApertura,@FechaCierre,
@FechaCreación,@FechaApertura,@Estado,@IDPais,@CantidadUniversidades)

create or alter procedure Editar_Planificación
@ID int,@Año int,@FechaApertura date, @FechaCierre date,@FechaCreación date,@FechaAprobado date,
@Estado nvarchar(15), @IDPais int, @CantidadUniversidades int as
update Planificacion set Año=@Año,FechaApertura=@FechaApertura,
FechaCierre=@FechaCierre,FechaAprobado=@FechaAprobado,Estado=@Estado,IDPais=@IDPais,
CantidadUniversidades=@CantidadUniversidades where IDPlanificacion=@ID

create or alter procedure Mostar_Planificación as
select Año as [Año], FechaApertura as [Fecha de apertura], FechaCierre as [Fecha de cierre],
FechaCreacion as [Fecha de creación], FechaApertura as [Fecha de apertura],
FechaAprobado as [Fecha de aprobado], Estado as [Estado], IDPais as [ID País],
CantidadUniversidades as [Cantidad de Universidades]
from Planificacion

Execute Mostar_Planificación

Execute Insertar_Planificacion '2020','2020-02-02','2021-02-02','2020-02-02','2021-02-02','Activo',7,18
Select * from Planificacion
Execute Editar_Planificación 1,'2020','2020-02-02','2021-02-02','2020-02-02','2021-02-02','Activo',14,15

------------- PRUEBAS
Execute Insertar_Candidatos 'Anneke', 'Paulina','Morales','López','annekemorales@gmail.com','C1359690',5,7
Select * from Candidato
Execute EditarDatos_Candidatos 5, 'Ana','Paulina','Mora','Colapso','anamorales@gmail.com','C1359690',7
Execute Listar_Candidatos


select * from Usuario






--select c.PrimerNombre,c.SegundoNombre,c.PrimerApellido,c.SegundoApellido,
--c.Correo,c.NoPasaporte,p.NombrePais, ha.TituloObtenido,ha.FechaInicio,ha.FechaFin, hl.Puesto, hl.Entidad,hl.FechaInicio,
--hl.FechaFin
--from HistorialAcademico ha 
--inner join Candidato c on c.IDCandidato=ha.IDCandidato
--inner join HistorialLaboral hl on c.IDCandidato=hl.IDCandidato
--inner join Pais p on p.IDPais = c.IDPais order by c.IDCandidato asc

/* pruebas */




--- No insertar datos repetidos con unique constraint en la columna Usuario
create login AdminBecas with password = 'Becas2021*'
sp_adduser AdminBecas,AdminBecas
Grant execute on Validar_Acceso to AdminBecas
SELECT * FROM Usuario

SELECT LEN(Contraseña) FROM Usuario WHERE IDUsuario = 9
SELECT CAST(DECRYPTBYPASSPHRASE('123', Contraseña) AS nvarchar) FROM Usuario WHERE IDUsuario = 14
update Usuario set Contraseña  = '123' where IDUsuario= 9


--create or alter procedure Validar_Acceso
--@Usuario nvarchar(30),
--@Contrasena nvarchar(30),
--@Rol nvarchar(25)
--as
--if exists (select Usuario from Usuario where
--CAST(DECRYPTBYPASSPHRASE(@Contrasena, Contraseña) as nvarchar(30)) = @Contrasena and
--Usuario=@Usuario and Rol=@Rol and Estado='Habilitado')
--select 'Acceso Exitoso' as Resultado,
--(select top 1 IDUsuario from Usuario where Usuario=@Usuario and Rol=@Rol) as IdUsuario,
--(select c.IDCandidato from Candidato c
--inner join Usuario u on c.IDUsuario = u.IDUsuario) as IdCandidato
--else
--select 'Acceso Denegado' as Resultado
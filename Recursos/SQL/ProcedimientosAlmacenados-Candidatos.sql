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

create or alter procedure Eliminar_HistorialAcademico
@ID int
as delete from HistorialAcademico  where IDHistAcademico=@ID

Execute InsertarHistorial_Academico 3,'Técnico','2005-02-02','2019-02-02'
Execute Editar_HistorialAcademico 5,'Técnico','2001-01-01','2018-01-01'
select * from HistorialAcademico
Execute Eliminar_HistorialAcademico 14


create or alter procedure Editar_HistorialLaboral
@ID int,
@Puesto nvarchar(75),@Entidad nvarchar(50),@FechaInicio date,@FechaFin date
as update HistorialLaboral set Puesto=@Puesto,Entidad=@Entidad,FechaInicio=@FechaInicio,
FechaFin=@FechaFin where IDHistLaboral=@ID


create or alter procedure Eliminar_HistorialLaboral
@ID int
as delete from HistorialLaboral  where IDHistLaboral=@ID

select * from HistorialLaboral
Execute Editar_HistorialLaboral 4,'HALA','MAdrid','2020-04-04','2020-04-04'
Execute Eliminar_HistorialLaboral 4

create or alter procedure ListarHistorialAcademico
@IDCandidato int
as
select  IDHistAcademico as [ID],TituloObtenido as [Título Obtenido], FechaInicio as [Fecha de Inicio],
FechaFin as [Finalización]
from HistorialAcademico where IDCandidato=@IDCandidato

execute ListarHistorialAcademico 8
select * from HistorialAcademico where IDCandidato = 8
Use BecasEstudioUE
select * from Candidato

create   procedure Eliminar_HistorialAcademico
@ID int
as delete from HistorialAcademico  where IDHistAcademico=@ID

create   procedure Eliminar_HistorialLaboral
@ID int
as delete from HistorialLaboral  where IDHistLaboral=@ID

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

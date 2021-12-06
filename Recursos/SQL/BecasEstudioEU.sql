use BecasEstudioUE


/*PROCEDIMIENTO PARA LISTAR PAISES*/
create procedure Listar_Pais
as
select * from Pais order by NombrePais asc

-----------------------
create or alter procedure Listar_Universidades as
Select * from Universidad order by NombreUni asc

-------------
/*PROCEDIMIENTOS ALMACENADOS PARA PROGRAMAS*/

---------------------------
 
select * from Usuario
select IDUsuario from Usuario 
update Usuario set Estado='Deshabilitado' where IDUsuario= 17



create procedure CambiarContraseña
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
use BecasEstudioUE

select * from Usuario
Execute CambiarContraseña 13,'1234','12345'
Execute Validar_Acceso 'Mateo','12345','Estudiante'

--ALTER TABLE Planificacion ALTER COLUMN CantidadUniversidades int
--alter table Planificacion add  CantidadUniversidades int 
------------------------------------------ PLANIFICACIÓN


Execute Insertar_Planificacion '2020','2020-02-02','2021-02-02','2020-02-02','2021-02-02','Activo',7,18
Select * from Planificacion
Execute Editar_Planificación 1,'2020','2020-02-02','2021-02-02','2020-02-02','2021-02-02','Activo',14,15

------------- PRUEBAS
Execute Insertar_Candidatos 'Anneke', 'Paulina','Morales','López','annekemorales@gmail.com','C1359690',5,7
Select * from Candidato
Execute EditarDatos_Candidatos 5, 'Ana','Paulina','Mora','Colapso','anamorales@gmail.com','C1359690',7
Execute Listar_Candidatos




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
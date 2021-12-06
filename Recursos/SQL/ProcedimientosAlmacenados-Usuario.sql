use BecasEstudioUE
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
Usuario=@Usuario and Rol=@Rol and Estado='Deshabilitado')
begin
select 'Usuario deshabilitado' as Resultado
end
else if exists (select Usuario from Usuario where
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

Create procedure Cambiar_Estado
@ID int
as
if((Select Estado from Usuario where IDUsuario=@ID)= 'Habilitado')
update Usuario set Estado = 'Deshabilitado' where IDUsuario=@ID
else
update Usuario set Estado = 'Habilitado' where IDUsuario=@ID

Create or alter procedure Buscar_Usuario
@Dato varchar(60)
as
SELECT TOP (50) [IDUsuario]
,[Usuario] as [Usuario]
,[Rol],[Estado]
,[FechaAcceso] as [Fecha de Acceso]
,[FechaModificacion] as [Fecha de modificación]
FROM Usuario
where 
[Usuario] like '%' + @Dato +'%' or
[Rol] like '%' + @Dato +'%' or
[Estado] like '%' +  @Dato +'%' or   
[FechaAcceso] like '%' + @Dato +'%' or   
[FechaModificacion] like '%' + @Dato +'%' 
 
 create procedure Listar_Usuario
 as
 select IDUsuario, Usuario, Rol, Estado, FechaAcceso, FechaModificacion from Usuario

 Execute Buscar_Usuario an
 Use BecasEstudioUE
Execute Cambiar_Estado 17

Execute Validar_Acceso 'Cristel','123','Estudiante'
select * from Usuario
Execute Validar_Acceso 'Anneke','123','Administrador'


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
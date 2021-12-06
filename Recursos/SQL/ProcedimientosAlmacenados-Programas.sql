create or alter procedure Leer_Programas
as select IDPrograma,TituloPrograma as [Título del Programa],
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
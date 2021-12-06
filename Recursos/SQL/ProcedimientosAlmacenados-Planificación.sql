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
select IDPlanificacion as [ID],Año as [Año], FechaApertura as [Fecha de apertura], FechaCierre as [Fecha de cierre],
FechaCreacion as [Fecha de creación], FechaApertura as [Fecha de apertura],
FechaAprobado as [Fecha de aprobado], Estado as [Estado], IDPais as [ID País],
CantidadUniversidades as [Cantidad de Universidades]
from Planificacion

Execute Mostar_Planificación

Create procedure Buscar_Planificación
@Dato varchar(70)
as
SELECT TOP (50) [IDPrograma],
TituloPrograma as [Título del Programa],
TipoEspecialidad as [Tipo de especialidad],
Creditos as [Créditos],
Diplomados as [Diplomados],Duracion as [Duración]
FROM Planificacion
where 
TituloPrograma like @Dato +'%' or
TipoEspecialidad like @Dato +'%' or
Creditos like @Dato +'%' or   
Diplomados like @Dato +'%' or   
Duracion like @Dato +'%' 

create or alter procedure Mostar_Planificación as
select p.IDPlanificacion as [ID],p.Año as [Año], p.FechaApertura as [Fecha de apertura], p.FechaCierre as [Fecha de cierre],
p.FechaCreacion as [Fecha de creación],
p.FechaAprobado as [Fecha de aprobado], p.Estado as [Estado], pa.NombrePais as [País],
CantidadUniversidades as [Cantidad de Universidades]
from Planificacion p inner join Pais pa on pa.IDPais = p.IDPais

Execute Mostar_Planificación
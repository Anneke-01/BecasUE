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
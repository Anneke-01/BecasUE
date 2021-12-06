create or alter procedure Insertar_Planificacion
@A�o int, @FechaApertura date, @FechaCierre date,@FechaCreaci�n date,@FechaAprobado date,
@Estado nvarchar(15), @IDPais int, @CantidadUniversidades int as
insert into Planificacion values(@A�o,@FechaApertura,@FechaCierre,
@FechaCreaci�n,@FechaApertura,@Estado,@IDPais,@CantidadUniversidades)

create or alter procedure Editar_Planificaci�n
@ID int,@A�o int,@FechaApertura date, @FechaCierre date,@FechaCreaci�n date,@FechaAprobado date,
@Estado nvarchar(15), @IDPais int, @CantidadUniversidades int as
update Planificacion set A�o=@A�o,FechaApertura=@FechaApertura,
FechaCierre=@FechaCierre,FechaAprobado=@FechaAprobado,Estado=@Estado,IDPais=@IDPais,
CantidadUniversidades=@CantidadUniversidades where IDPlanificacion=@ID

create or alter procedure Mostar_Planificaci�n as
select A�o as [A�o], FechaApertura as [Fecha de apertura], FechaCierre as [Fecha de cierre],
FechaCreacion as [Fecha de creaci�n], FechaApertura as [Fecha de apertura],
FechaAprobado as [Fecha de aprobado], Estado as [Estado], IDPais as [ID Pa�s],
CantidadUniversidades as [Cantidad de Universidades]
from Planificacion

Execute Mostar_Planificaci�n
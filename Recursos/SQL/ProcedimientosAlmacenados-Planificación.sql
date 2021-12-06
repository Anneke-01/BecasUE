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
select IDPlanificacion as [ID],A�o as [A�o], FechaApertura as [Fecha de apertura], FechaCierre as [Fecha de cierre],
FechaCreacion as [Fecha de creaci�n], FechaApertura as [Fecha de apertura],
FechaAprobado as [Fecha de aprobado], Estado as [Estado], IDPais as [ID Pa�s],
CantidadUniversidades as [Cantidad de Universidades]
from Planificacion

Execute Mostar_Planificaci�n

Create procedure Buscar_Planificaci�n
@Dato varchar(70)
as
SELECT TOP (50) [IDPrograma],
TituloPrograma as [T�tulo del Programa],
TipoEspecialidad as [Tipo de especialidad],
Creditos as [Cr�ditos],
Diplomados as [Diplomados],Duracion as [Duraci�n]
FROM Planificacion
where 
TituloPrograma like @Dato +'%' or
TipoEspecialidad like @Dato +'%' or
Creditos like @Dato +'%' or   
Diplomados like @Dato +'%' or   
Duracion like @Dato +'%' 

create or alter procedure Mostar_Planificaci�n as
select p.IDPlanificacion as [ID],p.A�o as [A�o], p.FechaApertura as [Fecha de apertura], p.FechaCierre as [Fecha de cierre],
p.FechaCreacion as [Fecha de creaci�n],
p.FechaAprobado as [Fecha de aprobado], p.Estado as [Estado], pa.NombrePais as [Pa�s],
CantidadUniversidades as [Cantidad de Universidades]
from Planificacion p inner join Pais pa on pa.IDPais = p.IDPais

Execute Mostar_Planificaci�n
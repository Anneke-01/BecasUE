create procedure Insertar_Oferta
@FechaInicio date, @FechaFin date, @Monto float,@MontoFinanciamiento float,
@IDPrograma int,@IDUniversidad int, @IDPlanificacion int
as
insert into Oferta 
values(@FechaInicio,@FechaFin,@Monto,@MontoFinanciamiento,@IDPrograma,@IDUniversidad,@IDPlanificacion)

select * from Oferta

create procedure Leer_Oferta as
select *
from Oferta o inner join Programa p on p.IDPrograma = o.IDPrograma
inner join Universidad u on u.IDUniversidad = o.IDUniversidad
inner join Planificacion pp on pp.IDPlanificacion = o.IDPlanificacion

Execute Leer_Oferta

select u.IDUniversidad,u.NombreUni,c.NombreCiudad, u.Telefono, p.NombrePais, u.Dirección 
from Universidad u inner join Ciudad c
on c.IDCiudad = u.IDCiudad 
inner join Pais p on p.IDPais =u.IDPais
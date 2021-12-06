create procedure Insertar_Oferta
@FechaInicio date, @FechaFin date, @Monto float,@MontoFinanciamiento float,
@IDPrograma int,@IDUniversidad int, @IDPlanificacion int
as
insert into Oferta 
values(@FechaInicio,@FechaFin,@Monto,@MontoFinanciamiento,@IDPrograma,@IDUniversidad,@IDPlanificacion)

use BecasEstudioUE

create or alter procedure Insertar_Universidad
@NombreUni nvarchar(80), @IDCiudad int, @Telefono nvarchar(15),
@IDPais int, @Direccion nvarchar(100) as
insert into Universidad values(@NombreUni,@IDCiudad,@Telefono,@IDPais,@Direccion)



Create or alter procedure Buscar_Universidad
@Dato varchar(70)
as
select u.NombreUni,c.NombreCiudad, u.Telefono, p.NombrePais,u.Dirección
from Universidad u inner join Ciudad c
on c.IDCiudad = u.IDCiudad 
inner join Pais p on p.IDPais =u.IDPais
where 
u.NombreUni like '%' + @Dato +'%' or
c.NombreCiudad like '%' + @Dato + '%' or
u.Telefono like '%' + @Dato +'%' or
p.NombrePais like '%' + @Dato + '%' or
u.Dirección like '%' + @Dato + '%'

Execute Buscar_Universidad u
select * from Universidad

Execute Listar_Universidades
select u.NombreUni,c.NombreCiudad, u.Telefono, p.NombrePais from Universidad u inner join Ciudad c
on c.IDCiudad = u.IDCiudad 
inner join Pais p on p.IDPais =u.IDPais

Insert into Universidad values('North Island College',2,'(518) 3892697',7)
Insert into Universidad values('North Island College',2,'(518) 3892697',7, ' asjdjad')
Execute Listar_Universidades

create or alter procedure Listar_Universidades as
select u.IDUniversidad,u.NombreUni,c.NombreCiudad, u.Telefono, p.NombrePais, u.Dirección 
from Universidad u inner join Ciudad c
on c.IDCiudad = u.IDCiudad 
inner join Pais p on p.IDPais =u.IDPais
order by IDUniversidad asc

select * from Universidad
alter table Universidad add  Dirección nvarchar(100)
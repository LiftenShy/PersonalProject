use Training_DB_SQL
select dbo.Usres.name as UserName, count(dbo.Phones.Phone) as 'Count phone'
from UsersRoles
inner join Usres
on UsersRoles.UserId = Usres.Id 

inner join Phones
on Usres.Id = Phones.UserId

inner join Roles
on UsersRoles.RoleId = Roles.Id

where Roles.Name = 'admin'

group by Usres.name
having count(Phone) > 2
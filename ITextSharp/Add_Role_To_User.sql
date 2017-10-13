



create procedure Add_Role_To_User @userId int, @roleId int
as
begin
	select * from UsersRoles;
	insert into UsersRoles (UserId, RoleId) 
	values (@userId, @roleId)
	select * from UsersRoles;
end;
go



Add_Role_To_User(1, 1);


create procedure [dbo].[Add_Role_To_User] 
						@userId int, 
						@roleId int
as
begin
	select * from UsersRoles
	merge into UsersRoles (UserId, RoleId) 
	values (@userId, @roleId)
	select * from UsersRoles
end;
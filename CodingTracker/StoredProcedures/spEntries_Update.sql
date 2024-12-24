CREATE PROCEDURE [dbo].[spEntries_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
	update dbo.Tracker
	set FirstName = @FirstName, LastName = @LastName
	where Id = @Id;
end

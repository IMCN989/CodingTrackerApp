CREATE PROCEDURE [dbo].[spEntries_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
	insert into dbo.[Tracker] (FirstName, LastName)
	values (@FirstName, @LastName);
end
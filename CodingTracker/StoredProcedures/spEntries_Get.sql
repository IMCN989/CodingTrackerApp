CREATE PROCEDURE [dbo].[spEntries_Get]
	@Id int
AS
begin
	select Id, FirstName, LastName
	from dbo.Tracker
	where Id = @Id;
end

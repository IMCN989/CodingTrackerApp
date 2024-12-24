CREATE PROCEDURE [dbo].[spEntries_Delete]
	@Id int
AS
begin
	delete
	from dbo.[Tracker]
	where Id = @Id;
end

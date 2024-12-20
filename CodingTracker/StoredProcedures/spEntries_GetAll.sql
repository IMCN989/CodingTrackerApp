CREATE PROCEDURE [dbo].[spEntries_GetAll]
As
begin

select [Id], [FirstName], [LastName]
from Tracker

end

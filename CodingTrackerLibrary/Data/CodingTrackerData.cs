using CodingTrackerLibrary.DbAccess;
using CodingTrackerLibrary.Models;


namespace CodingTrackerLibrary.Data;
public class CodingTrackerData : ICodingTrackerData
{


    private readonly ISqlDataAccess _db;

    public CodingTrackerData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<CodingTrackerModel>> GetEntries() =>
        _db.LoadData<CodingTrackerModel, dynamic>("dbo.spEntries_GetAll", new { });

    public async Task<CodingTrackerModel?> GetEntry(int id)
    {
        var results = await _db.LoadData<CodingTrackerModel, dynamic>(
            "dbo.spEntries_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertEntry(CodingTrackerModel user) =>
        _db.SaveData("dbo.spEntries_Insert", new { user.FirstName, user.LastName });

    public Task UpdateEntry(CodingTrackerModel user) =>
        _db.SaveData("dbo.spEntries_Update", user);

    public Task DeleteEntry(int id) =>
        _db.SaveData("dbo.spEntries_Delete", new { Id = id });

    public Task<CodingTrackerModel?> GetUser(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CodingTrackerModel>> GetUsers()
    {
        throw new NotImplementedException();
    }
}
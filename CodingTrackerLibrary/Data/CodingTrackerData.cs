using CodingTrackerLibrary.Models;

namespace CodingTrackerLibrary.Data
{
    public class CodingTrackerData : ICodingTrackerData
    {
        private readonly ISqlDataAccess _db;
        public CodingTrackerData(ISqlDataAccess db)
        {
            _db = db;

        }

        public async Task<List<CodingTrackerModel>> GetCodingTrackers()
        {
            var output = await _db.LoadDataAsync<CodingTrackerModel, dynamic>("dbo.spEntries_GetAll", new { });
            return output;
        }
    }
}

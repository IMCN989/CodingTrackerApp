using CodingTrackerLibrary.Models;

namespace CodingTrackerLibrary.Data
{
    public interface ICodingTrackerData
    {
        Task DeleteEntry(int id);
        Task<CodingTrackerModel?> GetEntry(int id);
        Task<IEnumerable<CodingTrackerModel>> GetEntries();
        Task InsertEntry(CodingTrackerModel user);
        Task UpdateEntry(CodingTrackerModel user);
    }
}
using CodingTrackerLibrary.Models;

namespace CodingTrackerLibrary.Data
{
    public interface ICodingTrackerData
    {
        Task<List<CodingTrackerModel>> GetCodingTrackers();
    }
}
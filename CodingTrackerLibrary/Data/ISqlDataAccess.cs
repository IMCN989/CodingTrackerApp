
namespace CodingTrackerLibrary.Data
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadDataAsync<T, U>(string sql, U parameters, string connectionStringName = "Default");
    }
}
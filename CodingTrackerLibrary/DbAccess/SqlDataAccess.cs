using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace CodingTrackerLibrary.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        //public async Task<List<T>> LoadDataAsync<T, U>(string sql, U parameters, string connectionStringName = "Default")
        //{

        //    using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionStringName));

        //    var rows = await connection.QueryAsync<T>(sql, parameters, commandType: CommandType.StoredProcedure);

        //    return rows.ToList();

        //}

        public async Task<IEnumerable<T>> LoadData<T, U>(
    string storedProcedure,
    U parameters,
    string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

            return await connection.QueryAsync<T>(storedProcedure, parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task SaveData<T>(
            string storedProcedure,
            T parameters,
            string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

            await connection.ExecuteAsync(storedProcedure, parameters,
                commandType: CommandType.StoredProcedure);
        }





    }
}

using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System.Data.Common;

namespace WorkTracker.Infrastructure.Data
{
    public class DapperContext(IConfiguration configuration)
    {
        private readonly string _connectionString = configuration.GetConnectionString("") ?? "";
        public DbConnection CreateConnection() => new SqliteConnection(_connectionString);
    }
}

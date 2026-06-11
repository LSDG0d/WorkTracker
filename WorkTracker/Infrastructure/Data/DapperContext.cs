using Microsoft.Data.Sqlite;
using System.Data.Common;

namespace WorkTracker.Infrastructure.Data
{
    public class DapperContext
    {
        private readonly string _connectionString;

        public DapperContext()
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "ld.db");
            _connectionString = $"Data Source={dbPath}";
        }

        public DbConnection CreateConnection() => new SqliteConnection(_connectionString);
    }
}

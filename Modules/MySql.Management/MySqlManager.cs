using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.TestModule
{
    public class MySqlManager
    {
        private readonly string _connection;

        public MySqlManager(string connection)
        {
            _connection = connection;
        }

        public async Task CreateDatabaseAsync(string name)
        {
            using var connection = new MySqlConnector.MySqlConnection(_connection);
            await connection.OpenAsync();
            using var cmd = connection.CreateCommand();
            cmd.CommandText = $"CREATE DATABASE IF NOT EXISTS `{name}`";
            await cmd.ExecuteNonQueryAsync();
        }
    }
}

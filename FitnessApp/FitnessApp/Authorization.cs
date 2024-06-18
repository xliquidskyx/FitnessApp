/*using Microsoft.Data.Sqlite;

namespace FitnessApp
{
    public class Authorization
    {
        private readonly string CONNECTION_STRING;

        public Authorization(string connectionString)
        {
            CONNECTION_STRING = connectionString;
            CreateDatabase();
        }

        private void CreateDatabase()
        {
            using (var connection = new SqliteConnection(CONNECTION_STRING))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Email TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL
                );";

                command.ExecuteNonQuery();
            }
        }
    }
}
*/
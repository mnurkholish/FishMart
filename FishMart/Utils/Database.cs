using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMart.Utils
{
    public static class Database
    {
        public static NpgsqlConnection GetConnection()
        {
            string host = Environment.GetEnvironmentVariable("DB_HOST");
            string db = Environment.GetEnvironmentVariable("DB_DATABASE");
            string user = Environment.GetEnvironmentVariable("DB_USERNAME");
            string pass = Environment.GetEnvironmentVariable("DB_PASSWORD");
            string sslMode = Environment.GetEnvironmentVariable("DB_SSLMODE") ?? "Require";
            string channelBinding = Environment.GetEnvironmentVariable("DB_CHANNEL_BINDING") ?? "disable";

            string connString =
                $"Host={host};Database={db};Username={user};Password={pass};" +
                $"SSL Mode={sslMode};Channel Binding={channelBinding};";

            return new NpgsqlConnection(connString);
        }
    }
}

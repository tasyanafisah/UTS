using System;
using MySql.Data.MySqlClient;

namespace UTS
{
    public class connect
    {
        private static string connectionString = "server=localhost; port=3306; uid=tasyanafisah; pwd=123tnk; database=eskrimmidnightblue; charset=utf8; sslMode=none";
        private static MySqlConnection _connection = new MySqlConnection(connectionString);
        public MySqlConnection connection
        {
            get{ return _connection; }
        }
    }
}
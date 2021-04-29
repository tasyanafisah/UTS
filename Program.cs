using System;
using MySql.Data.MySqlClient;

namespace UTS
{
    class Program
    {
        public static void Main(string[] args)
        {            
            Login login = new Login();
            login.login();
        }
    }
}

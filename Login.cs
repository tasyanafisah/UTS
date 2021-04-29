using System;
using MySql.Data.MySqlClient;

namespace UTS
{
    
    class Login
    {
        public string Username{ get; set; }
        public string Password{ get; set; }

        public void login()
        {
            connect conn = new connect();
            using(conn.connection)
            {
                conn.connection.Open();
                Console.WriteLine("Masukkan Username: ");
                Username = Console.ReadLine();
                Console.WriteLine("Masukkan Password: ");
                Password = Console.ReadLine();

                MySqlCommand command = conn.connection.CreateCommand();
                command.CommandText = System.Data.CommandType.Text.ToString();
                command.CommandText = "Select * from login where username = '"+Username+"' and password = '"+Password+"'";
                
                MySqlDataReader check = command.ExecuteReader();
                
                if(check.HasRows)
                {
                    Console.WriteLine("Login berhasil");
                    conn.connection.Close();
                    DataPemesanan pesanan = new DataPemesanan();
                    pesanan.PesananMasuk();
                }
                else
                {
                    Console.WriteLine("Login gagal");
                    conn.connection.Close();
                    Login login1 = new Login();
                    login1.login();
                }
            }
        }
    }
}

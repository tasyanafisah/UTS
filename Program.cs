using System;

namespace UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================= Es Krim Midnight Blue =========================");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("============================== Daftar Harga =============================");
            Console.WriteLine("|      Menu Es Krim       |       Rasa Eskrim      |   Topping Eskrim   |");
            Console.WriteLine("| Es Krim Cup     : 10000 | Vanila    : 5000/scoop | Meses       : 0    |");
            Console.WriteLine("| Es Krim Cone    : 12000 | Coklat    : 5000/scoop | Caramel     : 1000 |");
            Console.WriteLine("| Es Krim Parfait : 15000 | Stroberi  : 5000/scoop | Pocky       : 1000 |");
            Console.WriteLine("|                         | Oreo      : 5000/scoop | Honeystar   : 2000 |");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("\n");
            
            DataPemesanan data = new DataPemesanan();
            data.PesananMasuk();
        }
    }
}

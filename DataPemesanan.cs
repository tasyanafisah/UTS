using System;
using System.Collections.Generic;

namespace UTS
{
    public class DataPemesanan
    {
        public static void TampilkanMenu()
        {
            Console.WriteLine("================ Pilihan Menu Es Krim Midnight Blue ===============");
            Console.WriteLine("||                         a) Es Krim Cup                        ||");
            Console.WriteLine("||     Vanila    |     Coklat    |      Oreo     |    Stroberi   ||");
            Console.WriteLine("|| 1. Meses      | 5. Meses      | 9. Meses      | 13. Meses     ||");
            Console.WriteLine("|| 2. Caramel    | 6. Caramel    | 10. Caramel   | 14. Caramel   ||");
            Console.WriteLine("|| 3. Pocky      | 7. Pocky      | 11. Pocky     | 15. Pocky     ||");
            Console.WriteLine("|| 4. Honeystar  | 8. Honeystar  | 12. Honeystar | 16. Honeystar ||");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("||                        b) Es Krim Cone                        ||");
            Console.WriteLine("||     Vanila    |     Coklat    |    Stroberi   |      Oreo     ||");
            Console.WriteLine("|| 17. Meses     | 21. Meses     | 25. Meses     | 29. Meses     ||");
            Console.WriteLine("|| 18. Caramel   | 22. Caramel   | 26. Caramel   | 30. Caramel   ||");
            Console.WriteLine("|| 19. Pocky     | 23. Pocky     | 27. Pocky     | 31. Pocky     ||");
            Console.WriteLine("|| 20. Honeystar | 24. Honeystar | 28. Honeystar | 32. Honeystar ||");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("||                       c) Es Krim Parfait                      ||");
            Console.WriteLine("||     Vanila    |     Coklat    |    Stroberi   |      Oreo     ||");
            Console.WriteLine("|| 33. Meses     | 37. Meses     | 41. Meses     | 45. Meses     ||");
            Console.WriteLine("|| 34. Caramel   | 38. Caramel   | 42. Caramel   | 46. Caramel   ||");
            Console.WriteLine("|| 35. Pocky     | 39. Pocky     | 43. Pocky     | 47. Pocky     ||");
            Console.WriteLine("|| 36. Honeystar | 40. Honeystar | 44. Honeystar | 48. Honeystar ||");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\nMasukkan menu yang dipesan: ");
        }
        public string PesananMasuk()
        {
            string pilihanMenu = "";
            TampilkanMenu();
            var pesanan = Console.ReadLine();

            switch(pesanan)
            {
                case "1":
                EsKrimCup cup1 = new EsKrimCup();
                cup1.AddScoop(new Scoop(Rasa.Vanila));
                cup1.AddTopping(new Meses());
                Console.WriteLine(cup1.About());
                break;

                case "2":
                EsKrimCup cup2 = new EsKrimCup();
                cup2.AddScoop(new Scoop(Rasa.Vanila));
                cup2.AddTopping(new Caramel());
                Console.WriteLine(cup2.About());
                break;

                case "3":
                EsKrimCup cup3 = new EsKrimCup();
                cup3.AddScoop(new Scoop(Rasa.Vanila));
                cup3.AddTopping(new Pocky());
                Console.WriteLine(cup3.About());
                break;

                case "4":
                EsKrimCup cup4 = new EsKrimCup();
                cup4.AddScoop(new Scoop(Rasa.Vanila));
                cup4.AddTopping(new Honeystar());
                Console.WriteLine(cup4.About());
                break;

                case "5":
                EsKrimCup cup5 = new EsKrimCup();
                cup5.AddScoop(new Scoop(Rasa.Coklat));
                cup5.AddTopping(new Meses());
                Console.WriteLine(cup5.About());
                break;

                case "6":
                EsKrimCup cup6 = new EsKrimCup();
                cup6.AddScoop(new Scoop(Rasa.Coklat));
                cup6.AddTopping(new Caramel());
                Console.WriteLine(cup6.About());
                break;

                case "7":
                EsKrimCup cup7 = new EsKrimCup();
                cup7.AddScoop(new Scoop(Rasa.Coklat));
                cup7.AddTopping(new Pocky());
                Console.WriteLine(cup7.About());
                break;

                case "8":
                EsKrimCup cup8 = new EsKrimCup();
                cup8.AddScoop(new Scoop(Rasa.Coklat));
                cup8.AddTopping(new Honeystar());
                Console.WriteLine(cup8.About());
                break;

                case "9":
                EsKrimCup cup9 = new EsKrimCup();
                cup9.AddScoop(new Scoop(Rasa.Oreo));
                cup9.AddTopping(new Meses());
                Console.WriteLine(cup9.About());
                break;

                case "10":
                EsKrimCup cup10 = new EsKrimCup();
                cup10.AddScoop(new Scoop(Rasa.Oreo));
                cup10.AddTopping(new Caramel());
                Console.WriteLine(cup10.About());
                break;

                case "11":
                EsKrimCup cup11 = new EsKrimCup();
                cup11.AddScoop(new Scoop(Rasa.Oreo));
                cup11.AddTopping(new Pocky());
                Console.WriteLine(cup11.About());
                break;

                case "12":
                EsKrimCup cup12 = new EsKrimCup();
                cup12.AddScoop(new Scoop(Rasa.Oreo));
                cup12.AddTopping(new Honeystar());
                Console.WriteLine(cup12.About());
                break;

                case "13":
                EsKrimCup cup13 = new EsKrimCup();
                cup13.AddScoop(new Scoop(Rasa.Oreo));
                cup13.AddTopping(new Meses());
                Console.WriteLine(cup13.About());
                break;

                case "14":
                EsKrimCup cup14 = new EsKrimCup();
                cup14.AddScoop(new Scoop(Rasa.Oreo));
                cup14.AddTopping(new Caramel());
                Console.WriteLine(cup14.About());
                break;

                case "15":
                EsKrimCup cup15 = new EsKrimCup();
                cup15.AddScoop(new Scoop(Rasa.Oreo));
                cup15.AddTopping(new Pocky());
                Console.WriteLine(cup15.About());
                break;

                case "16":
                EsKrimCup cup16 = new EsKrimCup();
                cup16.AddScoop(new Scoop(Rasa.Oreo));
                cup16.AddTopping(new Honeystar());
                Console.WriteLine(cup16.About());
                break;

                case "17":
                EsKrimCone cone1 = new EsKrimCone();
                cone1.AddScoop(new Scoop(Rasa.Vanila));
                cone1.AddTopping(new Meses());
                Console.WriteLine(cone1.About());
                break;

                case "18":
                EsKrimCone cone2 = new EsKrimCone();
                cone2.AddScoop(new Scoop(Rasa.Vanila));
                cone2.AddTopping(new Caramel());
                Console.WriteLine(cone2.About());
                break;

                case "19":
                EsKrimCone cone3 = new EsKrimCone();
                cone3.AddScoop(new Scoop(Rasa.Vanila));
                cone3.AddTopping(new Pocky());
                Console.WriteLine(cone3.About());
                break;

                case "20":
                EsKrimCone cone4 = new EsKrimCone();
                cone4.AddScoop(new Scoop(Rasa.Vanila));
                cone4.AddTopping(new Honeystar());
                Console.WriteLine(cone4.About());
                break;

                case "21":
                EsKrimCone cone5 = new EsKrimCone();
                cone5.AddScoop(new Scoop(Rasa.Coklat));
                cone5.AddTopping(new Meses());
                Console.WriteLine(cone5.About());
                break;

                case "22":
                EsKrimCone cone6 = new EsKrimCone();
                cone6.AddScoop(new Scoop(Rasa.Coklat));
                cone6.AddTopping(new Caramel());
                Console.WriteLine(cone6.About());
                break;

                case "23":
                EsKrimCone cone7 = new EsKrimCone();
                cone7.AddScoop(new Scoop(Rasa.Coklat));
                cone7.AddTopping(new Pocky());
                Console.WriteLine(cone7.About());
                break;

                case "24":
                EsKrimCone cone8 = new EsKrimCone();
                cone8.AddScoop(new Scoop(Rasa.Coklat));
                cone8.AddTopping(new Honeystar());
                Console.WriteLine(cone8.About());
                break;

                case "25":
                EsKrimCone cone9 = new EsKrimCone();
                cone9.AddScoop(new Scoop(Rasa.Oreo));
                cone9.AddTopping(new Meses());
                Console.WriteLine(cone9.About());
                break;

                case "26":
                EsKrimCone cone10 = new EsKrimCone();
                cone10.AddScoop(new Scoop(Rasa.Oreo));
                cone10.AddTopping(new Caramel());
                Console.WriteLine(cone10.About());
                break;

                case "27":
                EsKrimCone cone11 = new EsKrimCone();
                cone11.AddScoop(new Scoop(Rasa.Oreo));
                cone11.AddTopping(new Pocky());
                Console.WriteLine(cone11.About());
                break;

                case "28":
                EsKrimCone cone12 = new EsKrimCone();
                cone12.AddScoop(new Scoop(Rasa.Oreo));
                cone12.AddTopping(new Honeystar());
                Console.WriteLine(cone12.About());
                break;

                case "29":
                EsKrimCone cone13 = new EsKrimCone();
                cone13.AddScoop(new Scoop(Rasa.Oreo));
                cone13.AddTopping(new Meses());
                Console.WriteLine(cone13.About());
                break;

                case "30":
                EsKrimCone cone14 = new EsKrimCone();
                cone14.AddScoop(new Scoop(Rasa.Oreo));
                cone14.AddTopping(new Caramel());
                Console.WriteLine(cone14.About());
                break;

                case "31":
                EsKrimCone cone15 = new EsKrimCone();
                cone15.AddScoop(new Scoop(Rasa.Oreo));
                cone15.AddTopping(new Pocky());
                Console.WriteLine(cone15.About());
                break;

                case "32":
                EsKrimCone cone16 = new EsKrimCone();
                cone16.AddScoop(new Scoop(Rasa.Oreo));
                cone16.AddTopping(new Honeystar());
                Console.WriteLine(cone16.About());
                break;

                case "33":
                EsKrimParfait parfait1 = new EsKrimParfait();
                parfait1.AddScoop(new Scoop(Rasa.Vanila));
                parfait1.AddTopping(new Meses());
                Console.WriteLine(parfait1.About());
                break;

                case "34":
                EsKrimParfait parfait2 = new EsKrimParfait();
                parfait2.AddScoop(new Scoop(Rasa.Vanila));
                parfait2.AddTopping(new Caramel());
                Console.WriteLine(parfait2.About());
                break;

                case "35":
                EsKrimParfait parfait3 = new EsKrimParfait();
                parfait3.AddScoop(new Scoop(Rasa.Vanila));
                parfait3.AddTopping(new Pocky());
                Console.WriteLine(parfait3.About());
                break;

                case "36":
                EsKrimParfait parfait4 = new EsKrimParfait();
                parfait4.AddScoop(new Scoop(Rasa.Vanila));
                parfait4.AddTopping(new Honeystar());
                Console.WriteLine(parfait4.About());
                break;

                case "37":
                EsKrimParfait parfait5 = new EsKrimParfait();
                parfait5.AddScoop(new Scoop(Rasa.Coklat));
                parfait5.AddTopping(new Meses());
                Console.WriteLine(parfait5.About());
                break;

                case "38":
                EsKrimParfait parfait6 = new EsKrimParfait();
                parfait6.AddScoop(new Scoop(Rasa.Coklat));
                parfait6.AddTopping(new Caramel());
                Console.WriteLine(parfait6.About());
                break;

                case "39":
                EsKrimParfait parfait7 = new EsKrimParfait();
                parfait7.AddScoop(new Scoop(Rasa.Coklat));
                parfait7.AddTopping(new Pocky());
                Console.WriteLine(parfait7.About());
                break;

                case "40":
                EsKrimParfait parfait8 = new EsKrimParfait();
                parfait8.AddScoop(new Scoop(Rasa.Coklat));
                parfait8.AddTopping(new Honeystar());
                Console.WriteLine(parfait8.About());
                break;

                case "41":
                EsKrimParfait parfait9 = new EsKrimParfait();
                parfait9.AddScoop(new Scoop(Rasa.Oreo));
                parfait9.AddTopping(new Meses());
                Console.WriteLine(parfait9.About());
                break;

                case "42":
                EsKrimParfait parfait10 = new EsKrimParfait();
                parfait10.AddScoop(new Scoop(Rasa.Oreo));
                parfait10.AddTopping(new Caramel());
                Console.WriteLine(parfait10.About());
                break;

                case "43":
                EsKrimParfait parfait11 = new EsKrimParfait();
                parfait11.AddScoop(new Scoop(Rasa.Oreo));
                parfait11.AddTopping(new Pocky());
                Console.WriteLine(parfait11.About());
                break;

                case "44":
                EsKrimParfait parfait12 = new EsKrimParfait();
                parfait12.AddScoop(new Scoop(Rasa.Oreo));
                parfait12.AddTopping(new Honeystar());
                Console.WriteLine(parfait12.About());
                break;

                case "45":
                EsKrimParfait parfait13 = new EsKrimParfait();
                parfait13.AddScoop(new Scoop(Rasa.Oreo));
                parfait13.AddTopping(new Meses());
                Console.WriteLine(parfait13.About());
                break;

                case "46":
                EsKrimParfait parfait14 = new EsKrimParfait();
                parfait14.AddScoop(new Scoop(Rasa.Oreo));
                parfait14.AddTopping(new Caramel());
                Console.WriteLine(parfait14.About());
                break;

                case "47":
                EsKrimParfait parfait15 = new EsKrimParfait();
                parfait15.AddScoop(new Scoop(Rasa.Oreo));
                parfait15.AddTopping(new Pocky());
                Console.WriteLine(parfait15.About());
                break;

                case "48":
                EsKrimParfait parfait16 = new EsKrimParfait();
                parfait16.AddScoop(new Scoop(Rasa.Oreo));
                parfait16.AddTopping(new Honeystar());
                Console.WriteLine(parfait16.About());
                break;

                default:
                Console.WriteLine("Pesanan Tidak Tersedia");
                pilihanMenu = "0";
                break;
            }
            return pilihanMenu;
        }
    }
}
using System;
using System.Collections.Generic;

namespace UTS
{
    public abstract class EsKrim : Produk
    {
        public string Nama { get; set; }
        public int Harga { get; set; }

        public List<Scoop> Scoops;
        public List<Topping> Toppings;

        public EsKrim()
        {
            this.Harga = 10000;
            this.Scoops = new List<Scoop>();
            this.Toppings = new List<Topping>();
        }

        public int GetHarga()
        {

            int totalHarga = this.Harga;
            foreach (var t in this.Toppings)
            {
                totalHarga += t.Harga;
            }

            foreach (var s in this.Scoops)
            {
                totalHarga += s.Harga;
            }
            
            return totalHarga;
        }

        public void AddScoop(Scoop s)
        {
            this.Scoops.Add(s);
        }

        public void AddTopping(Topping t)
        {
            this.Toppings.Add(t);
        }

        public string GetScoop()
        {
            string strScoop = String.Empty;
            foreach (Scoop s in this.Scoops)
            {
                strScoop += s.About();
            }
            return strScoop;
        }


        public string GetTopping()
        {
            string strtop = String.Empty;
            foreach (Topping t in this.Toppings)
            {
                strtop += t.About();
            }
            return strtop;
        }

        public string About()
        {
            string strAbout = "Pesanan Es Krim\n";
            strAbout += "Nama\t\tHarga\n";
            strAbout += $"{this.ToString().Replace("UTS","")}\t{this.Harga}\n";
            strAbout += GetScoop();

            strAbout += this.GetTopping();
            strAbout += "--------------------\n";

            strAbout += $"total\t\t{this.GetHarga()}\n";
            return strAbout;
        }
    }
}

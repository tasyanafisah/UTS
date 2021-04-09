using System;
using System.Collections.Generic;

namespace UTS
{
    public abstract class Topping : Produk
    {
        public string Nama { get; set; }
        public int Harga { get; set; }

        public Topping()
        {
            this.Harga = 0;
            this.Nama = "Meses";
        }

        public string About()
        {
            return $"{this.Nama}\t\t{this.Harga}\n";
        }
    }
}
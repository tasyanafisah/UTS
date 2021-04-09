using System;
using System.Collections.Generic;

namespace UTS
{

    public enum Rasa 
    { 
        Vanila, 
        Coklat, 
        Stroberi, 
        Oreo
    }

    public class Scoop : Produk
    {
       
        public Rasa rasa;
        public int Harga { get; set; }

        public string Nama
        {
            get { return this.rasa.ToString(); }

        }

        public Scoop() : this(Rasa.Vanila)
        {
        }

        public Scoop(Rasa r)
        {
            this.Harga = 5000;
            this.rasa = r;
        }

        public string About()
        {
            return $"{this.rasa}\t\t{this.Harga}\n";
        }
    }
}
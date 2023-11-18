using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_7Lekce_eshop
{
    public class Trousers : Clothes
    {
        // properties
        public string Length;
        public string Waist;

        // constructor
        public Trousers(int price, int size, string color, int quantity, string length, string waist) : base(2, "Kalhoty", price, size, color, quantity)
        {
            Length = length;
            Waist = waist;
        }

        // methods
    }
}

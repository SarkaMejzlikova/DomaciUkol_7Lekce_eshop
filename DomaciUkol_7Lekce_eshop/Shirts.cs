using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_7Lekce_eshop
{
    public class Shirts : Clothes
    {
        // properties
        public string Sleeve;
        public bool Printing;

        // constructor
        public Shirts(int price, int size, string color, int quantity, string sleeve, bool printing) : base(1, "Tričko", price, size, color, quantity)
        {
            Sleeve = sleeve;
            Printing = printing;
        }

        // methods

    }
}

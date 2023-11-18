using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_7Lekce_eshop
{
    public class Hats : Clothes
    {
        //properties
        public bool PomPom;
        public string Season;

        // constructor
        public Hats(int price, int size, string color, int quantity, bool pomPom, string season) : base(3, "Čepice", price, size, color, quantity)
        {
            PomPom = pomPom;
            Season = season;
        }

        //methods
    }
}

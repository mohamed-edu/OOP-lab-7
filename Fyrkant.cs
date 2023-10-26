using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_7
{
    internal class Fyrkant : Geometri
    {
        public int Side { get; set; }
        public Fyrkant ()
        {
            Side = 4;
        }

        public override void area()
        {
            int Area = Side * Side;
            Console.WriteLine("fyrkant area: " + Area);
        }
    }
}

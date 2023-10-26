using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_7
{
    internal class Parallellogram : Geometri
    {
        public int Base { get; set; }
        public int height { get; set; }


        public Parallellogram()
        {
            Base = 8;
            height = 4;
        }

        public override void area()
        {
            int Area = Base * height;
            Console.WriteLine("parallellogram area: " + Area);
        }
    }
}

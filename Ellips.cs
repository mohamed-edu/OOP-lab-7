using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_7
{
    internal class Ellips : Geometri
    {
        public double Axis1 { get; set; }
        public double Axis2 { get; set; }
        public double Pi { get; set; }

        public Ellips()
        {
            Axis1 = 7.6;
            Axis2 = 9.8;
            Pi = 3.14;
        }

        public override void area()
        {
            double Area = Axis1 * Axis2 * Pi;
            Console.WriteLine("ellips area: " + Area);
        }
    }
}

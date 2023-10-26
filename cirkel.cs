using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_7
{
    internal class cirkel : Geometri
    {
        public double Radius { get; set; }
        public double Pi { get; set; }
        
        public cirkel()
        {
            Radius = 6.1;
            Pi = 3.14;
        }
        public override void area()
        {
            double Area = Radius * Pi * Radius;
            Console.WriteLine("Cirkel area: " + Area);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_7
{
    internal class Rektangel : Geometri
    {
        public int Length { get; set; }
        public int Wide { get; set; }

        
       public Rektangel()
        {
            Length = 10;
            Wide = 5;
        }

        
        public override void area()
        {
            int Area = Length * Wide;
            Console.WriteLine("rektangel area: " + Area);
        }
    }
}

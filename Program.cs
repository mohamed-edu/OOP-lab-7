namespace OOP_lab_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rektangel = new Rektangel();
            rektangel.area();
            Console.WriteLine();


            var fyrkant = new Fyrkant();
            fyrkant.area();
            Console.WriteLine();


            var cirkel = new cirkel();
            cirkel.area();
            Console.WriteLine();


            var Parallellogram = new Parallellogram();
            Parallellogram.area();
            Console.WriteLine();


            var ellips = new Ellips();
            ellips.area();
            Console.WriteLine();


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402.S2.L03A
{
    class Program
    {
        static void Main(string[] args)
        {
            ViewMenu();
        }

        private static Shape CreateShape(ShapeType shapeType)
        { 
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        { 
        }

        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==============================");
            Console.WriteLine("=                            =");
            Console.WriteLine("=    Geometriska figurer     =");
            Console.WriteLine("=                            =");
            Console.WriteLine("==============================");
            Console.ResetColor();
            Console.WriteLine("0: Avsluta.");
            Console.WriteLine("1: Ellips.");
            Console.WriteLine("0: Rektangel.");
            Console.WriteLine("==============================");
            Console.WriteLine("Ange menyval [0-2]: ");
        }

        private static void ViewShapeDetail (Shape shape)
        {
        }
    }
}

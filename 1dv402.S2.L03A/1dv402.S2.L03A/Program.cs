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
            do
            {
                ViewMenu();

                switch (Console.ReadLine())
                {
                    case "0":
                        return;

                    case "1":
                        CreateShape(ShapeType.Ellipse);
                        break;

                    case "2":
                        CreateShape(ShapeType.Rectangle);
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fel! Gör ditt val genom att välja ett nummer mellan 0 och 2.");
                        Console.ResetColor();
                        break;
                }

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Tryck tangent för att fortsätta. [Esc] avslutar.");
                Console.ResetColor();

            } while (Console.ReadKey().Key != ConsoleKey.Escape);


        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            if (shapeType == ShapeType.Ellipse)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("==============================");
                Console.WriteLine("=     Beräkna ellipsen       =");
                Console.WriteLine("==============================");
                Console.ResetColor();
                Console.WriteLine("Ange längden: ");
                Console.WriteLine("Ange bredden: ");
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("==============================");
                Console.WriteLine("=     Beräkna rektangeln     =");
                Console.WriteLine("==============================");
                Console.ResetColor();
                Console.WriteLine("Ange längden: ");
                Console.WriteLine("Ange bredden: ");
            }
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        { 
        }

        private static void ViewMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==============================");
            Console.WriteLine("=                            =");
            Console.WriteLine("=    Geometriska figurer     =");
            Console.WriteLine("=                            =");
            Console.WriteLine("==============================");
            Console.ResetColor();
            Console.WriteLine("\n0: Avsluta.");
            Console.WriteLine("1: Ellips.");
            Console.WriteLine("0: Rektangel.");
            Console.WriteLine("\n==============================");
            Console.WriteLine("\nAnge menyval [0-2]: ");
        }

        private static void ViewShapeDetail (Shape shape)
        {
        }
    }
}

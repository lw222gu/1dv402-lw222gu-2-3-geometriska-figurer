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
                        ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                        break;

                    case "2":
                        ViewShapeDetail(CreateShape(ShapeType.Rectangle));
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
            string promptLength = "Ange längden: ";
            double length= ReadDoubleGreaterThanZero(promptLength);

            string promptWidth = "Ange bredden: ";
            double width = ReadDoubleGreaterThanZero(promptWidth);


            if (shapeType == ShapeType.Ellipse)
            {
                Ellipse ellipse = new Ellipse(length, width);
                //Console.BackgroundColor = ConsoleColor.DarkGreen;
                //Console.WriteLine("==============================");
                //Console.WriteLine("=     Beräkna ellipsen       =");
                //Console.WriteLine("==============================");
                //Console.ResetColor();
                return ellipse;
            }

            else
            {
                Rectangle rectangle = new Rectangle(length, width);
                //Console.WriteLine("==============================");
                //Console.WriteLine("=     Beräkna rektangeln     =");
                //Console.WriteLine("==============================");
                //Console.ResetColor();
                return rectangle;
            }
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double inputValue;

            while (true)
            {
                Console.Write(prompt);

                if (double.TryParse(Console.ReadLine(), out inputValue) && inputValue > 0)
                {
                    return inputValue;
                }

                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! Ange ett flyttal större än 0.");
                    Console.ResetColor();
                } 
            }
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
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==============================");
            Console.WriteLine("=          Detaljer          =");
            Console.WriteLine("==============================");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
            Console.WriteLine("==============================");
        }
    }
}

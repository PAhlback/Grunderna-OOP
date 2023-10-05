using System.Xml.Serialization;

namespace Grunderna_OOP
{
    internal class Program
    {
        // Method for choosing which shape to create. VS told me to use static, because otherwise I would have had to pass a parameter thorugh on line 46(?).
        public static int GetSelection()
        {
            Console.WriteLine("Choose shape: ");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Sphere");
            Console.WriteLine("3. Triangle");
            bool t = true;
            int choice = 0;

            while (t) 
            {
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        choice = 1;
                        t = false;
                        break;
                    case 2:
                        choice = 2;
                        t = false;
                        break;
                    case 3:
                        choice = 3;
                        t = false;
                        break;
                    default:
                        Console.WriteLine("You can only select 1, 2, or 3.");
                        break;
                }
            }

            return choice;
        }

        static void Main(string[] args)
        {
            // Gets input from user regarding which object to create (circle, sphere or triangle).
            int selection = GetSelection();

            // Was unable to create objects inside the if-statement and then use it outside (tried with a temporary object "Shape s;" which was then instantiated
            // as a specific shape.
            // Instead, I made an object of each and then ran the methods for the one that was chosen. 
            Circle c = new Circle();
            Sphere s = new Sphere();
            Triangle t = new Triangle();

            if (selection == 1)
            {
                c.SetCircle(c);
                c.PrintCircle(c);

            } 
            else if (selection == 2)
            {
                s.SetSphere(s);
                s.PrintSphere(s);
            }
            else if (selection == 3)
            {
                t.SetTriangle(t);
                t.PrintTriangle(t);
            }

            // Checks if the user wants to go again.
            Console.WriteLine();
            Console.Write("Go again? (y/n): ");
            char yesNo = char.Parse(Console.ReadLine());
            bool b = true;
            while (b)
            {
                if (yesNo == 'y')
                {
                    string[] arr = new string[0];
                    Console.Clear();
                    Main(arr);
                }
                else if (yesNo == 'n')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Only enter y/n: ");
                }
            }

            Console.ReadLine();
        }
    }
}
using System.Xml.Serialization;

namespace Grunderna_OOP
{
    internal class Program
    {
        class Shape
        {
            public double Pi = Math.PI;
            public double Area;

            public double GetArea()
            {
                return Area;
            }
        }

        class Circle : Shape
        {
            public int Radius;

            public void SetCircle(Circle c)
            {
                Console.Write("Enter radius: ");
                c.Radius = int.Parse(Console.ReadLine());
                c.Area = Pi * (Radius * Radius);
            }
            public void PrintCircle(Circle c)
            {
                Console.WriteLine($"Radius: {c.Radius}");
                Console.WriteLine($"Area: {c.Area}");
            }
        }

        class Sphere : Shape
        {
            public double Radius;
            public double Circumference;
            public double Volume;
            public void SetSphere(Sphere s)
            {
                Console.Write("Enter circumference: ");
                s.Circumference = double.Parse(Console.ReadLine());
                s.Radius = s.Circumference / (2 * Pi);
                s.Volume = (4.0 / 3) * Pi * Math.Pow(3, s.Radius);
            }
            public void PrintSphere(Sphere s)
            {
                Console.WriteLine($"Circumference: {s.Circumference}");
                Console.WriteLine($"Radius: {s.Radius}");
                Console.WriteLine($"Volume: {s.Volume}");
            }
        }


        class Triangle : Shape
        {
            public int Base;
            public int Height;
            public void SetTriangle(Triangle t)
            {
                Console.Write("Enter base: ");
                t.Base = int.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                t.Height = int.Parse(Console.ReadLine());
                t.Area = (t.Base * t.Height) / 2.0;
            }
            public void PrintTriangle(Triangle t)
            {
                Console.WriteLine($"Base: {t.Base}");
                Console.WriteLine($"Height: {t.Height}");
                Console.WriteLine($"Area: {t.Area}");
            }
        }

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
            int selection = GetSelection();

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
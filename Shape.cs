using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grunderna_OOP
{
    class Shape
    {
        public static double Pi = Math.PI;
        public double Area { get; set; }
    }

    class Circle : Shape
    {
        public int Radius { get; set; }

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
        public double Radius { get; set; }
        public double Circumference { get; set; }
        public double Volume { get; set; }
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
        public int Base {  get; set; }
        public int Height {  get; set; }
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
}

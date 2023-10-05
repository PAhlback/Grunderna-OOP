using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grunderna_OOP
{
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
            //Discovered that if you do 4/3 C# returns 1. Guess it sees them as ints and rounds down. Changing either number to have a decimal seems to work.
        }
        public void PrintSphere(Sphere s)
        {
            Console.WriteLine($"Circumference: {s.Circumference}");
            Console.WriteLine($"Radius: {s.Radius}");
            Console.WriteLine($"Volume: {s.Volume}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grunderna_OOP
{
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
}

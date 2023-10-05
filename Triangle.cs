using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grunderna_OOP
{
    class Triangle : Shape
    {
        public int Base { get; set; }
        public int Height { get; set; }
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

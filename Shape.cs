using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grunderna_OOP
{
    // Base class for shapes. Only contains Pi and Area, since the other shapes uses their own methods and has their own properties.
    abstract class Shape
    {
        public static double Pi = Math.PI;
        public double Area { get; set; }
    }
}

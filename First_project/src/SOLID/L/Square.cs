using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_project.src.SOLID.L
{
    public class Square : Shape
    {
        public double SideLength { get; set; }

        public override double Area => SideLength * SideLength;
    }
}
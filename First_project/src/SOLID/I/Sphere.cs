using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_project.src.SOLID.I
{
    public class Sphere : IShape3D
    {
        public double Radius { get; set; }
        public double Area()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public double Volume()
        {
            return (4.0/3.0) * Math.PI * Math.Pow(Radius, 2);
        }
    }
}
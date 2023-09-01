using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConcept
{
    internal class Cylinder : Shape
    {
        public Cylinder(double radius, double height) : base(radius, height)
        {

        }

        public override double GetArea()
        {
            return 2 * Math.PI * Math.Pow(Radius, 2) + 2 * Math.PI * Radius * Height;
        }

    }
}

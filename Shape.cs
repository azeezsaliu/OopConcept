using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConcept
{
    internal abstract class Shape
    {
        private double radius;
        private double height;

        public Shape(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
        /*
        public virtual void Init(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
        */
        public abstract double GetArea();

        public virtual double GetVolume()
        {
            return Math.PI*Math.Pow(radius, 2) * Height;
        }

        public double Radius
        {
            get { return this.radius; }
            set { radius = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { height = value; }
        }

        public void getExtra()
        {

        }

    }
}

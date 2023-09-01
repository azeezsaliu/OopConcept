using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConcept
{
    internal class Cone : Shape
    {
        private double lenght;

        public Cone(double radius, double height) : base(radius, height)
        {
            Lenght = Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(Height, 2));
        }

        /*
        public override void Init(double radius, double height)
        {
            Lenght = Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(Height, 2));
            base.Init(radius, height);
        }
        */
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2) + Math.PI * Lenght;
        }

        public override double GetVolume()
        {
            double partialVolume = base.GetVolume();
            return partialVolume / 3;
        }

        public double Lenght
        {
            get { return this.lenght; }
            set { lenght = value; }
        }

        public void GetConeExtra()
        {

        }
    }
}

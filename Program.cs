using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape sh = new Cylinder(2, 4);

            double cyArea = sh.GetArea();
            Console.WriteLine("Cylinda Are: {0}", cyArea);
            double cyVol = sh.GetVolume();
            Console.WriteLine("Cylindar Vol: {0}", cyVol);

            sh = new Cone(2, 4);
            double coArea = sh.GetArea();
            Console.WriteLine("Cone Are: {0}", coArea);
            double coVol = sh.GetVolume();
            Console.WriteLine("Cone Vol: {0}", coVol);


            sh.getExtra();

            Cone co = (Cone)sh;

            co.GetConeExtra();


            /*
            Cylinder cy = new Cylinder(2, 4);
            //cy.Init(2, 4);

            Cone co = new Cone(2, 4);
            //co.Init(2, 4);


            double cyArea = cy.GetArea();
            Console.WriteLine("Cylinda Are: {0}", cyArea);
            double cyVol = cy.GetVolume();
            Console.WriteLine("Cylindar Vol: {0}", cyVol);


            double coArea = co.GetArea();
            Console.WriteLine("Cone Are: {0}", coArea);
            double coVol = co.GetVolume();
            Console.WriteLine("Cone Vol: {0}", coVol);
            */



        }
    }
}

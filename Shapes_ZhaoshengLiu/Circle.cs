using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhaoshengLiu
{
    class Circle : IShape
    {
        private const string RADIUS = "radius";

        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }
        public void Display()
        {
            Console.WriteLine($"The circle area is {CalculateArea()}");
        }

        public void SetParam()
        {
            Radius = Utilities.GetNumber(RADIUS);
        }
    }
}

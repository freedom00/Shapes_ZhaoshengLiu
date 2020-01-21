using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhaoshengLiu
{
    class Square : IShape
    {
        private const string LENGTH = "length";
        public double Length { get; set; }

        public double CalculateArea()
        {
            return Math.Pow(Length, 2.0);
        }

        public void Display()
        {
            Console.WriteLine($"The square area is {CalculateArea()}");
        }

        public void SetParam()
        {
            Length = Utilities.GetNumber(LENGTH);
        }
    }
}

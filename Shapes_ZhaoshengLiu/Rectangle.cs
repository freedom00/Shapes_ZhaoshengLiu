using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhaoshengLiu
{
    class Rectangle : IShape
    {
        private const string LENGTH = "length";
        private const string WIDTH = "width";

        public double Length { get; set; }

        public double Width { get; set; }

        public double CalculateArea()
        {
            return Length * Width;
        }

        public void Display()
        {
            Console.WriteLine($"The rectangle area is {CalculateArea()}");
        }

        public void SetParam()
        {
            Length = Utilities.GetNumber(LENGTH);
            Width = Utilities.GetNumber(WIDTH);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhaoshengLiu
{
    class Rectangle : IShapes
    {
        public double Length { get; set; }
        public double Width { get; set; }


        public double CalculateArea()
        {
            return Length * Width;
        }

        public void Dispaly()
        {
            throw new NotImplementedException();
        }
    }
}

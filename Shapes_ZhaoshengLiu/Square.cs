using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhaoshengLiu
{
    class Square : IShapes
    {
        public double Length { get; set; }
        public double CalculateArea()
        {
            return Math.Sqrt(Length);
        }

        public void Dispaly()
        {
            throw new NotImplementedException();
        }
    }
}

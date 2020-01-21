using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhaoshengLiu
{
    class Circle : IShapes
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Math.Sqrt(Radius);
        }

        public void Dispaly()
        {
            throw new NotImplementedException();
        }
    }
}

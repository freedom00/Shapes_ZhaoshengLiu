using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhaoshengLiu
{
    class ShapeFactory
    {
        public static IShape CreateShape(ConsoleKeyInfo consoleKeyInfo)
        {
            IShape shape = null;
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.C:
                    shape = new Circle();
                    break;
                case ConsoleKey.R:
                    shape = new Rectangle();
                    break;
                case ConsoleKey.S:
                    shape = new Square();
                    break;
            }
            return shape;
        }
    }
}

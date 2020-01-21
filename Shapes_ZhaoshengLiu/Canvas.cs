using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhaoshengLiu
{
    class Canvas
    {
        public IShape Shape {get; set;}

        public void Show(ConsoleKeyInfo consoleKeyInfo)
        {
            Shape = ShapeFactory.CreateShape(consoleKeyInfo);
            Shape.SetParam();
            Shape.Display();
   
        }
    }
}

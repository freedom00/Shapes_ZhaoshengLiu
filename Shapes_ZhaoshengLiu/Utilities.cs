using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhaoshengLiu
{
    class Utilities
    {
        static void ShowMenu()
        {
            Console.WriteLine($"Shapes");
            Console.WriteLine($"Choose a shape.");
        }

        public static ConsoleKeyInfo GetConsoleKey(string prompt)
        {
            Console.Write($"Please input {prompt}: ");
            return Console.ReadKey();
        }

        public static double GetNumber(string prompt)
        {
            string tempStr;
            double tempNum;
            do
            {
                Console.Write($"Please input {prompt}: ");
                tempStr = Console.ReadLine();
            } while (!double.TryParse(tempStr, out tempNum));
            return tempNum;
        }
    }
}

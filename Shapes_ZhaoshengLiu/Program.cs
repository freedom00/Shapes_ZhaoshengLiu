using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Shapes_ZhaoshengLiu
{
    class Program
    {
        private const string CHOOSE = "'Y', if you want to continue.";
        private const string SHAPE = "(C R S), C for circle, R for rectangle, S for square";

        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^[CRScrs]$");
            ConsoleKeyInfo consoleKeyInfo;
            Canvas canvas = new Canvas();
            do
            {
                do
                {
                    consoleKeyInfo = Utilities.GetConsoleKey(SHAPE);
                    Console.WriteLine();
                } while (!regex.IsMatch(consoleKeyInfo.Key.ToString()));

                canvas.Show(consoleKeyInfo);

                consoleKeyInfo = Utilities.GetConsoleKey(CHOOSE);
                Console.WriteLine();
            } while (consoleKeyInfo.Key == ConsoleKey.Y);
        }
    }
}

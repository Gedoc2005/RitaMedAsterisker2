using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitaMedAsterisker
{
    class Program
    {
        static void Main(string[] args)
        {
          

            for (int kolumn = 0; kolumn < 25; kolumn++)
            {
                int farg = kolumn % 3;
                switch (farg)
                {

                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                    default:
                        break;
                }

                if (kolumn % 2 == 1)
                {
                    Console.Write(" ");
                }

                for (int rad = 0; rad < 39; rad++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                Console.ResetColor();

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterSixLoops
{
    class Factorial
    {
        static void Factoiralvalue()
        {
            int n = int.parse(Console.ReadLine);
            decimal factorial = 1;
            while (true)
            {
                if (n <= 1)
                    break;
            }
            factorial *= n;
            n--;
        }
        Console.writeline("n!="+factorial);
    }
}

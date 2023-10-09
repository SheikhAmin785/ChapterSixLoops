using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterSixLoops
{
    class ForeachExample
    {
        static void ForechEx()
        {
            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
            foreach(int i in numbers)
            {
                Console.WriteLine(" " + i);
            }
            Console.WriteLine();
            string[] towns = { "london", "paris", "dhaka", "newyork" };
            foreach(string town in towns)
            {
                Console.WriteLine(""+town);
            }
        }
        static void Nested()
        {
            int n = int.Parse(Console.ReadLine());
            for(int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.WriteLine(col+"");
                }
                Console.WriteLine();
            }
        }
    }
}

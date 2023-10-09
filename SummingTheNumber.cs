using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterSixLoops
{
    class SummingTheNumber
    {

        static void Summing()
        {

            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 1;
            while (num < n)
            {
                num++;
                sum += num;
                Console.WriteLine("+" + num);

            }
            Console.WriteLine("=" + sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for(int x = 0; x <= 10; x++)
            {
                total += x;
            }
            Console.WriteLine(total);

            total = 0;
            int i = 0;
            while(i <= 10)
            {
                total += i;
                i++;
            }
            Console.WriteLine(total);
        }
    }
}

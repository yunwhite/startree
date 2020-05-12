using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int x = 8 - i; x > 0; x--)
                    Console.Write(" ");
                for (int y = 1; y <= i * 2 - 1; y++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}

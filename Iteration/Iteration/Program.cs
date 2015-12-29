using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 7)
                {
                    Console.WriteLine("found seven");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}

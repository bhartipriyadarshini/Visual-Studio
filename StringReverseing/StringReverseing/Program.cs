using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseing
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = new string [20];
            str = "hie hello";
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            for(int i=0;i< str.Length;i++)
            {
                Console.Write(str);
            }
            Console.ReadLine();
        }
    }
}

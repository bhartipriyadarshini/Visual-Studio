using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = new secret();
            m.secret();
            Console.WriteLine(m);
            Console.ReadLine();
        }
    }
       class myname
       { 
        static string secret()
        {
            return"helloworld";
        }
    }
}

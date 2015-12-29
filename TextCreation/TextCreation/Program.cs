using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader read = new System.IO.StreamReader("values.txt");
            string line = " ";
             
            while(line!= null)
            {
                line = read.ReadLine();
                if(line!=null)
                {
                    Console.WriteLine(line);
                }

            }
            read.Close();
            Console.ReadLine();  
        }
    }
}

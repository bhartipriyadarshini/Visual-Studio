using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
           int[]number = new int[3];
            number[0]= 2;
            number[1]= 1;
            number[2]= 3;

            string[] name = new string[3];
            name[0] = "ajay";
            name[1] = "vijay";
            name[2] = "sanjay";
          
            Console.WriteLine(number[2].ToString());
            Console.WriteLine(name[2]);
           

             
            Console.ReadLine();
        }

        
    }
}

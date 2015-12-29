using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class DecisionMaking
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you prefer behind the door 1,2 or 3");
            string myvalue = Console.ReadLine();
            string Message;

            /* if (myvalue == "1")
             {
                 Console.WriteLine("You won a car");
                 Console.ReadLine();
             }

             else if (myvalue == "2") 
             {
                 Console.WriteLine("You won a bat");
                 Console.ReadLine();
             }

             else if (myvalue == "3")
             {
                 Console.WriteLine("Hard Luck");
                 Console.ReadLine();
             }

            else
             {
                 Console.WriteLine("Re-enter your choice");
                 Console.ReadLine();
             }
            */
            { 

            if (myvalue == "1")

                Message = "you won a car";

            else if (myvalue == "2")
                Message = "you won a bat";
            else if (myvalue == "3")
                Message = "hard luck";

            else
                Message = " renter your choice";
            }

            Console.WriteLine(Message);
            Console.ReadLine();



        }
    }
}

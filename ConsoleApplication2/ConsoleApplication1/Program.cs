using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
          
            Console.WriteLine("To check whether"  +name +  " he has a proper sleep or not");
            if (number > 8)
            {
                Console.WriteLine("He has a proper sleep");
            }
            else
            {
                Console.WriteLine("He didn't had a proper sleep");
            }   
        }
    }
}

        
   


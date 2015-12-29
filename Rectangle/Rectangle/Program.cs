using System;
namespace RectangleApplication
{
    class Rectangle
    {
        double length;
        double width;
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double Calculate()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine(+ length);
            Console.WriteLine(+ width);
            Console.WriteLine( Calculate());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
           
        }
    }
}



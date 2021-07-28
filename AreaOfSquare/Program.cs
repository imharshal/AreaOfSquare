using System;

namespace AreaOfSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            string val;
            Console.WriteLine("Enter the side of a square");
            val = Console.ReadLine();
            double side = Convert.ToDouble(val);
            Console.WriteLine(side);
            double area = side * side;
            Console.WriteLine("Area of square = " + area);
        }
    }
}

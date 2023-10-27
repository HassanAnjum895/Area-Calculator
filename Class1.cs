/*using System;

namespace AreaCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            string Shape;
            int x;
            int y;
            int result;

            Console.WriteLine("Welcome To Area Calculator!");
            Console.WriteLine("------");

            do
            {
                Console.WriteLine("Please Choose a Shape:\nR = Rectangle\nT = Triangle");
                Shape = Console.ReadLine();
                Shape = Shape.ToUpper();

                if (Shape != "R" && Shape != "T")
                {
                    Console.WriteLine("Please select either 'R' or 'T'");
                }
            }
            while (Shape != "R" && Shape != "T");



            if (Shape == "R")
            {


                Console.WriteLine("Enter a number for variable 'x'");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("------");

                Console.WriteLine("Enter a number for variable 'y'");
                y = Convert.ToInt32(Console.ReadLine());


                result = (x * y);


                Console.WriteLine("Calculating...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine($"Answer: {result}");
            }
        }
    }
}*/
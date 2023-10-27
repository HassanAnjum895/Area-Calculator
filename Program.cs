using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string Shape;
                int x;
                int y = 0;
                int result;
                bool validInput = false;

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


                do
                {
                    if (Shape == "R")
                    {


                        Console.WriteLine("Enter a number for variable 'x'");
                        string inputX = Console.ReadLine();
                        Console.WriteLine("------");

                        Console.WriteLine("Enter a number for variable 'y'");
                        string inputY = Console.ReadLine();

                        if (int.TryParse(inputX, out x) && int.TryParse(inputY, out y))
                        {
                            validInput = true;

                            result = (x * y);


                            Console.WriteLine("Calculating...");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine($"Area: {result}m²");
                        }
                        else
                        {
                            Console.WriteLine("Please Enter Numbers Only!");

                        }
                    }
                    else if (Shape == "T")
                    {
                        Console.WriteLine("Enter a number for variable 'x'");
                        string inputX = Console.ReadLine();
                        Console.WriteLine("------");

                        Console.WriteLine("Enter a number for variable 'y'");
                        string inputY = Console.ReadLine();

                        if (int.TryParse(inputX, out x) && int.TryParse(inputY, out y))
                        {
                            validInput = true;

                            result = (x * y) / 2;


                            Console.WriteLine("Calculating...");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine($"Area: {result}m²");
                        }
                        else
                        {
                            Console.WriteLine("Please Enter Numbers Only!");
                        }
                    }
                }
                while (!validInput);
                Console.WriteLine("Would you like to continue? (Y = Yes, N = No)");
            }
            while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("------");
            Console.WriteLine("Bye");
        }
    }
}
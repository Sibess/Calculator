using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string welcomeMessage = "******Welcome to the calculator******";
            Console.SetCursorPosition((Console.WindowWidth - welcomeMessage.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcomeMessage);
            Console.WriteLine();
            Console.WriteLine("Please follow the instructions below. Operations allowed: \"+\", \"-\", \"/\", \"*\".");
            Console.WriteLine();

            Console.Write("Enter first number: ");
            double num1;
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid number. Please enter a valid one.");
                Console.ForegroundColor = ConsoleColor.Green;
            }


            Console.Write("Enter operator: ");
            string op = Console.ReadLine();

            while (op != "+" && op != "/" && op != "*" && op != "-")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Operator.Please enter a valid one: \"+\", \"-\", \"/\", \"*\".");
                Console.ForegroundColor = ConsoleColor.Green;
                op = Console.ReadLine();
            }



            Console.Write("Enter second number: ");
            double num2;

            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid number. Please enter a valid one.");
                Console.ForegroundColor = ConsoleColor.Green;
            }

            if (op == "+")
            {
                Console.Write("Result:");
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.Write("Result:");
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.Write("Result:");
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.Write("Result:");
                Console.WriteLine(num1 * num2);
            }

            Console.ReadKey();
        }
    }
}

using System;

namespace calculator
{
    internal class Tools
    {
        public static int AskUserForNumber(string message)
        {
            int number = 0;
            bool incorrect;
            do
            {
                Console.Write(message);
                string input = Console.ReadLine();
                try
                {
                    number = int.Parse(input);
                    incorrect = false;
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    incorrect = true;
                }
            }while(incorrect);
            return number;
        }
        public static int AskUserForOperation()
        {
            int operation = 0;
            bool incorrect;
            do
            {
                Console.Write("Select an operation :" +
                            "\n\t1. Addition" +
                            "\n\t2. Subtraction" +
                            "\n\t3. Multiplication" +
                            "\n\t4. Division" +
                            "\n> ");
                string input = Console.ReadLine();
                try
                {
                    operation = int.Parse(input);
                    if (operation > 0 && operation < 5)
                    {
                        incorrect = false;
                    }
                    else
                    {
                        Console.WriteLine("Error : Invalid operation");
                        incorrect = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    incorrect = true;
                }
            }while(incorrect);
            return operation;
        }
        public static bool AskUserForContinue()
        {
            bool response = false;
            bool incorrect;
            do
            {
                Console.Write("Do you want to continue ? (y/n) : ");
                string input = Console.ReadLine();
                if (input.ToLower() == "y")
                {
                    response = true;
                    incorrect = false;
                } else if (input.ToLower() == "n")
                {
                    response = false;
                    incorrect = false;
                } else {
                    Console.WriteLine("Error : Invalid input");
                    incorrect = true;
                }
            }while(incorrect);
            return response;
        }
    }
}
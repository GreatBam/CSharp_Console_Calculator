using System;
using System.Xml.XPath;

namespace calculator
{
    internal class Tools
    {
        public double AskUserForNumber(string message)
        {
            double number = 0;
            bool incorrect;
            do
            {
                Console.Write(message);
                string input = Console.ReadLine();
                try
                {
                    number = double.Parse(input);
                    incorrect = false;
                }
                catch
                {
                    Console.WriteLine("Error : Invalid input");
                    incorrect = true;
                }
            }while(incorrect);
            return number;
        }
        public double AskUserForOperation()
        {
            double operation = 0;
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
                    operation = double.Parse(input);
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
                    Console.WriteLine("Error : Invalid input");
                    incorrect = true;
                }
            }while(incorrect);
            return operation;
        }
        public double DisplayResult(double operation, double number1, double number2)
        {
            double result = 0;
            switch (operation)
            {
                case 1:
                    result = number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3:
                    result = number1 * number2;
                    break;
                case 4:
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Error : Invalid operation");
                    break;
            }
            result = Math.Round(result,2);
            return result;
        }
        public bool AskUserForContinue()
        {
            bool response = false;
            bool incorrect;
            do
            {
                Console.Write("Continue with this result ? (y/n) : ");
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
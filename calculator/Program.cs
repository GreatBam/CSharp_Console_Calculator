using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int number1 = Tools.AskUserForNumber("Enter the first number : ");
            int userOperator = Tools.AskUserForOperation();
            int number2 = Tools.AskUserForNumber("Enter the second number : ");
            switch (userOperator)
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
            Console.WriteLine("Your result : " + result);
        }
    }
}
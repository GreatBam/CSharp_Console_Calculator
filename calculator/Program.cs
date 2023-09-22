using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again;
            int finalResult;
            Tools tool = new Tools();
            do
            {
                int number1 = tool.AskUserForNumber("Enter the first number : ");
                int userOperator = tool.AskUserForOperation();
                int number2 = tool.AskUserForNumber("Enter the second number : ");
                finalResult = tool.DisplayResult(userOperator, number1, number2);
                Console.WriteLine("Your result : " + finalResult);
                Console.WriteLine();
                again = tool.AskUserForContinue();
            }while (again);
        }
    }
}
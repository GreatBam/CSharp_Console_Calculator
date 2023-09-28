using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = false;
            double number1 = 0;
            double finalResult = 0;
            Tools tool = new Tools();
            do
            {
                if(again == true)
                {
                    Console.WriteLine("Actual number : " + finalResult);
                    number1 = finalResult;
                }
                else
                {
                    number1 = tool.AskUserForNumber("Enter the first number : ");
                }
                int userOperator = tool.AskUserForOperation();
                double number2 = tool.AskUserForNumber("Enter the second number : ");
                finalResult = tool.DisplayResult(userOperator, number1, number2);
                Console.WriteLine("Your result : " + finalResult);
                Console.WriteLine();
                again = tool.AskUserForContinue();
            }while (again);
        }
    }
}
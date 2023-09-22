using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again;
            Tools tool = new Tools();
            do
            {
                int number1 = tool.AskUserForNumber("Enter the first number : ");
                int userOperator = tool.AskUserForOperation();
                int number2 = tool.AskUserForNumber("Enter the second number : ");
                tool.DisplayResult(userOperator, number1, number2);
                again = tool.AskUserForContinue();
            }while (again);
        }
    }
}
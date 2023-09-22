using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            do
            {
                int number1 = Tools.AskUserForNumber("Enter the first number : ");
                int userOperator = Tools.AskUserForOperation();
                int number2 = Tools.AskUserForNumber("Enter the second number : ");
                Tools.DisplayResult(userOperator, number1, number2);
                again = Tools.AskUserForContinue();
            }while (again);
        }
    }
}
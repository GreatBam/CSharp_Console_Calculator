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
            Calculator calculator = new Calculator();
            do
            {
                if(again == true)
                {
                    Console.WriteLine("Actual number : " + finalResult);
                    number1 = finalResult;
                }
                else
                {
                    number1 = calculator.AskUserForNumber("Enter the first number : ");
                }
                int userOperator = calculator.AskUserForOperation();
                double number2 = calculator.AskUserForNumber("Enter the second number : ");
                finalResult = calculator.DisplayResult(userOperator, number1, number2);
                Console.WriteLine("Your result : " + finalResult);
                Console.WriteLine();
                again = calculator.AskUserForContinue();
            }while (again);
        }
    }
}
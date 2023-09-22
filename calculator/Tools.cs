using System;

namespace calculator
{
    internal class Tools
    {
        public static int AskUserForNumber(string message)
        {
            int number = 0;
            Console.Write(message);
            string input = Console.ReadLine();
            try
            {
                number = int.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
                throw;
            }
            return number;
        }
        public static int AskUserForOperation()
        {
            int operation = 0;
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
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
                throw;
            }
            return operation;
        }
    }
}
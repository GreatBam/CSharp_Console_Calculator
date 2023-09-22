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
    }
}
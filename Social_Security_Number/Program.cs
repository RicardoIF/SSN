using System;
using SSN_;

namespace Social_Security_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            Console.Write("Write your Social Security Number: ");
            string number = Console.ReadLine();

            Digits digits = new Digits(number);
            result = digits.Magnitud();
            if (result != "Your SSM is correct.")
            {
                Console.WriteLine(result);
                Console.ReadKey();
                Environment.Exit(-1);
            }
            result = digits.Separate();
            if (result != "Your SSM is correct.")
            {
                Console.WriteLine(result);
                Console.ReadKey();
                Environment.Exit(-1);
            }
            result = digits.FirstPart();
            if (result != "Your SSM is correct.")
            {
                Console.WriteLine(result);
                Console.ReadKey();
                Environment.Exit(-1);
            }
            result = digits.SecondPart();
            if (result != "Your SSM is correct.")
            {
                Console.WriteLine(result);
                Console.ReadKey();
                Environment.Exit(-1);
            }
            result = digits.ThirdPart();
            if (result != "Your SSM is correct.")
            {
                Console.WriteLine(result);
                Console.ReadKey();
                Environment.Exit(-1);
            }
            else
            {
                Console.WriteLine("Your SSM is correct.");
                Console.ReadKey();
                Environment.Exit(-1);
            }
        }
    }
}

using System;
using static System.Console;
namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 0 and 255: ");
            String first = ReadLine();
            Console.Write("Enter another number between 0 and 255: ");
            String second = ReadLine();
            try
            {
                int num1 = int.Parse(first);
                int num2 = int.Parse(second);
                Write(num1 + " divided by "+ num2 + " is " + num1/num2);
            }
            catch (FormatException ex)
            {
               WriteLine(ex.Message);
            }
        }
    }
}

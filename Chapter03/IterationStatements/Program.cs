using System;
using static System.Console;
namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            WriteLine("\n");
            string password = string.Empty;
            do
            {
                Write("Enter your password: ");
                password = ReadLine();
            }
            while (password != "Pa$$w0rd");
            WriteLine("Correct!\n");

            for (int y = 1; y <= 10; y++)
            {
                WriteLine(y);
            }

            WriteLine("\n");
            string[] names = { "Adam", "Barry", "Charlie" };
            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}

﻿using System;
using static System.Console;
namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Write("fizzbuzz, ");
                }
                else if (i % 3 == 0)
                {
                    Write("fizz, ");
                }
                else if (i % 5 == 0)
                {
                    Write("buzz, ");
                }
                else
                {
                    Write(i+", ");
                }
                 
            }
        }
    }
}

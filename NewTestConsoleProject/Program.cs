using System;

namespace NewTestConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our console app!");
            Console.WriteLine("Let's begin!");
            Console.WriteLine("Enter first number...");
            Console.WriteLine("Enter second number...");
            Console.WriteLine(MyCalc.Sum(3, 5));
        }
    }

    static class MyCalc
    {
        static public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}

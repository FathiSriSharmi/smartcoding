﻿using System;

namespace SmartCoding
{
    //I am Shebee .. Writting THis COmment line..
    public class Program
    {
        public static bool IsPrime(long n)
        {
            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        //cherrybunny......
        private static void Main(string[] args)
        {
            long numberToTest = 3367900313;
            IsPrime(numberToTest);
            Console.ReadLine();
        }

        private static void Calc()
        {
            Console.WriteLine("Make a choice");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.WriteLine(a + b); break;
                case 2: Console.WriteLine(a - b); break;
                case 3: Console.WriteLine(a * b); break;
                case 4: Console.WriteLine(a / b); break;
            }

            Console.ReadLine();
        }
    }
}
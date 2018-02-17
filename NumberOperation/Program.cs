using System;
using System.Collections.Generic;
using NumberOperationTest;

namespace NumberOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            Number operation = new Number();
            int sum = operation.AddDigits(number);
            Console.WriteLine(sum);

            int quotient = operation.DivideDigits(number);
            Console.WriteLine(quotient);

            Console.ReadKey();
        }
    }
}

using System;
using System.ComponentModel.Design;

namespace Class_Assignment
{
    public class Program
    {
     
        static void Main(string[] args)
        {
                int lintA, lintB, lintC;


                Console.WriteLine("Enter value for a");
                lintA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value for b");
                lintB = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value for c");
                lintC = Convert.ToInt32(Console.ReadLine());


                int lintSum = SimpleCode.Add(lintA, lintB);
                lintSum = SimpleCode.Add(lintSum, lintC);
                int lintSub = SimpleCode.Subtraction(lintA, lintB);
                int lintMultiply = SimpleCode.Multiply(lintA, lintB);
                float lintDiv = SimpleCode.Division(lintA, lintB);
                Console.WriteLine("Addition=" + lintSum);
                Console.WriteLine("Substaction=" + lintSub);
                Console.WriteLine("multiplication=" + lintMultiply);
                Console.WriteLine("Division=" + lintDiv);


                int lintmod = SimpleCode.mod(lintA, lintB);
                Console.WriteLine("mod =" + lintmod);


                Console.Write("Enter a number to find factorial: ");
                int number = Convert.ToInt32(Console.ReadLine());
                long result = SimpleCode.Factorial(number);
                Console.WriteLine($"Factorial of {number} is: {result}");


                int lintavg = SimpleCode.Avg(lintA, lintB);
                Console.WriteLine("Avg =" + lintavg);


                Console.Write("Enter a number: ");
                int Number = Convert.ToInt32(Console.ReadLine());

              if (SimpleCode.IsPrime(number))
                   Console.WriteLine($"{number} is a prime number.");
              else
                    Console.WriteLine($"{number} is not a prime number.");


                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter third number: ");
                int num3 = Convert.ToInt32(Console.ReadLine());
                int max = num1;
              if (num2 > max)
                   max = num2;
             else if (num3 > max)
                   max = num3;
             else
                    max = num3;
                    Console.WriteLine("The maximum number is: " + max);







        }

    }

}


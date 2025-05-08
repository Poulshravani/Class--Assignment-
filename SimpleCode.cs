using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    internal class SimpleCode
    {


        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static float Division(int a, int b)
        {
            return (float)a / b;
        }

        public static int mod(int a, int b)
        {
            return a % b;
        }


        public static long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers.");

            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;

        }

        public static int Avg(int a, int b)
        {
            return (a + b) / 2;
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1) 
                return false;

            if (n == 2)
                return true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;


        }
    }   
}
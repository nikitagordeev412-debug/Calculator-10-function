using System;
using System.Collections.Generic;
using System.Text;

namespace Subjects
{
    public class Math
    {
        public double sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public double subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public double mult(int num1, int num2)
        {
            return num1 * num2;
        }

        public double division(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
                return 0;
            }
            return (double)num1 / num2;
        }
        public double power(double num1, double num2)
        {
            return System.Math.Pow(num1, num2);
        }
        public double sqrt(double num1)
        {
            if (num1 < 0)
            {
                Console.WriteLine("Корень из минуса не бывает");
                return 0;
            }
            return System.Math.Sqrt(num1);
        }
        public double remainder(int num1, int num2)
        {
            if (num2 == 0) return 0;
            return num1 % num2;
        }
        public double min(int num1, int num2)
        {
            return System.Math.Min(num1, num2);
        }
        public double max(int num1, int num2)
        {
            return System.Math.Max(num1, num2);
        }
        public double sin(double num1)
        {
            return System.Math.Sin(num1);
        }


    }
}

using System;
using Subjects;

class Program
{
    static void Main()
    {
        Subjects.Math clsmath = new Subjects.Math();

        Console.WriteLine("Простой калькулятор");
        Console.WriteLine("Введите первое число:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Результаты:");
        Console.WriteLine("Сложение: " + clsmath.sum(num1, num2));
        Console.WriteLine("Вычитание: " + clsmath.subtraction(num1, num2));
        Console.WriteLine("Умножение: " + clsmath.mult(num1, num2));
        Console.WriteLine("Деление: " + clsmath.division(num1, num2));
        Console.WriteLine("Степень: " + clsmath.power(num1, num2));
        Console.WriteLine("Корень (из 1-го): " + clsmath.sqrt(num1));
        Console.WriteLine("Остаток от деления: " + clsmath.remainder(num1, num2));
        Console.WriteLine("Минимум: " + clsmath.min(num1, num2));
        Console.WriteLine("Максимум: " + clsmath.max(num1, num2));
        Console.WriteLine("Синус (1-го): " + clsmath.sin(num1));
    }
}

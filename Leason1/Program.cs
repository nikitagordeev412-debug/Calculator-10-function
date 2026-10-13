using System;

namespace Lesson1
{
    class Program
    {
        static void Main()
        {
            Subjects.Math clcmath = new Subjects.Math();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== КАЛЬКУЛЯТОР ===");
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Сложение");
                Console.WriteLine("2 - Вычитание");
                Console.WriteLine("3 - Умножение");
                Console.WriteLine("4 - Деление");
                Console.WriteLine("5 - Возведение в степень");
                Console.WriteLine("6 - Корень (из 1-го числа)");
                Console.WriteLine("7 - Остаток от деления");
                Console.WriteLine("8 - Минимум");
                Console.WriteLine("9 - Максимум");
                Console.WriteLine("10 - Синус (1-го числа)");
                Console.WriteLine("0 - Выход");
                Console.Write("Ваш выбор: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    break;
                }

                Console.Write("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                int num2 = 0;
                if (choice != 6 && choice != 10)
                {
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }

                if (choice == 1) Console.WriteLine("Результат: " + clcmath.sum(num1, num2));
                if (choice == 2) Console.WriteLine("Результат: " + clcmath.subtraction(num1, num2));
                if (choice == 3) Console.WriteLine("Результат: " + clcmath.mult(num1, num2));
                if (choice == 4) Console.WriteLine("Результат: " + clcmath.division(num1, num2));
                if (choice == 5) Console.WriteLine("Результат: " + clcmath.power(num1, num2));
                if (choice == 6) Console.WriteLine("Результат: " + clcmath.sqrt(num1));
                if (choice == 7) Console.WriteLine("Результат: " + clcmath.remainder(num1, num2));
                if (choice == 8) Console.WriteLine("Результат: " + clcmath.min(num1, num2));
                if (choice == 9) Console.WriteLine("Результат: " + clcmath.max(num1, num2));
                if (choice == 10) Console.WriteLine("Результат: " + clcmath.sin(num1));

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }
}

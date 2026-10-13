using System;
using Subjects;

namespace Lesson1
{
    class Program
    {
        static void Main()
        {
            Subjects.Math clcmath = new Subjects.Math();

            string[] history = new string[100];
            int count = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("МЕНЮ:");
                Console.WriteLine("1 - Сложение");
                Console.WriteLine("2 - Вычитание");
                Console.WriteLine("3 - Умножение");
                Console.WriteLine("4 - Деление");
                Console.WriteLine("5 - Степень");
                Console.WriteLine("6 - Корень");
                Console.WriteLine("7 - Остаток от деления");
                Console.WriteLine("8 - Минимум");
                Console.WriteLine("9 - Максимум");
                Console.WriteLine("10 - Синус");
                Console.WriteLine("11 - Показать историю");
                Console.WriteLine("0 - Выход");
                Console.Write("Выберите пункт: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    break;
                }

                if (choice == 11)
                {
                    Console.WriteLine("--- ИСТОРИЯ ---");
                    if (count == 0)
                    {
                        Console.WriteLine("Пока пусто.");
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine(history[i]);
                        }
                    }
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                int num2 = 0;
                if (choice != 6 && choice != 10)
                {
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }

                double result = 0;
                string text = "";

                switch (choice)
                {
                    case 1:
                        result = clcmath.sum(num1, num2);
                        text = num1 + " + " + num2 + " = " + result;
                        break;
                    case 2:
                        result = clcmath.subtraction(num1, num2);
                        text = num1 + " - " + num2 + " = " + result;
                        break;
                    case 3:
                        result = clcmath.mult(num1, num2);
                        text = num1 + " * " + num2 + " = " + result;
                        break;
                    case 4:
                        result = clcmath.division(num1, num2);
                        text = num1 + " / " + num2 + " = " + result;
                        break;
                    case 5:
                        result = clcmath.power(num1, num2);
                        text = num1 + " ^ " + num2 + " = " + result;
                        break;
                    case 6:
                        result = clcmath.sqrt(num1);
                        text = "Корень из " + num1 + " = " + result;
                        break;
                    case 7:
                        result = clcmath.remainder(num1, num2);
                        text = num1 + " % " + num2 + " = " + result;
                        break;
                    case 8:
                        result = clcmath.min(num1, num2);
                        text = "Минимум: " + result;
                        break;
                    case 9:
                        result = clcmath.max(num1, num2);
                        text = "Максимум: " + result;
                        break;
                    case 10:
                        result = clcmath.sin(num1);
                        text = "Синус " + num1 + " = " + result;
                        break;
                    default:
                        Console.WriteLine("Нет такого пункта!");
                        Console.ReadKey();
                        continue;
                }
                
            
            

                Console.WriteLine("Результат: " + text);
                if (count < history.Length)
                {
                    history[count] = text;
                    count = count + 1;
                }

                Console.WriteLine("Нажмите клавишу...");
                Console.ReadKey();
            }
        }
    }
}

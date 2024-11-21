using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Task5_1();
            Task5_2();
            Task5_3();
            Task5_4();
            Htask5_2();
        }
        static void Task5_1()
        {
            Console.WriteLine("Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные параметры метода – два целых числа.");
            Console.WriteLine("Введите 1 число");
            int num1 = Checkingint();
            Console.WriteLine("Введите 2 число");
            int num2 = Checkingint();
            Console.WriteLine($"Максимум равен {Math.Max(num1, num2)}");
        }
        static int Checkingint()
        {
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
                Console.Write("Неверный ввод!\nПовторите: ");
            return x;
        }
        static void Task5_2()
        {
            Console.WriteLine("Упражнение 5.2 Написать метод, который меняет местами значения двух передаваемых параметров.Параметры передавать по ссылке.");
            Console.WriteLine("Введите 1 число");
            int num1 = Checkingint();
            Console.WriteLine("Введите 2 число");
            int num2 = Checkingint();
            Swap(ref num1, ref num2);
            Console.WriteLine($"num1 = {num1}, num2 = {num2}");
        }
        static void Swap(ref int num1, ref int num2)
        {
            int interium = num1;
            num1 = num2;
            num2 = interium;
        }
        static void Task5_3()
        {
            Console.WriteLine("Упражнение 5.3 Написать метод вычисления факториала числа, результат вычислений передавать в выходном параметре.Если метод отработал успешно, то вернуть значение true; если в процессе вычисления возникло переполнение, то вернуть значение false.Для отслеживания переполнения значения использовать блок checked.");
            Console.WriteLine("Введите число");
            int numb = Checkingint();
            int cook = Factorial(numb);
            if (cook > 0)
            {
                Console.WriteLine($"Факториал равен {cook}");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static int Factorial(int x)
        {
            try
            {
                int f = 1;
                for (int i = 1; i < x; i++)
                {
                    f = checked(f * i);
                }
                return f;
            }
            catch
            {
                return -1;
            }
        }
        static void Task5_4()
        {
            Console.WriteLine("Упражнение 5.4 Написать рекурсивный метод вычисления факториала числа.");
            int numb = Checkingint();
            int answer = Recurtionfac(numb);
            Console.WriteLine($"Факториал равен {answer}");
        } 
        static int Recurtionfac(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Recurtionfac(n - 1);
        }
        static void Htask5_2()
        {
            Console.WriteLine("Домашнее задание 5.2 Написать рекурсивный метод, вычисляющий значение n-го числа ряда Фибоначчи.Ряд Фибоначчи – последовательность натуральных чисел 1, 1, 2, 3, 5, 8, 13... Для таких чисел верно соотношение Fk = Fk - 1 + Fk - 2.");
            int numb = Checkingint();
            int donejob = Fibonachi(numb);
            Console.WriteLine($"Число Фибоначчи равно {donejob}");
        }
        static int Fibonachi(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }

    }
}

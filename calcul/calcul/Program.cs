using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую в калькуляторе!");

            Console.WriteLine("Введите первое число:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберете операцию (+, -, *, /):");
            char OP = char.Parse(Console.ReadLine());

            double result = 0;

            switch (OP)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num2 - num1;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 * num2;
                    else Console.WriteLine("Делитель не может быть 0!");
                    break;

                default:
                    break;
            }
            Console.WriteLine("Результат:");
            Console.WriteLine(result);
        }
    }
}
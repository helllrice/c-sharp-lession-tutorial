using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    internal class Program
    {

        // мега простой калькулятор в консоли
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string action;

            Console.WriteLine("Введите первое число");
            firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите первое число");
            secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
                case "-":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case "*":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("на ноль делить нельзя!!!!!!");
                    }
                    else
                    {
                        Console.WriteLine(firstNumber / secondNumber);
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка!!!!! такой операции нету в списке");
                    break;
            }
        }
    }
}

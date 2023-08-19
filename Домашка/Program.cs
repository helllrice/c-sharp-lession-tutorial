using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


// 1.Напишите программу, вычисляющую среднее арифметическое двух чисел.

// 2. Введите три числа и выведите на экран значение суммы и произведения этих чисел.

// 3. Конвертер Валют 

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            Console.WriteLine("Введите число 1");
            firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            secondValue = double.Parse(Console.ReadLine());
            double result = (firstValue + secondValue) / 2;
            Console.WriteLine("наше среднее число  =  " + result);


            Console.WriteLine("Теперь второе задание !!!!");


            double numberOne, numberTwo, numberTree;
            Console.WriteLine("Введите число 1");
            numberOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            numberTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 3");
            numberTree = double.Parse(Console.ReadLine());
            double sumResult = numberOne + numberTwo + numberTree;
            Console.WriteLine("наша сумма трех чисел = " + sumResult);
            double productOfnumbers = numberOne * numberTwo * numberTree;
            Console.WriteLine("Произведение трех чисел = " +  productOfnumbers);

            Console.WriteLine("Теперь третье задание !!!!!!!");

            double UsdToRub = 66.29;
            double UsdToUah = 27.24;
            double USD;

            Console.WriteLine("Введите сумму в USD");
            USD = double.Parse(Console.ReadLine());
            Console.WriteLine("Ваш USD в рублях составит =  " +  (USD * UsdToRub));
            Console.WriteLine("А в Uah USD составит =  " + (USD * UsdToUah));
        }
    }
}

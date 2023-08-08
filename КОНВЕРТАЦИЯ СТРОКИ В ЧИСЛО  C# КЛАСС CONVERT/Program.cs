using System;
using System.Globalization;

//конвртация строки
//    класс Convert


namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;

            int a, b;

            Console.WriteLine("Введите число 1");
            
            str = Console.ReadLine();

            a = Convert.ToInt32(str);

            Console.WriteLine("Введите число 2");

            str = Console.ReadLine();

            b = Convert.ToInt32(str);

            int result = a + b;

            Console.WriteLine("Сумма чисел = " + result);


            string str2 = "1.9";

            //Предоставляет сведения для конкретного языка и региональных параметров для числовых значений форматирования и анализа.

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double a2 = Convert.ToDouble(str2, numberFormatInfo);
        }


    }


}

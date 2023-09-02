using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
// домашка 
// проверка числа на четность 


{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int a;
            string str;
            Console.WriteLine("Введите число");
            str = Console.ReadLine();

            a = Convert.ToInt32(str);

            if (a % 2 == 0)
            {
                Console.WriteLine("число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }
        }

    }

}


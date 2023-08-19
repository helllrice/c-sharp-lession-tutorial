using System;
using System.Globalization;


// инкримент и дикримент 

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {

            // постфиксная форма инкримента и дикримента


            int a = 1;
            a++;
            a--;


            Console.WriteLine(a);

            // префиксная форма инкримента и дикримента

            int b = 2;
            ++b;
            --b;


            Console.WriteLine(b);

            // фишка в разнице приоритевов 

            int с2 = 3;
            Console.WriteLine(с2++); // изменения вступят в силу после выполнения данной строки

            int c1 = 3;
            Console.WriteLine(++c1); // а тут консоль выведет сразу результат "4"

        }
    }

}

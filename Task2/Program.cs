using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int chilso = int.Parse(Console.ReadLine());  // число в десятичной
            Console.WriteLine("Введите основание: ");
            int osnovanie = int.Parse(Console.ReadLine());  // основание числа
            string result = "";     // переменная для результата
            int temp = 0;
            Console.WriteLine("Число в 10-ой системе = " + chilso);

            if (chilso > 0)     // условие, что число больше 0
                while (chilso >= (osnovanie - 1))   // пока число больше самого основания
                {
                    temp = chilso % osnovanie;
                    chilso = (chilso - temp) / osnovanie;
                    result = Convert.ToString(temp) + result;
                }
            result = Convert.ToString(chilso) + result;
            Console.WriteLine("Число в " + osnovanie + "-ой системе = " + result);
        }
    }
}

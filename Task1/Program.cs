using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int kol = 1;
            int max = 0;
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            for (int i = 0; i < (str.Length - 1); i++)
            {
                if (str[i] != str[i + 1])
                {
                    kol++;
                    max = kol;
                }
                else
                {
                    kol = 1;
                }
            }
            Console.WriteLine(max);
        }
    }
}

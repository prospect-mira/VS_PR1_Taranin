using System;

namespace VS_Пр_01_Таранин
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для генерации таблицы умножения : ");
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                GenerateTableUmnaz(number);
            }
            else
            {
                Console.WriteLine("Пожалуйста,введите положительное число.");
            }
            static void GenerateTableUmnaz(int number)
            {
                Console.WriteLine($"\nТаблица умножения до числа {number}:");
                Console.Write("   |");
                for (int i = 1; i <= number; i++)
                {
                    Console.Write($"{i,4}");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 4 * (number + 1)));

                for (int i = 1; i <= number; i++)
                {
                    Console.Write($"{i,3} |");
                    for (int j = 1; j <= number; j++)
                    {
                        Console.Write($"{i * j,4}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

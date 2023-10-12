using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер дня недели:");
        int dayOfWeek = int.Parse(Console.ReadLine());

        // Проверяем, является ли введенный день выходным (6 или 7)
        if (dayOfWeek == 6 || dayOfWeek == 7)
        {
            Console.WriteLine("Да, это выходной день.");
        }
        else
        {
            Console.WriteLine("Нет, это не выходной день.");
        }
    }
}






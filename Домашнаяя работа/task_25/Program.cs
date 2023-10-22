using System;

class Program
{
    static void Main()
    {
        // Получаем числа A и B от пользователя
        Console.Write("Введите число A: ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Введите число B: ");
        int B = int.Parse(Console.ReadLine());

        // Инициализируем переменную для хранения результата
        int результат = 1;

        // Цикл для возвведения числа A в степень B
        for (int i = 1; i <= B; i++)
        {
            результат *= A;
        }

        // Выводим результат
        Console.WriteLine($"Результат: {результат}");
    }
}
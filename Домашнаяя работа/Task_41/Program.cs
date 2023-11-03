using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя количество чисел, которые он хочет ввести
        Console.Write("Введите количество чисел: ");
        int M = int.Parse(Console.ReadLine());

        // Инициализируем счетчик положительных чисел
        int countPositive = 0;

        // Считываем числа и проверяем, являются ли они положительными
        for (int i = 0; i < M; i++)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                countPositive++;
            }
        }

        // Выводим количество положительных чисел
        Console.WriteLine("Количество положительных чисел: " + countPositive);
    }
}
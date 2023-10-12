/*
22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4

*/

Console.WriteLine("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Таблица квадратов чисел от 1 до " + N + ":");
        for (int i = 1; i <= N; i++)
        {
            System.Console.WriteLine($"{i} * {i} = {Math.Pow(i,2)}");
        }

        Console.WriteLine(); // Переход на новую строку после вывода таблицы
    
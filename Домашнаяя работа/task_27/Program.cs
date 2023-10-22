﻿using System;

class Program
{
    static void Main()
    {
        // Получаем число от пользователя
        Console.Write("Введите число: ");
        int входное_число = int.Parse(Console.ReadLine());

        // Вычисляем сумму цифр в числе, используя функцию
        int результат = СуммаЦифр(входное_число);

        // Выводим результат
        Console.WriteLine($"Сумма цифр в числе: {результат}");
    }

    // Функция для вычисления суммы цифр в числе
    static int СуммаЦифр(int число)
    {
        // Инициализируем переменную для хранения суммы цифр
        int сумма = 0;

        // Пока число не станет равно нулю, выделяем последнюю цифру и добавляем к сумме
        while (число > 0)
        {
            сумма += число % 10; // Получаем последнюю цифру числа
            число /= 10; // Убираем последнюю цифру числа
        }

        // Возвращаем сумму цифр
        return сумма;
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());

        // Получаем третью цифру числа
        int thirdDigit = GetThirdDigit(number);

        if (thirdDigit != -1)
        {
            Console.WriteLine("Третья цифра числа: " + thirdDigit);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет в введенном числе.");
        }
    }

    static int GetThirdDigit(int number)
    {
        // Преобразуем число в строку для удобства работы со строками
        string numberString = number.ToString();

        // Проверяем, является ли число трехзначным и имеет ли третью цифру
        if (numberString.Length >= 3)
        {
            // Получаем третью цифру, индексы начинаются с 0
            return int.Parse(numberString[2].ToString());
        }
        else
        {
            // Если число не трехзначное, возвращаем -1 как признак отсутствия третьей цифры
            return -1;
        }
    }
}
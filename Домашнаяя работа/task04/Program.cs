using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        // Проверяем, является ли число пятизначным
        if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Число не пятизначное");
            Console.WriteLine("False");
            return false;
        }

        // Преобразуем число в строку для удобства проверки палиндрома
        string numberStr = number.ToString();
        int left = 0;
        int right = numberStr.Length - 1;

        // Проверяем, является ли число палиндромом
        while (left < right)
        {
            if (numberStr[left] != numberStr[right])
            {
                Console.WriteLine("False");
                return false;
            }
            left++;
            right--;
        }

        Console.WriteLine("True");
        return true;
    }

    // Не удаляйте и не меняйте метод Main!
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
    }
}
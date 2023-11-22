using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Результат: " + GetNaturalNumbers(N));
    }

    static string GetNaturalNumbers(int n)
    {
        if (n == 1)
        {
            return "1";
        }
        else
        {
            return n + ", " + GetNaturalNumbers(n - 1);
        }
    }
}
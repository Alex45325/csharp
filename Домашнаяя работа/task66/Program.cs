using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        int sum = GetSumOfNaturalNumbers(M, N);

        Console.WriteLine($"Сумма натуральных элементов от {M} до {N}: {sum}");
    }

    static int GetSumOfNaturalNumbers(int m, int n)
    {
        if (m > n)
        {
            throw new ArgumentException("Значение M должно быть меньше или равно N.");
        }

        if (m == n)
        {
            return m;
        }
        else
        {
            return m + GetSumOfNaturalNumbers(m + 1, n);
        }
    }
}
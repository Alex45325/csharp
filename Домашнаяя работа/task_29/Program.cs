using System;

class Program
{
    static void Main()
    {
        // Задаем массив из 8 элементов
        int[] массив1 = {1, 2, 5, 7, 19};
        int[] массив2 = {6, 1, 33};

        // Выводим массивы на экран
        Console.Write("[");
        ВывестиМассив(массив1);
        Console.WriteLine("]");

        Console.Write("[");
        ВывестиМассив(массив2);
        Console.WriteLine("]");
    }

    // Функция для вывода массива на экран
    static void ВывестиМассив(int[] массив)
    {
        for (int i = 0; i < массив.Length; i++)
        {
            Console.Write(массив[i]);
            // Если элемент не последний, выводим запятую и пробел
            if (i < массив.Length - 1)
            {
                Console.Write(", ");
            }
        }
    }
}
Console.WriteLine("Введите трёхзначное число:");
        int number = int.Parse(Console.ReadLine());

        // Проверяем, является ли число трёхзначным
        if (number >= 100 && number <= 999)
        {
            // Получаем вторую цифру числа
            int secondDigit = (number / 10) % 10;
            Console.WriteLine("Вторая цифра числа: " + secondDigit);
        }
        else
        {
            Console.WriteLine("Ошибка! Введите трёхзначное число.");
        }
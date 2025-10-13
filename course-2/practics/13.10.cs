using System;

public static class practic13
{
    public static void Start()
    {
        //practic1
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"Число: " + i );
        }

        //practic2 
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Сумма чисел от 1 до 100: {sum}");

        //practic3
        Random random = new Random();
        int num = random.Next(1, 10);
        int userGuess = 0;
        Console.WriteLine("Угадайте число от 1 до 100!");
        while (userGuess != num)
        {
            Console.Write("Введите вашу догадку: ");
            userGuess = int.Parse(Console.ReadLine());
            if (num != userGuess)
            {
                Console.WriteLine("Неверное число");
            }
        }
        Console.WriteLine($"Поздравляю! Вы угадали число {num}!");

        //practic4 
        string password;
        do
        {
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();
        }
        while (password != "1234");

        Console.WriteLine("Пароль верный! Доступ разрешен.");

        //practic5
        string[] sity = { "Москва", "СПБ", "Ростов-на-Дону", "Кемерово", "Краснодар" };

        foreach (string sit in sity)
        {
            Console.WriteLine($"Город: " + sit);
        }

        //practic6
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 != 0)
            {
                continue;
            }
            Console.Write(i + " ");
        }
        Console.WriteLine();

        //practic7
        string Password = "1234";
        int maxAttempts = 3;
        int attempts = 0;

        while (attempts < maxAttempts)
        {
            Console.Write("Введите пароль: ");
            string pass = Console.ReadLine();
            attempts++;

            if (pass == Password)
            {
                Console.WriteLine("Доступ разрешён");
                break; 
            }
            else
            {
                Console.WriteLine($"Неверный пароль");
            }

            if (attempts == maxAttempts)
            {
                Console.WriteLine("Доступ запрещён");
            }
        }

        //practic8
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write($"{i * j,2}  ");
            }
            Console.WriteLine();
        } 
    }
}
using System;

public static class Practice20
{
    public static void Start()
    {
        //work 1
        Console.WriteLine("work 1");
        Console.WriteLine($"Factorial(3) = {Factorial(3)}");
        Console.WriteLine($"Factorial(5) = {Factorial(5)}");
        Console.WriteLine($"Factorial(7) = {Factorial(7)}");

        //work 2
        Console.WriteLine("\nwork 2");
        Console.Write("Первые 10 чисел Фибоначчи: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{Fibonacci(i)} ");
        }
        Console.WriteLine();

        //work 3
        Console.WriteLine("\nwork 3");
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Sum({n}) = {Sum(n)}");

        //work 4
        Console.WriteLine("\nwork 4");
        Console.Write("Введите число от 1 до 7: ");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Результат: {GetDayOfWeek(day)}");

        //work 5
        Console.WriteLine("\nwork 5");
        Calculator();

        //work 6
        Console.WriteLine("\nwork 6");
        Console.Write("Введите число от 1 до 90: ");
        int lotoNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Выходные данные: {GetLotoDescription(lotoNumber)}");
    }

    //1
    public static int Factorial(int n)
    {
        if (n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

    //2
    public static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    //3
    public static int Sum(int n)
    {
        if (n == 1)
            return 1;
        return n + Sum(n - 1);
    }

    //4
    public static string GetDayOfWeek(int day)
    {
        switch (day)
        {
            case 1:
                return "Понедельник";
            case 2:
                return "Вторник";
            case 3:
                return "Среда";
            case 4:
                return "Четверг";
            case 5:
                return "Пятница";
            case 6:
                return "Суббота";
            case 7:
                return "Воскресенье";
            default:
                return "Неверный номер дня";
        }
    }

    //5
    public static void Calculator()
    {
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите операцию (+, -, *, /): ");
        string operation = Console.ReadLine();

        double result = 0;
        bool error = false;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    error = true;
                }
                break;
            default:
                Console.WriteLine("Ошибка: неизвестная операция!");
                error = true;
                break;
        }

        if (!error)
            Console.WriteLine($"Результат: {result}");
    }

    //6
    public static string GetLotoDescription(int number)
    {
        if (number < 1 || number > 90)
            return "Число должно быть от 1 до 90";

        switch (number)
        {
            case 1:
                return "Кол";
            case 11:
                return "Барабанные палочки";
            case 22:
                return "Гуси-лебеди";
            case 33:
                return "Кудри";
            case 44:
                return "Стульчики";
            case 55:
                return "Перчатки";
            case 66:
                return "Валенки";
            case 77:
                return "Топорики";
            case 80:
                return "Бабушка";
            case 90:
                return "Дедушка";
            default:
                return "Ничего не найдено";
        }
    }
}
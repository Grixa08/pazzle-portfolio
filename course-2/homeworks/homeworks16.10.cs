using System;
public static class homework16{
    public static void Start()
    {
        //work 1
        // Метод для вычисления среднего значения массива
        double Average(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return (double)sum / numbers.Length;
        }
        int[] numbers = { 2, 4, 6, 8 };
        double average = Average(numbers);
        Console.WriteLine("Среднее арифметическое: " + average);

        //work2
            Console.WriteLine("Введите выражения в формате: число операция число");
            Console.WriteLine("Например: 5 + 3");
            Console.WriteLine("Для выхода введите 'exit'");

            while (true)
            {
                try
                {
                    Console.Write("Введите выражение (или exit): ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "exit")
                    {
                        Console.WriteLine("Программа завершена");
                        break;
                    }

                    string[] parts = input.Split(' ');

                    if (parts.Length != 3)
                    {
                        Console.WriteLine("Ошибка: неверный формат. Используйте: число операция число");
                        continue;
                    }

                    double num1 = double.Parse(parts[0]);
                    double num2 = double.Parse(parts[2]);
                    string operation = parts[1];

                    double result = 0;

                    switch (operation)
                    {
                        case "+":
                            result = Add(num1, num2);
                            break;
                        case "-":
                            result = Subtract(num1, num2);
                            break;
                        case "*":
                            result = Multiply(num1, num2);
                            break;
                        case "/":
                            result = Divide(num1, num2);
                            break;
                        default:
                            Console.WriteLine("Ошибка: неизвестная операция. Используйте +, -, *, /");
                            continue;
                    }

                    Console.WriteLine($"Результат: {result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введите корректные числа!");
                }
            }
        }
    public static double Add(double a, double b)
    {
        return a + b;
    }
    public static double Subtract(double a, double b)
    {
        return a - b;
    }
    public static double Multiply(double a, double b)
    {
        return a * b;
    }
    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.Write("Ошибка: деление на ноль!");
        }
        return a / b;
    }
}

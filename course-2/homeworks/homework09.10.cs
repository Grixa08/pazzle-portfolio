using System;

public static class homework09
{
    public static void Start()
    {
        //work1
        int[] numbers = { 2, 5, 3, 5, 5, 4, 3};

        int five = 0;
        int two = 0;
        foreach (int number in numbers) {
            if (number == 5)
            {
                five++;
            }
            else if (number == 2)
            {
                two++;
            }
        }
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        double average = (double)sum / numbers.Length;
        Console.WriteLine($"Количество пятерок: {five} ");
        Console.WriteLine($"Количество двоек: {two} ");
        Console.WriteLine($"Среднее арифметическое: {average:F2}");

        //work2
        int[] num = { 3, 4, 7, 1, 56 };

        Console.WriteLine("Массив в прямом порядке:");
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Массив в обратном порядке:");
        for (int i = num.Length - 1; i >= 0; i--)
        {
            Console.Write(num[i] + " ");
        }
    }
}
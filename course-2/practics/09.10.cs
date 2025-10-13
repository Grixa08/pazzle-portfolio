using System;

public static class practic09
{
    public static void Start()
    {
        //practic 1
        int[] num = new int[5];

        num[0] = 1;
        num[1] = 2;
        num[2] = 3;
        num[3] = 4;
        num[4] = 5;

        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine("Элемент " + i + ": " + num[i]);
        }

        //practic 2
        int[] grades = { 3, 4, 2, 5, 4, 4 };
        Console.WriteLine("Оценки:");
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write(grades[i] + " ");
        }
        Console.WriteLine();
        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        double average = (double)sum / grades.Length;
        Console.WriteLine($"Среднее арифметическое: {average:F2}");

        //practic 3
        int[] ints = { 55, 35, 87, 79, 23, 39, 92, 1 };
        int max = ints[0];
        for (int i = 1; i < ints.Length; i++)
        {
            if (ints[i] > max)
            {
                max = ints[i];
            }
        }
        Console.WriteLine(max);

        //practic 4
        int[] numbers = { 2, 7, 15, 9, 3, 12, 3, 8, 4, 11 };

        int chet = 0;
        int nochet = 0;

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                chet++;
            }
            else
            {
                nochet++;
            }
        }

        Console.WriteLine("Четных = " + chet);
        Console.WriteLine("Нечетных = " + nochet);

        //practic 5
        string[] fruits = { "яблоко", "банан", "груша", "авакадо", "манго" };

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        //practic 6
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
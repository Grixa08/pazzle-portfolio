using System;
public static class practic02
{
    public static void Start()
    {
        //work 1
        Console.WriteLine("Введите градусы в цельсиях(через ',')");
        float C = float.Parse(Console.ReadLine());
        float F = C * 9 / 5 + 32;
        Console.WriteLine(F);

        //work 2
        Console.WriteLine("Введите целое число 'a'.");
        int A = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите целое число 'b'.");
        int B = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите целое число 'd'.");
        int D = int.Parse(Console.ReadLine());
        double sum = A + B + D;
        double average = sum / 3;
        Console.WriteLine(average);

        //work 3
        Console.WriteLine("Введите первое число");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int num2 = int.Parse(Console.ReadLine());

        double sum2 = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double quotient = num2 != 0 ? num1 / num2 : double.NaN;

        Console.WriteLine($"Сумма: {num1} + {num2} = {sum}");
        Console.WriteLine($"Разность: {num1} - {num2} = {difference}");
        Console.WriteLine($"Произведение: {num1} * {num2} = {product}");
        Console.WriteLine($"Частное: {num1} / {num2} = {quotient}");
    }
}
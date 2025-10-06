using System;

partial class Program
{
    static void Main()
    {
        // Задание 1
        int a = 12;
        int b = 5;

        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"Сумма: {a} + {b} = {a + b}");
        Console.WriteLine($"Разность: {a} - {b} = {a - b}");
        Console.WriteLine($"Произведение: {a} × {b} = {a * b}");
        Console.WriteLine($"Частное: {a} ÷ {b} = {a / b}");
        Console.WriteLine($"Остаток от деления: {a} % {b} = {a % b}");

        // Задание 2
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine() ?? "Гость";
        Console.WriteLine($"Привет, {name}!");

        // Задание 3
        Console.WriteLine("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Сумма: {num1 + num2}");

        // Задание 4
        Console.WriteLine("Введите ширину прямоугольника: ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину прямоугольника: ");
        int height = int.Parse(Console.ReadLine());
        int area = width * height;
        Console.WriteLine($"Площадь прямоугольника {width} × {height} = {area}");
    }
}
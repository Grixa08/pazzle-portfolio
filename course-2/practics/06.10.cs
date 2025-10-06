using System;

//work1
int number = 10;
if (number > 0)
    Console.WriteLine("Число положительное");
else if (number < 0)
    Console.WriteLine("Число отрицательное");
else if (number == 0)
    Console.WriteLine("Число равно 0");

//work 2
Console.WriteLine("Введите возрост");
int age = int.Parse(Console.ReadLine());
if (age > 18)
    Console.WriteLine("Вы совершеннолетний");
else
    Console.WriteLine("Вы не совершеннолетний");

//work3
int num = 7;
int sum = num % 2;
if (sum == 0)
    Console.WriteLine("Число четное");
else
    Console.WriteLine("Число нечетное");

//work4
int a = 5;
int b = -2;
if (a > 0 && b > 0)
    Console.WriteLine("Оба числа четные");
else if (a > 0 || b > 0)
    Console.WriteLine("Какое то число четное");
else if (a < 0)
    Console.WriteLine("а не положительное");

//work5
Console.WriteLine("Введите оценку");
int grage  = int.Parse(Console.ReadLine());
if (grage < 3)
    Console.WriteLine("Не удовлетворительно");
else if (grage == 4)
    Console.WriteLine("Хорошо");
else
    Console.WriteLine("Отлично");
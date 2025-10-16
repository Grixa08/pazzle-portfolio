using System;

public static class practic16
{
    public static void Start()
    {
        //work 1
        void SayHello()
        {
            Console.WriteLine("Привет мир!");
        }
        SayHello();
        SayHello();
        SayHello();

        //work 2
        void Greet(string Name)
        {
            Console.WriteLine($"Привет {Name}");
        }
        Greet("Саша");
        Greet("Анна");
        Greet("Ярослав");

        //work 3
        void PrintPerson(string name, int age, string sity)
        {
            Console.WriteLine($"Name: {name}  Age: {age}  sity: {sity}");
        }

        PrintPerson("Егор", 15, "Москва");
        PrintPerson("Grigory", 17, "Novokuzneck");

        //work 4
        void PrintPerson1(string name, int age = 18, string hobby = "Не указано")
        {
            Console.WriteLine($"Name: {name}  Age: {age} Hobby: {hobby}");
        }

        PrintPerson1("Tom", 37, "Run");
        PrintPerson1("Tom");

        //work 5
        int Square(int x)
        {
            int square = x * x;
            return square;
        }

        int result = Square(6);
        Console.WriteLine("Квадрат числа: " + result);

        //work 6
        int Add(int a, int b)
        {
            return a + b;
        }
        int Subtract(int a, int b)
        {
            return a - b;
        }
        int Multiply1(int a, int b)
        {
            return a * b;
        }
        double Divide(int a, int b)
        {
            return a / b;
        }
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Введите операцию (+, -, *, /): ");
        string operation = Console.ReadLine();
        double resultat = 0;
        if (operation == "+")
        {
            resultat = Add(num1, num2);
        }
        else if (operation == "-")
        {
            resultat = Subtract(num1, num2);
        }
        else if (operation == "*")
        {
            resultat = Multiply1(num1, num2);
        }
        else if (operation == "/")
        {
            resultat = Divide(num1, num2);
        }
        Console.WriteLine("Результат: " + resultat);

        //work 7
        int counter = 0;
        void Increment()
        {
            counter++;
            Console.WriteLine(counter);
        }
        Increment();
        Increment();

        //work 8
        
        Console.WriteLine("Умножение 2 целых чисел: " + Multiply(2, 3));
        Console.WriteLine("Умножение 3 целых чисел: " + Multiply(2, 3, 4));
        Console.WriteLine("Умножение 2 дробных чисел: " + Multiply(2.5, 4.0));
    }
    //work 8
    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }
    static double Multiply(double a, double b)
    {
        return a * b;
    }
}
    //Задание 8.Перегрузка методов
    //Создайте несколько версий метода Multiply:
    //Multiply(int a, int b) — умножает 2 целых числа,
    //Multiply(int a, int b, int c) — умножает 3 целых числа,
    //Multiply(double a, double b) — умножает 2 дробных числа.

    //Проверьте работу всех перегрузок:
    //Console.WriteLine(Multiply(2, 3));
    //        Console.WriteLine(Multiply(2, 3, 4));
    //        Console.WriteLine(Multiply(2.5, 4.0));

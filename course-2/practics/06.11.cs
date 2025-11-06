using System;

public static class Practice06_11
{
    // 1
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book()
        {
            Title = "Неизвестно";
            Author = "Неизвестно";
            Pages = 0;
        }

        public Book(string title)
        {
            Title = title;
            Author = "Неизвестно";
            Pages = 0;
        }
        
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Pages = 0;
        }

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Книга: '{Title}', автор: {Author}, страниц: {Pages}");
        }
    }

    // 2
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        public Car() : this("Неизвестно", "Неизвестно", 0)
        {
        }

        public Car(string brand) : this(brand, "Неизвестно", 0)
        {
        }

        public Car(string brand, string model) : this(brand, model, 0)
        {
        }

        public Car(string brand, string model, int speed)
        {
            Brand = brand;
            Model = model;
            Speed = speed;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Brand} {Model}, скорость: {Speed} км/ч");
        }
    }

    //3
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public Player(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Игрок: {Name}, уровень: {Level}");
        }
    }

    // 4
    public class User
    {
        public string Login { get; set; }
        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Пароль не может быть пустым!");
                }
                else
                {
                    _password = value;
                    Console.WriteLine("Пароль обновлен");
                }
            }
        }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public bool CheckPassword(string input)
        {
            return input == _password;
        }
    }

    // 5
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Точка: X={X}, Y={Y}");
        }
    }

    public static void Start()
    {
        // work 1
        Console.WriteLine("work 1");
        var book1 = new Book();
        var book2 = new Book("1984");
        var book3 = new Book("Гроза", "Островский");
        var book4 = new Book("Гарри Поттер", "Дж. Роулинг", 500);

        book1.PrintInfo();
        book2.PrintInfo();
        book3.PrintInfo();
        book4.PrintInfo();

        // work 2
        Console.WriteLine("\nwork 2");
        var car1 = new Car();
        var car2 = new Car("BMW");
        var car3 = new Car("Audi", "GX");
        var car4 = new Car("Mercedes", "banan", 120);

        car1.PrintInfo();
        car2.PrintInfo();
        car3.PrintInfo();
        car4.PrintInfo();

        // Задание 3
        Console.WriteLine("\nwork 3");
        var player1 = new Player("Иван", 10);
        var player2 = new Player("Петр", 15);
        var player3 = new Player("Иван", 10);

        player1.PrintInfo();
        player2.PrintInfo();
        player3.PrintInfo();

        Console.WriteLine($"player1 == player2: {player1 == player2}");
        Console.WriteLine($"player1 == player3: {player1 == player3}");
        Console.WriteLine($"player1.Equals(player2): {player1.Equals(player2)}");
        Console.WriteLine($"player1.Equals(player3): {player1.Equals(player3)}");

        // Задание 4
        Console.WriteLine("\n4");
        var user = new User("admin", "12345");
        Console.WriteLine($"Проверка пароля '12345': {user.CheckPassword("12345")}");
        Console.WriteLine($"Проверка пароля 'wrong': {user.CheckPassword("wrong")}");
        user.Password = ""; 
        user.Password = "newpassword"; 

        // Задание 5
        Console.WriteLine("\n5");
        var p1 = new Point(10, 20);
        var p2 = p1; 

        Console.WriteLine("До изменения:");
        p1.PrintInfo();
        p2.PrintInfo();

        p2.Move(5, 5);

        Console.WriteLine("После изменения p2:");
        p1.PrintInfo();
        p2.PrintInfo();
        Console.WriteLine("p1 изменился потому что p2 ссылается на тот же объект в памяти");
    }
}
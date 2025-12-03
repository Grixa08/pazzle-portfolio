public static class work01_12 { 
    // Задание 1
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    
        public void ShowInfo()
        {
            Console.WriteLine($"Название: {Title}, Автор: {Author}, Год: {Year}");
        }
    }

    // Задание 2
    public class Account
    {
        private decimal balance;
    
        public decimal Balance => balance;
    
        public void Deposit(decimal amount)
        {
            if (amount > 0)
                balance += amount;
        }
    
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
    }

    // Задание 3
    public class Transport
    {
        public virtual void Move() => Console.WriteLine("Транспорт движется.");
    }

    public class Car : Transport
    {
        public override void Move() => Console.WriteLine("Машина едет по дороге.");
    }

    public class Boat : Transport
    {
        public override void Move() => Console.WriteLine("Лодка плывёт по воде.");
    }

    public class Plane : Transport
    {
        public override void Move() => Console.WriteLine("Самолёт летит в небе.");
    }

    // Задание 4
    public class Animal
    {
        private int _energy = 100;
    
        public void Eat() => ChangeEnergy(10);
    
        public void ShowEnergy() => Console.WriteLine($"Энергия: {_energy}");
    
        protected void ChangeEnergy(int value) => _energy += value;
    }

    public class Dog : Animal
    {
        public void Run()
        {
            ChangeEnergy(-20);
            Console.WriteLine("Собака бежит.");
        }
    }

    public class Cat : Animal
    {
        public void Sleep()
        {
            ChangeEnergy(5);
            Console.WriteLine("Кот спит.");
        }
    }

    // Задание 5
    public class Shape
    {
        public virtual double GetArea() => 0;
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
    
        public override double GetArea() => Math.PI * Radius * Radius;
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    
        public override double GetArea() => Width * Height;
    }

    // Задание 6
    public abstract class Worker
    {
        public string Name { get; set; }
    
        public abstract void Work();
    
        public void ShowInfo() => Console.WriteLine($"Работник: {Name}");
    }

    public class Manager : Worker
    {
        public override void Work() => Console.WriteLine("Планирует задачи");
    }

    public class Developer : Worker
    {
        public override void Work() => Console.WriteLine("Пишет код");
    }

    // Задание 7
    public interface IPlayable
    {
        void Play();
    }

    public class Guitar : IPlayable
    {
        public void Play() => Console.WriteLine("Звук гитары");
    }

    public class Piano : IPlayable
    {
        public void Play() => Console.WriteLine("Звук пианино");
    }

    public class Drum : IPlayable
    {
        public void Play() => Console.WriteLine("Звук барабана");
    }

    // Задание 8
    public interface IPrinter
    {
        void Process();
    }

    public interface IScanner
    {
        void Process();
    }

    public class MultifunctionDevice : IPrinter, IScanner
    {
        void IPrinter.Process() => Console.WriteLine("Печать документа...");
    
        void IScanner.Process() => Console.WriteLine("Сканирование документа...");
    }

    // Задание 9
    public interface IDocumentExporter
    {
        string FormatName { get; }
        void Export(string content);
    
        void ShowInfo(string content)
        {
            Console.WriteLine($"Экспорт в формат {FormatName}: {content}");
        }
    }

    public class TxtExporter : IDocumentExporter
    {
        public string FormatName => "TXT";
    
        public void Export(string content)
        {
            Console.WriteLine($"Сохранено как текстовый файл: {content}");
        }
    }

    public class PdfExporter : IDocumentExporter
    {
        public string FormatName => "PDF";
    
        public void Export(string content)
        {
            Console.WriteLine($"Создан PDF документ: {content}");
        }
    }

    // Задание 10
    public abstract class MenuItem
    {
        public string Name { get; set; }
        public abstract double GetPrice();
    }
    public class Drink : MenuItem, IOrderItem
    {
        public double Volume { get; set; }
    
        public override double GetPrice() => Volume * 0.05;
    
        public void PrintInfo()
        {
            Console.WriteLine($"Напиток: {Name}, Объем: {Volume} мл, Цена: {GetPrice():F2}");
        }
    }

    public class Food : MenuItem, IOrderItem
    {
        public double Weight { get; set; }
    
        public override double GetPrice() => Weight * 0.02;
    
        public void PrintInfo()
        {
            Console.WriteLine($"Блюдо: {Name}, Вес: {Weight} г, Цена: {GetPrice():F2}");
        }
    }

    public interface IOrderItem
    {
        void PrintInfo();
    }

    public static void Start()
    {
        Console.WriteLine("work 1");
        var book = new Book { Title = "Война и мир", Author = "Л. Толстой", Year = 1869 };
        book.ShowInfo();
        
        Console.WriteLine("\nwork 2");
        var acc = new Account();
        acc.Deposit(1000);
        acc.Withdraw(300);
        Console.WriteLine($"Баланс: {acc.Balance}");
        
        Console.WriteLine("\nwork 3");
        Transport[] transports = { new Car(), new Boat(), new Plane() };
        foreach (var t in transports)
            t.Move();
        
        Console.WriteLine("\nwork 4");
        var dog = new Dog();
        dog.ShowEnergy();
        dog.Run();
        dog.ShowEnergy();
        dog.Eat();
        dog.ShowEnergy();
        var cat = new Cat();
        cat.ShowEnergy();
        cat.Sleep();
        cat.ShowEnergy();
        cat.Eat();
        cat.ShowEnergy();
        
        Console.WriteLine("\nwork 5");
        Shape[] shapes =
        {
            new Circle { Radius = 3 },
            new Rectangle { Width = 4, Height = 5 }
        };
        foreach (var s in shapes)
            Console.WriteLine($"Площадь: {s.GetArea()}");
        
        Console.WriteLine("\nwork 6");
        Worker[] workers = { new Manager { Name = "Анна" }, new Developer { Name = "Иван" } };
        foreach (var w in workers)
        {
            w.ShowInfo();
            w.Work();
        }
        
        Console.WriteLine("\nwork 7");
        IPlayable[] instruments = { new Guitar(), new Piano(), new Drum() };
        foreach (var i in instruments)
            i.Play();
        
        Console.WriteLine("\nwork 8");
        var device = new MultifunctionDevice();
        ((IPrinter)device).Process();
        ((IScanner)device).Process();
        
        Console.WriteLine("\nwork 9");
        IDocumentExporter[] exporters = { new TxtExporter(), new PdfExporter() };
        foreach (var e in exporters)
        {
            e.ShowInfo("Hello world!");
            e.Export("Hello world!");
        }
        
        Console.WriteLine("\nwork 10");
        IOrderItem[] order =
        {
            new Drink { Name = "Кофе", Volume = 200 },
            new Food { Name = "Сэндвич", Weight = 250 }
        };
        double total = 0;
        Console.WriteLine("Заказ в кафе:");
        foreach (var item in order)
        {
            item.PrintInfo();
            if (item is MenuItem menuItem)
                total += menuItem.GetPrice();
        }
        Console.WriteLine($"Общая сумма заказа: {total:F2}");
    }
}
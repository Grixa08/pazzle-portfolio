using System;

public static class Practice10_11
{
    // 1
    public class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine("Животное ест.");
        }
        public virtual void Speak()
        {
            Console.WriteLine("Животное издаёт звук");
        }
        public virtual void Move() => Console.WriteLine("Животное двигается");

        public Animal(string name)
        {
            Name = name;
            Console.WriteLine($"Создано животное по имени {name}");
        }

    }

    // Дочерний классы
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} Собака лает.");
        }
        public override void Speak()
        {
            Console.WriteLine($"Собака говорит: Гав-гав!");
        }
        public override void Move() => Console.WriteLine("Собака бежит по дороге");
    }

    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{Name} Кошка мяукает.");
        }
        public override void Speak()
        {
            Console.WriteLine($"Кошка говорит: Мяу!");
        }
        public Cat(string name) : base(name)
        {
            Console.WriteLine($"Создана кошка по имени {Name}");
        }
    }

    // 5
    public class Transport
    {
        public virtual void Drive()
        {
            Console.WriteLine("Транспорт движется");
        }
    }

    public class Car : Transport
    {
        public override void Drive()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }

    public class ElectricCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Электромобиль тихо едет на батарее");
        }
    }

    public static void Start()
    {
        Console.WriteLine("work 1");
        var dog = new Dog("Шарик");
        var cat = new Cat("Мурка");

        dog.Eat();
        dog.Bark();
        cat.Eat();
        cat.Meow();

        Console.WriteLine("\nwork 2");
        dog.Speak();
        cat.Speak();

        Console.WriteLine("\nwork 3");
        dog.Move();

        Console.WriteLine("\nwork 4");
        var cat2 = new Cat("Мурка");

        Console.WriteLine("\nwork 5");
        var transport = new Transport();
        var car = new Car();
        var tesla = new ElectricCar();

        transport.Drive();
        car.Drive();
        tesla.Drive();
    }
}
using System;

public static class practic17_11
{
    // 1
    public class Animal
    {
        public string Name { get; set; }

        public virtual void MakeSound() => Console.WriteLine("Животное издаёт звук");
    }

    public class Dog : Animal
    {
        public override void MakeSound() => Console.WriteLine("Собака лает");
    }

    public class Cat : Animal
    {
        public new void MakeSound() => Console.WriteLine("Кот мяукает");
    }

    // 2
    public class Transport
    {
        public string Model { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"{Model}: транспорт движется.");
        }
    }

    public class Car : Transport
    {
        public override void Move()
        {
            base.Move(); // вызов метода родителя
            Console.WriteLine("Машина едет по дороге");
        }
    }

    public class Boat : Transport
    {
        public override void Move()
        {
            Console.WriteLine($"{Model}: транспорт движется.");
            Console.WriteLine("Лодка плывёт по воде");
        }
    }

    public class Plane : Transport
    {
        public override void Move()
        {
            Console.WriteLine($"{Model}: транспорт движется.");
            Console.WriteLine("Самолёт летит в небе");
        }
    }

    // 3
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public override double GetArea()
        {
            return Side * Side;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    // 4
    public class Instrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Инструмент издаёт звук");
        }
    }

    public class Guitar : Instrument
    {
        public override void Play() => Console.WriteLine("Гитара играет аккорды");
    }

    public class Piano : Instrument
    {
        public override void Play() => Console.WriteLine("Пианино играет мелодию");
    }

    public class Drum : Instrument
    {
        public override void Play() => Console.WriteLine("Барабан бьёт ритм");
    }

    // 5
    public abstract class Character
    {
        public string Name { get; set; }
        public abstract void Attack();
    }

    public class Warrior : Character
    {
        public override void Attack() => Console.WriteLine("Воин атакует мечом!");
    }

    public class Mage : Character
    {
        public override void Attack() => Console.WriteLine("Маг выпускает огненный шар!");
    }

    public class Archer : Character
    {
        public override void Attack() => Console.WriteLine("Лучник стреляет из лука!");
    }

    public static void Start()
    {
        Console.WriteLine("work 1");
        Animal[] animals =
        {
            new Dog { Name = "Барсик" },
            new Cat { Name = "Мурка" },
            new Dog { Name = "Рекс" }
        };

        foreach (var animal in animals)
        {
            animal.MakeSound();
        }

        Console.WriteLine("\nwork 2");
        Transport[] vehicles =
        {
            new Car { Model = "Audi" },
            new Boat { Model = "Yamaha" },
            new Plane { Model = "Boeing" }
        };

        foreach (var v in vehicles)
        {
            v.Move();
        }

        Console.WriteLine("\nwork 3");
        Shape[] shapes =
        {
            new Circle { Radius = 5 },
            new Square { Side = 4 },
            new Rectangle { Width = 3, Height = 6 }
        };

        foreach (var s in shapes)
        {
            Console.WriteLine($"{s.GetArea()}");
        }

        Console.WriteLine("\nwork 4");
        Instrument[] instruments =
        {
            new Guitar(),
            new Piano(),
            new Drum()
        };

        foreach (var i in instruments)
        {
            i.Play();
        }

        Console.WriteLine("\nwork 5");
        Character[] team =
        {
            new Warrior { Name = "Алекс" },
            new Mage { Name = "Лия" },
            new Archer { Name = "Робин" }
        };

        foreach (var c in team)
        {
            Console.Write($"{c.Name}: ");
            c.Attack();
        }
    }
}
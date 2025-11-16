using System;

public static class Practice13_11
{
    //1
    public class Person
    {
        private int age; // скрытое поле
        private string name; 

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Возраст не может быть отрицательным!");
            }
        }
        public string Name 
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value)) // проверка на пустую строку
                    name = value;
                else
                    Console.WriteLine("Имя не должно быть пустым");
            }
        }
    }

    // 2
    public class BankAccount
    {
        private decimal balance; // скрытое поле
        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Недостаточно средств!");
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Баланс: {balance}");
        }
    }

    // 3
    public class Thermometer
    {
        private double temperatureCelsius; // скрытое поле
        public double TemperatureCelsius
        {
            get { return temperatureCelsius; }
            set
            {
                if (value >= -273)
                    temperatureCelsius = value;
                else
                    Console.WriteLine("Температура не может быть ниже -273C!");
            }
        }
        public double TemperatureFahrenheit
        {
            get { return (temperatureCelsius * 9 / 5) + 32; }
        }
    }

    // 4
    public class Animal
    {
        protected int energy = 100;

        public void Eat()
        {
            energy += 10;
            Console.WriteLine($"Животное поело, энергия: {energy}");
        }
    }

    public class Dog : Animal
    {
        public void Run()
        {
            energy -= 20;
            Console.WriteLine($"Собака побежала, энергия: {energy}");
        }
    }
    public static void Start()
    {
        Console.WriteLine("work 1");
        var p = new Person();
        p.Name = "Алиса";
        p.Age = 25;
        p.Age = -5; // сообщение об ошибке

        Console.WriteLine("\nwork 2");
        BankAccount account = new BankAccount();
        account.Deposit(1000);
        account.ShowBalance();
        account.Withdraw(300);
        account.ShowBalance(); 
        account.Withdraw(800); 
        account.ShowBalance(); 

        Console.WriteLine("\nwork 3");
        var t = new Thermometer();
        t.TemperatureCelsius = 25;
        Console.WriteLine($"Цельсий: {t.TemperatureCelsius}"); 
        Console.WriteLine($"Фаренгейт: {t.TemperatureFahrenheit}"); 
        t.TemperatureCelsius = 0;
        Console.WriteLine($"Цельсий: {t.TemperatureCelsius}");
        Console.WriteLine($"Фаренгейт: {t.TemperatureFahrenheit}");
        t.TemperatureCelsius = -300;

        Console.WriteLine("\nwork 4");
        var dog = new Dog();
        dog.Eat();
        dog.Run();
        dog.Run();
        dog.Eat();
        dog.Run();

    }
}
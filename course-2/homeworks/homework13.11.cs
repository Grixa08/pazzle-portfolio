using System;

public static class homework13_11
{
    // 1
    public class Transport
    {
        public string Model { get; set; }
        protected int Speed = 0;

        public void ShowInfo()
        {
            Console.WriteLine($"Модель: {Model}, скорость: {Speed} км/ч");
        }

        public virtual void Move()
        {
            Console.WriteLine("Транспорт движется");
        }
    }

    public class Car : Transport
    {
        public void Accelerate(int value)
        {
            if (Speed + value <= 200)
            {
                Speed += value;
            }
            else
            {
                Console.WriteLine("Слишком большая скорость!");
            }
        }

        public override void Move()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }

    public class Bicycle : Transport
    {
        public void Pedal()
        {
            Speed += 5;
        }

        public override void Move()
        {
            Console.WriteLine("Велосипед крутит педали");
        }
    }

    // 2
    public class Account
    {
        private decimal balance;

        public string Owner { get; set; }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Баланс: {Balance} руб.");
        }
    }

    public class SavingsAccount : Account
    {
        private decimal interestRate;

        public SavingsAccount(string owner, decimal rate)
        {
            Owner = owner;
            interestRate = rate;
        }

        public void AddInterest()
        {
            decimal interest = Balance * (interestRate / 100);
            Deposit(interest);
        }
    }

    public static void Start()
    {
        Console.WriteLine("homework 1");
        var car = new Car { Model = "Audi" };
        car.Accelerate(100);
        car.ShowInfo();
        car.Move();

        var bike = new Bicycle { Model = "Cube" };
        bike.Pedal();
        bike.ShowInfo();
        bike.Move();

        Console.WriteLine("\nhomework 2");
        var acc = new SavingsAccount("Анна", 5);
        acc.Deposit(1000);
        acc.AddInterest();
        acc.ShowBalance();
        acc.Withdraw(300);
        acc.ShowBalance();
    }
}
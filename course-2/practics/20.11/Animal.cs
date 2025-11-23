//шаг 2
//public class Animal
//{
//    public string Name { get; set; }

//    public void Eat()
//    {
//        Console.WriteLine($"{Name} ест.");
//    }

//    public void MakeSound()
//    {
//        Console.WriteLine($"{Name} издаёт звук.");
//    }
//}

//шаг 3
//public class Animal
//{
//    public string Name { get; set; }

//    public Animal() : this("Неизвестно") { }
//    public Animal(string name) { Name = name; }

//    public void Eat() => Console.WriteLine($"{Name} ест.");
//    public void MakeSound() => Console.WriteLine($"{Name} издаёт звук.");
//}

//шаг 4
//public class Animal
//{
//    private int _energy = 100;                // скрытое состояние
//    public string Name { get; set; }

//    public Animal() : this("Неизвестно") { }
//    public Animal(string name) { Name = name; }

//    public void Eat()
//    {
//        ChangeEnergy(+10);
//        Console.WriteLine($"{Name} ест. Энергия: {_energy}");
//    }

//    public void Rest()
//    {
//        ChangeEnergy(+5);
//        Console.WriteLine($"{Name} отдыхает. Энергия: {_energy}");
//    }

//    public void MakeSound()
//    {
//        ChangeEnergy(-5);
//        Console.WriteLine($"{Name} издаёт звук. Энергия: {_energy}");
//    }

//    private void ChangeEnergy(int delta)
//    {
//        _energy += delta;
//        if (_energy < 0) _energy = 0;
//        if (_energy > 150) _energy = 150;
//    }
//}

//шаг 5 и 6
public class Animal
{
    private int _energy = 100;                // скрытое состояние
    public string Name { get; set; }

    public Animal() : this("Неизвестно") { }
    public Animal(string name) { Name = name; }

    public void Eat()
    {
        ChangeEnergy(+10);
        Console.WriteLine($"{Name} ест. Энергия: {_energy}");
    }

    public void Rest()
    {
        ChangeEnergy(+5);
        Console.WriteLine($"{Name} отдыхает. Энергия: {_energy}");
    }

    //public void MakeSound()
    //{
    //    ChangeEnergy(-5);
    //    Console.WriteLine($"{Name} издаёт звук. Энергия: {_energy}");
    //}

    private void ChangeEnergy(int delta)
    {
        _energy += delta;
        if (_energy < 0) _energy = 0;
        if (_energy > 150) _energy = 150;
    }
    public virtual void MakeSound()
    {
        // базовый (общий) звук -- можно оставить как «фон»
        // даже базовая реализация тратит энергию
        ChangeEnergy(-5);
        Console.WriteLine($"{Name} издаёт общий звук. Энергия: {_energy}");
    }


}
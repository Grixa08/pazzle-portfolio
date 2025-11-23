public class Dog : Animal
{
    public Dog() : base("Собака") { }
    public Dog(string name) : base(name) { }

    public void Bark()
    {
        Console.WriteLine($"{Name} пытается лаять...");
        MakeSound(); // пока общий звук
    }

    //шаг 6
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Гав-гав!");
    }
}

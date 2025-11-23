public class Elephant : Animal
{
    public Elephant() : base("Слон") { }
    public Elephant(string name) : base(name) { }

    public void Trumpet()
    {
        Console.WriteLine($"{Name} трубит хоботом...");
        MakeSound();
    }

    //шаг 6
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Трууу!");
    }
}
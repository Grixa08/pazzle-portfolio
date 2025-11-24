using System;

class Program
{
    static void Main()
    {
        Practic24_11.Start();
    }
}

//шаг 2
//var a1 = new Animal { Name = "Безымянный" };
//a1.Eat();
//a1.MakeSound();

//шаг 3
//var a1 = new Animal();                 // "Неизвестно"
//var a2 = new Animal("Мурка");          // "Мурка"
//var a3 = new Animal { Name = "Шарик" };// инициализатор свойств

//a1.Eat(); a2.Eat(); a3.Eat();

//шаг 4
//var a = new Animal("Чип");
//a.MakeSound();  // энергия уменьшается
//a.Eat();        // энергия растёт
//a.Rest();       // энергия растёт помалу

//шаг 5
//var d = new Dog("Шарик");
//var c = new Cat("Мурка");
//var e = new Elephant("Дамбо");
//d.Bark(); c.Meow(); e.Trumpet();

//шаг 6
//Animal[] zoo =
//{
//    new Dog("Шарик"),
//    new Cat("Мурка"),
//    new Elephant("Дамбо"),
//    new Animal("Неопознанный")
//};

//foreach (var a in zoo)
//{
//    a.MakeSound(); // у каждого -- свой результат
//}

//шаг 7
//var zooPark = new Zoo(5);
//zooPark.Add(new Dog("Рекс"));
//zooPark.Add(new Cat("Снежок"));
//zooPark.Add(new Elephant("Балу"));

//Console.WriteLine("=== Звуки ===");
//zooPark.MakeAllSounds();

//Console.WriteLine("=== Кормим ===");
//zooPark.FeedAll();

//homework
// Создаем животных
//Animal[] animals = {
//    new Dog("Шарик"),
//    new Cat("Мурка"),
//    new Elephant("Дамбо")
//};

//Console.WriteLine("Звуки животных");
//foreach (var animal in animals)
//{
//    animal.MakeSound();
//}

//Console.WriteLine("\nКормление");
//foreach (var animal in animals)
//{
//    animal.Eat();
//}

//Console.WriteLine("\nОтдых");
//foreach (var animal in animals)
//{
//    animal.Rest();
//}


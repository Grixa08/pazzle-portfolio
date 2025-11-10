using System;

public static class Homework06_11
{
    // 1
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        public Movie() : this("Без названия", "Неизвестен", 0)
        {
        }

        public Movie(string title) : this(title, "Неизвестен", 0)
        {
        }

        public Movie(string title, string genre, double rating)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Название: {Title}, жанр: {Genre}, рейтинг: {Rating}");
        }
    }

    // 2
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name}, возраст {Age}");
        }
    }

    public static void Start()
    {
        Console.WriteLine("work 1");
        var m1 = new Movie();
        var m2 = new Movie("Матрица");
        var m3 = new Movie("Начало", "Фантастика", 9);

        m1.PrintInfo();
        m2.PrintInfo();
        m3.PrintInfo();

        Console.WriteLine("\nwork 2");
        var cat1 = new Cat("Барсик", 2);

        // Присвоил второго кота
        var cat2 = cat1;
        cat2.Age = 5;

        cat1.PrintInfo();
        cat2.PrintInfo();
        //У обоих одинаковый возраст потому что cat2 ссылается на тот же объект в памяти что и cat1
        var cat3 = new Cat(cat1.Name, cat1.Age);
        Console.WriteLine("\nИзменил возраст третьего кота");
        cat3.Age = 10;

        cat1.PrintInfo();
        cat2.PrintInfo();
        cat3.PrintInfo();
        //cat3 не изменил cat1 и cat2 потому что это отдельный объект в памяти
    }
}
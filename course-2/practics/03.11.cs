using System;
// кодировка
public static class Practice03
{
    //work 1
    public class Car
    {
        public string Brand { get; set; }
        public int Speed { get; private set; } = 0;

        public void Accelerate() => Speed += 10;
    }

    //work 2
    public class Car2
    {
        public string Brand2 { get; }
        public int Speed2 { get; private set; }

        public Car2(string brand2, int speed2)
        {
            Brand2 = brand2;
            Speed2 = speed2;
        }

        public void Accelerate() => Speed2 += 10;
    }

    //work 3
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        private int _pagesRead = 0;

        public void Read(int pages)
        {
            if (_pagesRead + pages > Pages)
            {
                Console.WriteLine($"Вы пытаетесь прочитать {pages} страниц, но осталось только {Pages - _pagesRead}");
            }
            else
            {
                _pagesRead += pages;
                Console.WriteLine($"Вы прочитали {pages} страниц из {Pages}");
            }
        }
    }

    //work 4
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void PrintAllBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} - {book.Author}, {book.Pages} стр.");
            }
        }
    }

    public static void Start()
    {
        //work 1
        Console.WriteLine("work 1");
        var car = new Car { Brand = "BMW" };
        car.Accelerate();
        Console.WriteLine($"{car.Brand} едет со скоростью {car.Speed} км/ч");

        //work 2
        Console.WriteLine("\nwork 2");
        var car2 = new Car2("Audi", 50);
        car2.Accelerate();
        Console.WriteLine($"{car2.Brand2} едет со скоростью {car2.Speed2} км/ч");

        //work 3
        Console.WriteLine("\nwork 3");
        var book = new Book { Title = "Война и мир", Author = "Толстой", Pages = 500 };
        book.Read(100);
        book.Read(300);
        book.Read(200); 

        //work 4
        Console.WriteLine("\nwork 4");
        var lib = new Library();
        lib.AddBook(new Book { Title = "1984", Author = "Дж. Оруэлл", Pages = 350 });
        lib.AddBook(new Book { Title = "Что нибудь", Author = "Пушкин", Pages = 400 });
        lib.PrintAllBooks();
    }
}
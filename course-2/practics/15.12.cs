using System;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

public static class Practic15_12
{
    public class Book
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("publication_year")]
        public int Year { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }



    public static void Start()
    {
        // Уровень 1

        //var books = new List<Book>
        //{
        //    new Book { Title = "Война и мир", Author = "Толстой", Year = 1869 },
        //    new Book { Title = "Преступление и наказание", Author = "Достоевский", Year = 1866 }
        //};

        //string json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
        //File.WriteAllText("books.json", json);
        //Console.WriteLine("Данные успешно сохранены в books.json");

        //string jsonFromFile = File.ReadAllText("books.json");
        //var booksFromFile = JsonSerializer.Deserialize<List<Book>>(jsonFromFile);

        //foreach (var book in booksFromFile)
        //{
        //    Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Год: {book.Year}");
        //}

        //var options = new JsonSerializerOptions { WriteIndented = true };
        //string json = JsonSerializer.Serialize(books, options);
        //File.WriteAllText("books.json", json);

        // Уровень 2

        //var library = new Library
        //{
        //    Name = "Городская библиотека",
        //    Books = new List<Book>
        //    {
        //        new Book { Title = "Война и мир", Author = "Толстой", Year = 1869 },
        //        new Book { Title = "Преступление и наказание", Author = "Достоевский", Year = 1866 }
        //    }
        //};

        //var options = new JsonSerializerOptions { WriteIndented = true };
        //string json = JsonSerializer.Serialize(library, options);
        //File.WriteAllText("library.json", json);

        //string jsonFromFile = File.ReadAllText("library.json");
        //var libraryFromFile = JsonSerializer.Deserialize<Library>(jsonFromFile);

        //Console.WriteLine($"Библиотека: {libraryFromFile.Name}");
        //foreach (var b in libraryFromFile.Books)
        //{
        //    Console.WriteLine($"Книга: \"{b.Title}\", автор: {b.Author}, год: {b.Year}");
        //}

        // homework

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var books = new List<Book>
        {
            new Book { Title = "Война и мир", Author = "Толстой", Year = 1869 },
            new Book { Title = "Преступление и наказание", Author = "Достоевский", Year = 1866 },
            new Book {Title = "Обо мне", Author = "Григорий", Year = 2024, Description = "Шутка"}
        };

        string json = JsonSerializer.Serialize(books, options);
        File.WriteAllText("books.json", json);
        Console.WriteLine("Книги сохранены в books.json");

        string jsonFromFile = File.ReadAllText("books.json");

        var booksFromFile = JsonSerializer.Deserialize<List<Book>>(jsonFromFile, options);

        foreach (var b in booksFromFile)
        {
            var description = !string.IsNullOrEmpty(b.Description) ? b.Description : "none";
            Console.WriteLine($"Книга: \"{b.Title}\", автор: {b.Author}, год: {b.Year}, расшифровка: {description}");
        }
    }
}
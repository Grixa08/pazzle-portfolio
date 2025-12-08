using System;
using System.Collections.Generic;
using System.Linq;

public static class Homework08_12
{
    public static void Start()
    {
        //work 1
        var books = new List<string> { "Война и мир", "Сказки Пушкина", "Словарь", "Мастер и Маргарита", "Преступление и наказание" };

        //work 2
        var readers = new Queue<string>();
        readers.Enqueue("Анна");
        readers.Enqueue("Иван");
        readers.Enqueue("Мария");

        //work 3
        Dictionary<string, string> issuedBooks = new Dictionary<string, string>();

        //work 4
        Console.WriteLine("\nwork 4");

        while (readers.Count > 0 && books.Count > 0)
        {
            string reader = readers.Dequeue();
            string book = books[0];

            issuedBooks[book] = reader;
            books.RemoveAt(0);

            Console.WriteLine($"Книга {book} выдана читателю: {reader}");
        }

        //work 5
        Console.WriteLine("\nwork 5");
        foreach (var book in books)
        {
            Console.WriteLine($"{book}");
        }

        //work 6
        Console.WriteLine("\nwork 6");
        foreach (var record in issuedBooks)
        {
            Console.WriteLine($"{record.Key} -- {record.Value}");
        }
    }
}
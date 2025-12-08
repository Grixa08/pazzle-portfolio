using System;
using System.Collections.Generic;
using System.Linq;

public static class Practice08_12
{
    public static void Start()
    {
        //Задание 1
        Console.WriteLine("work 1");
        var clients = new Queue<string>();

        clients.Enqueue("Анна");
        clients.Enqueue("Иван");
        clients.Enqueue("Мария");
        clients.Enqueue("Олег");

        Console.WriteLine($"Первый в очереди: {clients.Peek()}");

        while (clients.Count > 0)
        {
            string c = clients.Dequeue();
            Console.WriteLine($"Обслужен клиент: {c}");
        }
        Console.WriteLine("Очередь пуста");

        //work 2
        Console.WriteLine("\nwork 2");
        var actions = new Stack<string>();

        actions.Push("Открыт документ");
        actions.Push("Написан текст");
        actions.Push("Удалён абзац");

        Console.WriteLine($"Верхнее действие: {actions.Peek()}");

        while (actions.Count > 0)
        {
            string act = actions.Pop();
            Console.WriteLine($"Отмена действия: {act}");
            Console.WriteLine($"Осталось действий: {actions.Count}");
        }

        //work 3
        Console.WriteLine("\nwork 3");
        var history = new Stack<string>();
        history.Push("google.com");
        history.Push("youtube.com");
        history.Push("stackoverflow.com");

        Console.WriteLine($"Текущая страница: {history.Peek()}");

        while (history.Count > 1)
        {
            Console.WriteLine("Назад...");
            history.Pop();
            Console.WriteLine($"Текущая страница: {history.Peek()}");
        }

        //work 4
        Console.WriteLine("\nwork 4");
        var prices = new Dictionary<string, int>
        {
            { "Кофе", 150 },
            { "Чай", 100 },
            { "Сэндвич", 250 }
        };

        var customers = new Queue<string>();
        customers.Enqueue("Анна");
        customers.Enqueue("Иван");

        var orderItems = new List<string> { "Кофе", "Сэндвич" };

        Console.WriteLine("Обслуживание клиентов:");
        while (customers.Count > 0)
        {
            var client = customers.Dequeue();
            Console.WriteLine($"\nКлиент {client}:");

            int total = 0;
            foreach (var item in orderItems)
            {
                int price = prices[item];
                total += price;
                Console.WriteLine($"  {item} -- {price} руб.");
            }
            Console.WriteLine($"Итого: {total} руб.");
        }

        //work 5
        Console.WriteLine("\nwork 5");
        var tasks = new Queue<string>();
        tasks.Enqueue("Сделать отчёт");
        tasks.Enqueue("Позвонить клиенту");
        tasks.Enqueue("Проверить почту");

        var priority = new Dictionary<string, int>
        {
            { "Сделать отчёт", 1 },
            { "Позвонить клиенту", 2 },
            { "Проверить почту", 3 }
        };

        while (tasks.Count > 0)
        {
            string task = tasks.Dequeue();
            Console.WriteLine($"Выполняется: {task} (приоритет {priority[task]})");
        }

    }
}
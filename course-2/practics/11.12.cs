using System;
using System.IO;
using System.Text;

public static class Practic11_12
{
	public static void Start()
	{
		Console.WriteLine("work 1");
		string path = "notes.txt";

		string content = "";
		File.WriteAllText(path, content);

		File.AppendAllText(path, "\nДобавим новую строку.");

		Console.WriteLine("Создаем файл");
		using (var writer = new StreamWriter(path, append: false))
		{
			writer.WriteLine("Первая строка");
			writer.WriteLine("Вторая строка");
			writer.WriteLine("Третья строка");
			Console.WriteLine("3 строки записаны");
		}

		using (var writer = new StreamWriter(path, append: true))
		{
			writer.WriteLine("Четвертая строка");
			Console.WriteLine("Четвертая строка записана");
		}

		Console.WriteLine("\nСодержимое файла:");
		using (var reader = new StreamReader(path, Encoding.UTF8))
		{
			string line;
			int lineNumber = 1;
			while ((line = reader.ReadLine()) != null)
			{
				Console.WriteLine($"{lineNumber}: {line}");
				lineNumber++;
			}
		}

		Console.Write("\nУдалить файл? (y/n): ");
		if (Console.ReadLine()?.Trim().ToLowerInvariant() == "y")
		{
			if (File.Exists(path))
			{
				File.Delete(path);
				Console.WriteLine("Файл успешно удален");
			}
		}
		else
		{
			Console.WriteLine("Удаление отменено");
		}

		Console.WriteLine("\nwork 2");

		string path2 = @"C:\DATA_Test";
		if (!Directory.Exists(path2))
		{
			Directory.CreateDirectory(path2);
			Console.WriteLine(path2);
		}

		File.WriteAllText(Path.Combine(path2, "file1.txt"), "Содержимое файла 1");
		File.WriteAllText(Path.Combine(path2, "file2.txt"), "Содержимое файла 2");
		File.WriteAllText(Path.Combine(path2, "file3.txt"), "Содержимое файла 3");
		Console.WriteLine("Создано 3 txt файла");

		FileInfo[] allFiles = new DirectoryInfo(path2).GetFiles("*.txt");
		Console.WriteLine($"Всего найдено файлов: {allFiles.Length}");

		foreach (FileInfo file in allFiles)
		{
			Console.WriteLine($"\nФайл: {file.Name}");
			Console.WriteLine($"  Время создания: {file.CreationTime}");
			Console.WriteLine($"  Размер: {file.Length} байт");
			Console.WriteLine($"  Полный путь: {file.FullName}");
			Console.WriteLine($"  Расширение: {file.Extension}");
			Console.WriteLine($"  Последнее изменение: {file.LastWriteTime}");
		}




	}
}
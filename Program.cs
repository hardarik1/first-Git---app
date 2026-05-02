using System;

class HelloGit
{
    static void Main()
    {
        Console.WriteLine("Привет, Git-сервис!");
        Console.WriteLine($"Дата: {DateTime.Now:dd.MM.yyyy}");
        Console.WriteLine($"3 + 5 = {Calculator.Add(3, 5)}");
    }
}
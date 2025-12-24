using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public void Print()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
    }
}

class Program
{
    public static char LayKyTuDau(string name)
    {
        string[] parts = name.Trim().Split(' ');
        string tenChinh = parts[parts.Length - 1];
        return tenChinh[0];
    }

    static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student(123, "Binh An", 16),
            new Student(234, "Gia Bao", 18),
            new Student(345, "Anh Khoa", 17),
            new Student(456, "Le Minh", 15),
            new Student(567, "Anh Tuan", 19)
        };

        Console.WriteLine("a. Danh sach toan bo hoc sinh:");
        students.ForEach(s => s.Print());

        var age15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
        Console.WriteLine("\nb. Hoc sinh co tuoi tu 15 den 18:");
        foreach (var s in age15to18) s.Print();

        var startWithA = students.Where(s =>
            LayKyTuDau(s.Name).ToString().ToUpper() == "A");
        Console.WriteLine("\nc. Hoc sinh co ten chinh bat dau bang chu A:");
        foreach (var s in startWithA) s.Print();

        int totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nd. Tong tuoi tat ca hoc sinh: {totalAge}");

        int maxAge = students.Max(s => s.Age);
        var oldest = students.Where(s => s.Age == maxAge);
        Console.WriteLine("\ne. Hoc sinh co tuoi lon nhat:");
        foreach (var s in oldest) s.Print();

        var sorted = students.OrderBy(s => s.Age);
        Console.WriteLine("\nf. Danh sach sau khi sap xep tuoi tang dan:");
        foreach (var s in sorted) s.Print();
    }
}

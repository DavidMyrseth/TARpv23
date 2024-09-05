using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить студента");
            Console.WriteLine("2. Удалить студента");
            Console.WriteLine("3. Найти студента");
            Console.WriteLine("4. Показать всех студентов");
            Console.WriteLine("5. Выйти");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите имя студента: ");
                    string name = Console.ReadLine();
                    Console.Write("Введите возраст студента: ");
                    int age = int.Parse(Console.ReadLine());
                    students.Add(new Student(name, age));
                    Console.WriteLine("Студент добавлен.");
                    break;
                case "2":
                    Console.Write("Введите имя студента для удаления: ");
                    name = Console.ReadLine();
                    Student studentToRemove = students.Find(s => s.Name == name);
                    if (studentToRemove != null)
                    {
                        students.Remove(studentToRemove);
                        Console.WriteLine("Студент удален.");
                    }
                    else
                    {
                        Console.WriteLine("Студент не найден.");
                    }
                    break;
                case "3":
                    Console.Write("Введите имя студента для поиска: ");
                    name = Console.ReadLine();
                    Student foundStudent = students.Find(s => s.Name == name);
                    if (foundStudent != null)
                    {
                        Console.WriteLine($"Имя: {foundStudent.Name}, Возраст: {foundStudent.Age}");
                    }
                    else
                    {
                        Console.WriteLine("Студент не найден.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Список студентов:");
                    foreach (var student in students)
                    {
                        Console.WriteLine($"Имя: {student.Name}, Возраст: {student.Age}");
                    }
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;
            }
        }
    }
}

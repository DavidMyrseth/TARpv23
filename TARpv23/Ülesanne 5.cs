using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Имя: {Name}";
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Добавить сотрудника");
            Console.WriteLine("2. Удалить сотрудника по ID");
            Console.WriteLine("3. Найти сотрудника по ID");
            Console.WriteLine("4. Показать всех сотрудников");
            Console.WriteLine("5. Выйти");
            Console.Write("Выберите действие: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddEmployee(employees);
                    break;
                case 2:
                    RemoveEmployee(employees);
                    break;
                case 3:
                    FindEmployee(employees);
                    break;
                case 4:
                    ShowAllEmployees(employees);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Неверный ввод. Пожалуйста, выберите корректный пункт меню.");
                    break;
            }
        }
    }

    static void AddEmployee(List<Employee> employees)
    {
        Console.Write("Введите имя сотрудника: ");
        string name = Console.ReadLine();
        Console.Write("Введите ID сотрудника: ");
        int id = int.Parse(Console.ReadLine());

        employees.Add(new Employee(name, id));
        Console.WriteLine("Сотрудник добавлен!");
    }

    static void RemoveEmployee(List<Employee> employees)
    {
        Console.Write("Введите ID сотрудника для удаления: ");
        int id = int.Parse(Console.ReadLine());

        Employee employeeToRemove = employees.FirstOrDefault(emp => emp.Id == id);

        if (employeeToRemove != null)
        {
            employees.Remove(employeeToRemove);
            Console.WriteLine("Сотрудник удален.");
        }
        else
        {
            Console.WriteLine("Сотрудник с таким ID не найден.");
        }
    }

    static void FindEmployee(List<Employee> employees)
    {
        Console.Write("Введите ID сотрудника для поиска: ");
        int id = int.Parse(Console.ReadLine());

        Employee foundEmployee = employees.FirstOrDefault(emp => emp.Id == id);

        if (foundEmployee != null)
        {
            Console.WriteLine($"Найден сотрудник: {foundEmployee}");
        }
        else
        {
            Console.WriteLine("Сотрудник с таким ID не найден.");
        }
    }

    static void ShowAllEmployees(List<Employee> employees)
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("Список сотрудников пуст.");
        }
        else
        {
            Console.WriteLine("Список сотрудников:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Designation { get; set; }
    public string Department { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
       
        Employee[] employees = new Employee[]
        {
            new Employee { Id = 1, Name = "Shanmukh", Designation = "Manager", Department = "Sales" },
            new Employee { Id = 2, Name = "Rohith", Designation = "Associate", Department = "HR" },
            new Employee { Id = 3, Name = "Niranjan", Designation = "Sales Representative", Department = "Sales" },
            new Employee { Id = 4, Name = "Sahil", Designation = "Engineer", Department = "IT" }
        };

       
        Console.WriteLine("Employees in the Sales department:");
        foreach (var employee in employees)
        {
            if (employee.Department == "Sales")
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Designation: {employee.Designation}, Department: {employee.Department}");
            }
        }

        
        Console.WriteLine("\nEmployees whose name starts with 'S':");
        foreach (var employee in employees)
        {
            if (employee.Name.StartsWith("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Designation: {employee.Designation}, Department: {employee.Department}");
            }
        }
    }
}



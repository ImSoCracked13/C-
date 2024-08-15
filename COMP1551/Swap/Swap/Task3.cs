using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

public enum Role
{
    Manager,
    Associate,
    Admin,
    Intern
}

public class Employee
{
    private string Name;
    private Role Role;
    private DateTime Date;

    public Employee(string name, Role role, DateTime date)
    {
        Name = name;
        Role = role;
        Date = date;
    }

    public void SetRole(Role role)
    {
        Role = role;
    }

    public Role GetRole()
    {
        return Role;
    }


    public void SetStartDate(DateTime date)
    {
        Date = date;
    }

    public DateTime GetStartDate()
    {
        return Date;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        // Adding sample employees
        employees.Add(new Employee("John", Role.Manager, new DateTime(2020, 1, 1)));
        employees.Add(new Employee("Alice", Role.Associate, new DateTime(2021, 3, 15)));
        employees.Add(new Employee("Bob", Role.Admin, new DateTime(2019, 8, 10)));
        employees.Add(new Employee("Eva", Role.Intern, new DateTime(2022, 5, 20)));

        Console.WriteLine("Select a role to list employees: ");
        Console.WriteLine("1. Manager");
        Console.WriteLine("2. Associate");
        Console.WriteLine("3. Admin");
        Console.WriteLine("4. Intern");

        int choice = int.Parse(Console.ReadLine());

        Role selectedRole = Role.Manager; // Default role

        switch (choice)
        {
            case 1:
                selectedRole = Role.Manager;
                break;
            case 2:
                selectedRole = Role.Associate;
                break;
            case 3:
                selectedRole = Role.Admin;
                break;
            case 4:
                selectedRole = Role.Intern;
                break;
            default:
                Console.WriteLine("Invalid choice. Listing all employees.");
                break;
        }

        Console.WriteLine($"Employees in role {selectedRole}:");
        foreach (Employee emp in employees)
        {
            if (emp.GetRole() == selectedRole)
            {
                Console.WriteLine($"{emp.GetRole()} - {emp.GetStartDate()} - {emp.GetName()}");
            }
        }
    }
}

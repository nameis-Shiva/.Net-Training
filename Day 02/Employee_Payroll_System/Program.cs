using System;
using System.Collections.Generic;

abstract class Employee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public double Salary { get; protected set; }

    public abstract double CalculateSalary();

    public void DisplayInfo()
    {
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Employee Name: {EmployeeName}");
        Console.WriteLine($"Salary: {CalculateSalary()}");
        Console.WriteLine();
    }
}

class PermanentEmployee : Employee
{
    public PermanentEmployee(int employeeID, string employeeName)
    {
        EmployeeID = employeeID;
        EmployeeName = employeeName;
    }

    public override double CalculateSalary()
    {
        Salary = 45000;
        return Salary;
    }
}

class ContractEmployee : Employee
{
    public ContractEmployee(int employeeID, string employeeName)
    {
        EmployeeID = employeeID;
        EmployeeName = employeeName;
    }

    public override double CalculateSalary()
    {
        Salary = 75000;
        return Salary;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        employees.Add(new PermanentEmployee(1, "Shiva"));
        employees.Add(new ContractEmployee(2, "Krishna"));

        foreach (Employee e in employees)
        {
            e.DisplayInfo();
        }
    }
}
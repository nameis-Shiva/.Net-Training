using System;
using System.Collections.Generic;

abstract class Person
{
    public int Id {get; set;}

    public string Name{get; set;}

    public Person(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void GetDetails()
    {
        // Console.WriteLine($"Id: {Id}, Name: {Name}");
    }

    public abstract void PerformDuty();
}

class Doctor : Person
{
    public string Department{get; set;}

    public Doctor(int id, string name, string department): base(id, name)
    {
        Department = department;
    }

    public override void PerformDuty()
    {
        Console.WriteLine($"Doctor {Name} is treating patients");
    }
}

class Nurse : Person
{
    public string Department{get; set;}

    public Nurse(int id, string name, string department): base(id, name)
    {
        Department = department;
    }

    public override void PerformDuty()
    {
        Console.WriteLine($"Nurse {Name} is assisting doctors");
    }
}

class Patient: Person
{
    public string Disease{get; set;}

    public Patient(int id, string name, string disease): base(id, name)
    {
        Disease = disease;
    }

    public override void PerformDuty()
    {
        Console.WriteLine($"Patient {Name} is receiving treatment");
    }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        people.Add(new Doctor(1, "Krishna", "Cardiology"));
        people.Add(new Nurse(2, "Ravi", "General"));
        people.Add(new Doctor(3, "Anu", "Fever"));

        foreach (Person person in people)
        {
            person.GetDetails();
            person.PerformDuty();
            Console.WriteLine();
        }
    }
}
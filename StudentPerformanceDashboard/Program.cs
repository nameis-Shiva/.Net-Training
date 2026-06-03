using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public int Marks;
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show Students");
            Console.WriteLine("3. Top Students");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            if(choice == "1")
            {
                Student s = new Student();

                Console.Write("Enter Name: ");
                s.Name = Console.ReadLine();

                Console.Write("Enter Marks: ");

                int marks;
                if(int.TryParse(Console.ReadLine(), out marks))
                {
                    s.Marks = marks;
                    students.Add(s);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            else if(choice == "2")
            {
                foreach(Student s in students)
                {
                    Console.WriteLine(s.Name +  "-" + s.Marks);
                }
            }
            else if (choice == "3")
            {
                foreach (Student s in students)
                {
                    if(s.Marks > 75)
                    {
                        Console.WriteLine(s.Name+ "-"+ s.Marks);
                    }
                }
            }
            else if(choice == "4")
            {
                break;
            }
        }
    }
}
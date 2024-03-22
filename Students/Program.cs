using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            string[] studentInfo = input.Split();
            Student student = new Student
            {
                FirstName = studentInfo[0],
                LastName = studentInfo[1],
                Age = int.Parse(studentInfo[2]),
                HomeTown = studentInfo[3]
            };

            students.Add(student);
        }

        string city = Console.ReadLine();
        List<Student> filteredStudents = students.Where(s => s.HomeTown == city).ToList();

        foreach (Student student in filteredStudents)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
        }
    }
}

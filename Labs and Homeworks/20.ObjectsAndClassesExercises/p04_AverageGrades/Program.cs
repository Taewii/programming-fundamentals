using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();

        while (n-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            Student student = new Student();
            student.Name = input[0];
            student.Grades = input.Skip(1).Select(double.Parse).ToArray();

            students.Add(student);
        }

        foreach (var s in students.Where(s => s.Average >= 5).OrderBy(s => s.Name).ThenByDescending(s => s.Average).ToList())
        {
            Console.WriteLine($"{s.Name} -> {s.Average:f2}");
        }
    }
}

class Student
{
    public string Name { get; set; }
    public double[] Grades { get; set; }
    public double Average
    {
        get
        {
            return Grades.Average();
        }
    }
}


using System;
using System.Collections.Generic;

namespace StudentFilteringSystem
{
    // Student Class
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public int Age { get; set; }

        public Student(string name, int marks, int age)
        {
            Name = name;
            Marks = marks;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating list of students
            List<Student> students = new List<Student>()
            {
                new Student("Varun", 75, 17),
                new Student("Indhu", 55, 19),
                new Student("Nikhil", 82, 16),
                new Student("Gowtham", 45, 18),
                new Student("Deepthi", 67, 20),
                new Student("Sneha", 90, 17)
            };

            // Predicate for Marks > 60
            Predicate<Student> highMarks = s => s.Marks > 60;
            List<Student> result1 = students.FindAll(highMarks);

            Console.WriteLine("Students with Marks > 60:");
            foreach (var s in result1)
            {
                Console.WriteLine(s.Name + " - " + s.Marks);
            }

            Console.WriteLine();

            // Predicate for Age < 18
            Predicate<Student> ageLess = s => s.Age < 18;
            List<Student> result2 = students.FindAll(ageLess);

            Console.WriteLine("Students with Age < 18:");
            foreach (var s in result2)
            {
                Console.WriteLine(s.Name + " - " + s.Age);
            }

            Console.WriteLine();

            // Predicate for Name starts with 'A'
            Predicate<Student> startsWithA = s => s.Name.StartsWith("A");
            List<Student> result3 = students.FindAll(startsWithA);

            Console.WriteLine("Students whose name starts with 'A':");
            foreach (var s in result3)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine();

            // Using Exists()
            bool isAnyBelow18 = students.Exists(s => s.Age < 18);
            Console.WriteLine("Is there any student with Age < 18? " + isAnyBelow18);

            bool isAnyHighMarks = students.Exists(s => s.Marks > 90);
            Console.WriteLine("Is there any student with Marks > 90? " + isAnyHighMarks);

            
        }
    }
}
using System;
namespace ConstructorOverloading
{
    class Student
    {
        int id;
        string name;
        public Student()//Default Constructor
        {
            id = 0;
            name = "Unknown";
        }
        public Student(int i, string n) // Parameterized Constructor
        {
            id = i;
            name = n;
        }

        public void Display()
        {
            Console.WriteLine("Id: " + id + " Name: " + name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();              // Default constructor
            Student s2 = new Student(152, "Indira"); // Parameterized constructor

            s1.Display();
            s2.Display();
        }
    }
}
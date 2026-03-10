using System;

namespace StudentDetails
{
    class Student
    {
        string studentName;
        string rollNumber;
        int[] marks = new int[5];
        public Student(string name, string roll, int[] m)
        {
            studentName = name;
            rollNumber = roll;
            marks = m;
        }
        public double CalculateAverage()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += marks[i];
            }
            return sum / 5.0;
        }
        public string CalculateGrade()
        {
            double avg = CalculateAverage();

            if (avg >= 90) return "A+";
            else if (avg >= 80) return "A";
            else if (avg >= 70) return "B";
            else if (avg >= 60) return "C";
            else if (avg >= 50) return "D";
            else return "Fail";
        }
        public void PrintReport()
        {
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Roll Number: " + rollNumber);
            Console.WriteLine("Marks:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
            }

            Console.WriteLine("Average: " + CalculateAverage());
            Console.WriteLine("Grade: " + CalculateGrade());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Roll Number: ");
            string roll = Console.ReadLine();
            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            Student s = new Student(name, roll, marks);
            Console.WriteLine("\nStudent Report");
            s.PrintReport();
        }
    }
}
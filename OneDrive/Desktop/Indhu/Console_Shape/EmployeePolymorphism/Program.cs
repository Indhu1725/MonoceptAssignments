using System;

namespace EmployeePolymorphism
{
    // Base Class
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double BasicSalary;

        public Employee(int id, string name, double basic)
        {
            EmpId = id;
            EmpName = name;
            BasicSalary = basic;
        }
        // Virtual Method
        public virtual void CalculateSalary()
        {
            double totalSalary = BasicSalary;
            double annualCTC = totalSalary * 12;

            Console.WriteLine("Employee ID: " + EmpId);
            Console.WriteLine("Employee Name: " + EmpName);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("Total Salary: " + totalSalary);
            Console.WriteLine("Annual CTC: " + annualCTC);
        }
    }
    // Manager Class
    class Manager : Employee
    {
        public Manager(int id, string name, double basic) : base(id, name, basic) { }

        public override void CalculateSalary()
        {
            double TA = 0.5 * BasicSalary;
            double DA = 0.4 * BasicSalary;

            double totalSalary = BasicSalary + TA + DA;
            double annualCTC = totalSalary * 12;

            Console.WriteLine("\n--- Manager Details ---");
            Console.WriteLine("Employee ID: " + EmpId);
            Console.WriteLine("Employee Name: " + EmpName);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("TA: " + TA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("Total Salary: " + totalSalary);
            Console.WriteLine("Annual CTC: " + annualCTC);
        }
    }
    // Developer Class
    class Developer : Employee
    {
        public Developer(int id, string name, double basic) : base(id, name, basic) { }

        public override void CalculateSalary()
        {
            double PA = 0.4 * BasicSalary;

            double totalSalary = BasicSalary + PA;
            double annualCTC = totalSalary * 12;

            Console.WriteLine("\n--- Developer Details ---");
            Console.WriteLine("Employee ID: " + EmpId);
            Console.WriteLine("Employee Name: " + EmpName);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("PA: " + PA);
            Console.WriteLine("Total Salary: " + totalSalary);
            Console.WriteLine("Annual CTC: " + annualCTC);
        }
    }
    // Tester Class
    class Tester : Employee
    {
        public Tester(int id, string name, double basic) : base(id, name, basic) { }
        public override void CalculateSalary()
        {
            double Perks = 0.3 * BasicSalary;

            double totalSalary = BasicSalary + Perks;
            double annualCTC = totalSalary * 12;

            Console.WriteLine("\n--- Tester Details ---");
            Console.WriteLine("Employee ID: " + EmpId);
            Console.WriteLine("Employee Name: " + EmpName);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("Perks: " + Perks);
            Console.WriteLine("Total Salary: " + totalSalary);
            Console.WriteLine("Annual CTC: " + annualCTC);
        }
    }
    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];

            employees[0] = new Manager(1, "Indira", 50000);
            employees[1] = new Developer(2, "Saritha", 40000);
            employees[2] = new Tester(3, "Anusha", 30000);

            foreach (Employee emp in employees)
            {
                emp.CalculateSalary(); 
            }
        }
    }
}
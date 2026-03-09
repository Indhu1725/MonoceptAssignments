using System;
class Employee
{
    int id;
    string name;
    public Employee()
    {
        Console.WriteLine("Default Constructor");
    }

    public Employee(int id) : this()
    {
        this.id = id;
        Console.WriteLine("Constructor with Id: " + id);
    }
    public Employee(int id, string name) : this(id)
    {
        this.name = name;
        Console.WriteLine("Constructor with Id and Name: " + id + " " + name);
    }
    static void Main()
    {
        Employee e = new Employee(152, "Indira");
    }
}
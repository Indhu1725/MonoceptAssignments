namespace AcedemicCourse
{
        // Abstract Base Class
        abstract class Course
        {
            public string Subject { get; set; }
            public int Capacity { get; set; }
            public int RegisteredStudents { get; set; }
            // Constructor
            public Course(string name, int max)
            {
                Subject = name;
                Capacity = max;
                RegisteredStudents = 0;
            }
            // Abstract Method
            public abstract void EnrollStudent(string studentName);
        }
        // Online Course
        class OnlineCourse : Course
        {
            public OnlineCourse(string name, int max) : base(name, max) { }
            public override void EnrollStudent(string studentName)
            {
                if (RegisteredStudents < Capacity)
                {
                    RegisteredStudents++;
                    Console.WriteLine(studentName + " enrolled in Online Course: " + Subject);
                }
                else
                {
                    Console.WriteLine("Enrollment full for " + Subject);
                }
            }
        }
        // In-Person Course
        class InPersonCourse : Course
        {
            public string Classroom { get; set; }

            public InPersonCourse(string name, int max, string room) : base(name, max)
            {
                Classroom = room;
            }
            public override void EnrollStudent(string studentName)
            {
                if (RegisteredStudents < Capacity)
                {
                    RegisteredStudents++;
                    Console.WriteLine(studentName + " enrolled in In-Person Course: " + Subject + " Room: " + Classroom);
                }
                else
                {
                    Console.WriteLine("Classroom capacity reached for " + Subject);
                }
            }
        }
        // Lab Course
        class LabCourse : Course
        {
            public bool SafetyTrainingCompleted { get; set; }

            public LabCourse(string name, int max, bool safety) : base(name, max)
            {
                SafetyTrainingCompleted = safety;
            }
            public override void EnrollStudent(string studentName)
            {
                if (!SafetyTrainingCompleted)
                {
                    Console.WriteLine(studentName + " cannot enroll in " + Subject + " (Safety training required)");
                    return;
                }
                if (RegisteredStudents < Capacity)
                {
                    RegisteredStudents++;
                    Console.WriteLine(studentName + " enrolled in Lab Course: " + Subject);
                }
                else
                {
                    Console.WriteLine("Lab capacity reached for " + Subject);
                }
            }
        }
        // Main Program
        class Program
        {
            static void Main(string[] args)
            {
                Course c1 = new OnlineCourse("Python", 3);
                Course c2 = new InPersonCourse("C# Programming", 2, "Room 105");
                Course c3 = new LabCourse("Chemistry Lab", 2, true);
                c1.EnrollStudent("Gowtham");
                c2.EnrollStudent("Varun");
                c3.EnrollStudent("Nikhil");


            Console.ReadLine();
            }
        }
    }

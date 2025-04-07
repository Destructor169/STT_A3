using System;

class Student
{
    // Properties
    public string Name { get; set; }
    public string ID { get; set; }
    public int Marks { get; set; }

    // Constructor
    public Student(string name, string id, int marks)
    {
        Name = name;
        ID = id;
        Marks = marks;
    }

    // Copy constructor
    public Student(Student other)
    {
        Name = other.Name;
        ID = other.ID;
        Marks = other.Marks;
    }

    // Overloaded constructor
    public Student() : this("Unknown", "00000000", 0) { }

    // Method to get grade
    public char GetGrade()
    {
        if (Marks >= 90) return 'A';
        else if (Marks >= 80) return 'B';
        else if (Marks >= 70) return 'C';
        else if (Marks >= 60) return 'D';
        else return 'F';
    }
}

class StudentIITGN : Student
{
    public string Hostel_Name_IITGN { get; set; }

    public StudentIITGN(string name, string id, int marks, string hostel)
        : base(name, id, marks)
    {
        Hostel_Name_IITGN = hostel;
    }
}

class Program
{
    static void Main()
    {
        // Test base Student class
        Console.WriteLine("Testing Student class:");
        Student s1 = new Student("Alice", "20210101", 85);
        Console.WriteLine($"Student: {s1.Name}, ID: {s1.ID}, Marks: {s1.Marks}, Grade: {s1.GetGrade()}");

        // Using copy constructor
        Student s2 = new Student(s1);
        s2.Name = "Bob";
        Console.WriteLine($"Student: {s2.Name}, ID: {s2.ID}, Marks: {s2.Marks}, Grade: {s2.GetGrade()}");

        Console.WriteLine("\nTesting StudentIITGN class:");
        // Test StudentIITGN class
        StudentIITGN s3 = new StudentIITGN("Charlie", "20210202", 92, "Aaberg");
        Console.WriteLine($"IITGN Student: {s3.Name}, Hostel: {s3.Hostel_Name_IITGN}, Grade: {s3.GetGrade()}");
    }
}

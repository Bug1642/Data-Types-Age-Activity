using System;

class StudentInput
{
    public int Age()
    {
        int age = 25;
        return age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentInput student = new StudentInput();
        Console.WriteLine($"Student age is: {student.Age()}");
    }
}

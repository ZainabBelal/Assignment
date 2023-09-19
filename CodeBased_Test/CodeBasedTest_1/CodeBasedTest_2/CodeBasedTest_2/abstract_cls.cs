using System;

class abstract_cls
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Name:");

        Undergraduate undergrad1 = new Undergraduate
        {
            Name = "Zainab",
            StudentId = "B83",
            Grade = 70.0

        };
        Console.WriteLine("Name is: {0}", undergrad1.Name);
        Console.WriteLine("Student ID is: {1}", undergrad1.StudentId); 
        Console.WriteLine("Grade is: {2}", undergrad1.Grade);
        Console.WriteLine("'The student is passed': {3}", undergrad1.IsPassed());


        Graduate grad1 = new Graduate
        {
            Name = "Shweta",
            StudentId = "A86",
            Grade = 90.0
        };
        Console.WriteLine("Name is:" + grad1.Name);
        Console.WriteLine("Student ID is:" + grad1.StudentId);
        Console.WriteLine("Grade is:" + grad1.Grade);
        Console.WriteLine("'The student is passed':" + grad1.IsPassed());
        Console.ReadLine();
    }
}

public abstract class Student
{
    public string Name { get; set; }
    public string StudentId { get; set; }
    public double Grade { get; set; }

    public abstract bool IsPassed();
}


public class Undergraduate : Student
{
    public override bool IsPassed()
    {
        return Grade > 70.0;
    }
}

public class Graduate : Student
{
    public override bool IsPassed()
    {
        return Grade > 80.0;

    }
}


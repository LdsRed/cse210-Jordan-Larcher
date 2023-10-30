using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment("Jordan Larcher", "Matematicas");

        Console.WriteLine(assignment1.GetSummary());

        WrittingAssignment writtingAssignment = new WrittingAssignment("jordan larcher", "History", "The Causes of World War");
        

        Console.WriteLine(writtingAssignment.GetWritingInformation());
    }
}
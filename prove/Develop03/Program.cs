using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        // Create a scripture with a reference and text
       

        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Reference reference = new Reference("John 3:16");
        Scripture scripture = new Scripture(reference, scriptureText);


        scripture.ScriptureMemorizer();

    
    }
}
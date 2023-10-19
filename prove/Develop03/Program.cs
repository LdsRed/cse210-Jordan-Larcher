using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        // Create a scripture with a reference and text
        Reference reference = new Reference("John 3:16");
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine($"Scripture Reference: {scripture.Reference.SetGetReference}\n");

            foreach (var word in scripture.Words)
            {
                if (word.Hidden)
                    Console.Write("***** ");
                else
                    Console.Write(word.Text + " ");
            }

            Console.WriteLine("\n\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord();
        }
    
    }
}
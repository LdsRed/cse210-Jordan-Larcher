
using System.IO;
using System;
using System.Collections.Generic;
using System.Net;
namespace ReadWriteFiles;

class Journal
{

    //Member Variables
    List<Entry> _entries = new();
    string _fileName;
    List<String> listOfFilenames = new();

    //File _file = new();




    //Constructor
    public Journal()
    {

    }


    public void Menu()
    {
        string selection = "";
        while (selection != "5")
        {


            Console.WriteLine("Please selec one of the following choices: ");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit ");
            Console.WriteLine("What whould you like to do? ");
            selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    DisplayEntries();
                    break;
                case "3":
                    LoadJournalFile();
                    break;
                case "4":
                    SaveFile();
                    break;
                case "5":
                    break;
            }

        }

    }

    // Option 4
    public void SaveFile()
    {
        Console.WriteLine();
        Console.WriteLine("What is the name of the file? ");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {

            foreach (Entry entries in _entries)
            {
                outputFile.WriteLine(entries.TransformToString());
            }


        }

        listOfFilenames.Add(_fileName);

    }

    // Option 2
    //We will display all the entries in the List of strings for the entries
    public void DisplayEntries()
    {

        foreach (Entry entries in _entries)
        {
            entries.Display();
            Console.WriteLine();
        }
    }


    //Option 1
    public void WriteEntry()
    {

        Entry entry = new();
        PromptGenerator generator = new();
        string prompt = generator.GeneratePrompt();
        entry.SetPrompt(prompt);
        Console.WriteLine(prompt);
        entry.SetEntry(Console.ReadLine());
        entry.SetDate();
        _entries.Add(entry);

    }




    public void LoadJournalFile()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        string data;
        string input;
        Console.WriteLine();

        StreamReader reader = null;

        try
        {
            reader = new StreamReader(filename);
            data = reader.ReadLine();
            Boolean response = true;
            while (response)
            {
                while (data != null)
                {
                    Console.WriteLine(data);
                    data = reader.ReadLine();
                }

                Console.WriteLine();
                Console.WriteLine("Would you like to load another file? (Yes/No)");
                input = Console.ReadLine();

                if (input.ToLower() == "yes")
                {
                    Console.WriteLine("What is the filename? ");
                    filename = Console.ReadLine();
                    reader = new StreamReader(filename);
                    data = reader.ReadLine();
                    while (data != null)
                    {
                        Console.WriteLine(data);
                        data = reader.ReadLine();
                        Console.WriteLine();
                    }
                }
                else
                {
                    response = false;
                }
            }
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }

    }



}


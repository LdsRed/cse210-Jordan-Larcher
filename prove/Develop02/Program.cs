using System;
using ReadWriteFiles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");


        Journal journal = new();
        

        journal.Menu();
    }
}

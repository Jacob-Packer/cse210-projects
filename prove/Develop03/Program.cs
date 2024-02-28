using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Hello Scripture Memorizer World!");
        Console.WriteLine();
        // make a new scripture
        string book = "Isaiah";
        int chapter = 1;
        string verse = "2-3";
        string scriptureText = "scripture text";
        Reference reference = new Reference(book, chapter, verse);
        Scripture scripture = new Scripture(reference, scriptureText);

        scripture.DisplayScripture();

        //call hide scripture method
        
    }
}
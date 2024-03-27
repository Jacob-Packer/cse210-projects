using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Program 
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Hello Scripture Memorizer World!");
        while (true)
        {
            Console.WriteLine();
            // make a new scripture
            string book = "1 Nephi";
            int chapter = 3;
            string verse = "7";
            string scriptureText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
            Console.Write("Press [Enter] to quit or enter Difficulty Level (number): ");
            double difficultyLevel;
            if (!double.TryParse(Console.ReadLine(), out difficultyLevel))
            {
                // Handle parse error for completionScore here
                Environment.Exit(0);
            }
            Reference reference = new Reference(book, chapter, verse);
            Scripture scripture = new Scripture(reference, scriptureText, difficultyLevel);


        string print = scripture.GetScripture();
        Console.WriteLine(print);
        }
        
    }
}
using System;
using System.IO.Enumeration;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Globalization; // Added this for List<string>

// Make UML diagram

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to your JournalApp!\n");
        JournalApp journalApp = new JournalApp();
        Journal journal = new Journal();
        journalApp.DisplayMenu(journal);
    }
    
}
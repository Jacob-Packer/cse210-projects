using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Mindfulness App World!");

        // Menu active until quit
        bool quit = false;
        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflecting");
            Console.WriteLine("3. Writing");
            Console.WriteLine("4. Quit");
            Console.Write("Enter an option:\n > ");
            
            int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Breathing game1 = new Breathing();
                        game1.Play();
                        break;
                    case 2:
                        Reflecting game2 = new Reflecting();
                        game2.Play();
                        break;
                    case 3:
                        Listing game3 = new Listing();
                        game3.Play();
                        break;                   
                    case 4:
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Enter a number.");
                        break;
                }    
        }   
        Console.WriteLine("\nCongratulations on taking care of yourself.");  
        Thread.Sleep(1500);
        Console.Clear();
    }
}
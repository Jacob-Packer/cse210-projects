 using System;
using System.Runtime.InteropServices;
 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Magic Number World!");
        // create a random number
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        // Enter do while loop because they have to put at least one guess
        int guess = 0;
        do {
            // ask user for guess
            Console.WriteLine("Guess the number:");
            // have user enter a guess and parse to int
            guess = int.Parse(Console.ReadLine());
            // compare guess to magicNumber. if guess == magicNumber
            if (guess == magicNumber){
                Console.WriteLine($"You guessed the Magic Number: {magicNumber}");}
            else {
            // if guess != magicNumber compare further
                if (guess > magicNumber){
                    Console.WriteLine("Guess lower.");
                }
                else if (guess < magicNumber){
                    Console.WriteLine("Guess higher.");
                }
            }
        } while (magicNumber != guess);
    }
}
           
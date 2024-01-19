using System;

class Program
{
    static void Main(string[] args)
    {
        

        //  - Displays the message, "Welcome to the Program!"
        Console.WriteLine("Hello Functions World!");
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
            }

        //  - Asks for and returns the user's name (as a string)
        static string PromptUserName(){
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            return name;
            }

        //  - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber(){
            Console.WriteLine("Enter a favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
            }

        //  - Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int number){
            Console.WriteLine("Doing math...");
            int numberSquared = number * number;
            return numberSquared;
            }
    
        //  - Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string name, int numberSquared){
            Console.WriteLine($"{name}, the square of your number is {numberSquared}.");
            }

    
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numberSquared = SquareNumber(number);
        DisplayResult(name, numberSquared);
    }
}
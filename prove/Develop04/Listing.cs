using Microsoft.VisualBasic;

class Listing : Game
{
    public Listing() 
    {
        GameDuration = 6000;
        LoadingMessage = "Reflecting...";
    }

    public override void Play()
    {        
        Console.Clear();
        Console.WriteLine("Think about the best things that happened to you today.");
        LoadingAnimation(GameDuration, LoadingMessage);
        Console.WriteLine("\n\nGo ahead and write them down.");
        Console.Write("My entry: ");
        string response = Console.ReadLine();
        Console.WriteLine();
        LoadingAnimation(GameDuration / 4, "Saving Response...");
        Console.WriteLine($"\nYou wrote: \"{response}\"");
        Console.WriteLine("\nPress [Enter] to continue.");
        Console.Read();
        FinishGame();
    }
}
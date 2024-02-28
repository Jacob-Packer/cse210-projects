using Microsoft.VisualBasic;

abstract class Game 
{
    protected int GameDuration;
    protected int GamePause = 2000;
    protected string LoadingMessage = "";
    protected virtual void CountdownTimer(int duration)
    {
        //TO DO: Make a countdown Timer
    }
    protected virtual void LoadingAnimation(int gameDuration = 1000, string message = "loading")
    {
        int i = 0;
        string[] symbols = { "|", "/", "-", "\\" };
        while (i < gameDuration / 100)
        {
            Console.Write($"\r{message} " + symbols[i % symbols.Length]);
            Thread.Sleep(100);
            i++;
        }
        // Console.WriteLine("\nFinished loading!");
        // Console.Clear();
        Thread.Sleep(500);
        
    }
    public virtual void FinishGame()
    {
        Console.Clear();
        Console.WriteLine("\nGood job playing this game! Press [Enter] to continue.");
        Console.ReadLine();
        LoadingAnimation(GamePause / 2, "Loading Menu");
    }
    public abstract void Play();
}
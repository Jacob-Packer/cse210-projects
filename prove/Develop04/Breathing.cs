using System.ComponentModel;

class Breathing : Game
{
    public Breathing()
    {
        GameDuration = 5000;
        LoadingMessage = "Breathing...";
    }

    public override void Play()
    {
        Console.Clear();
        Console.WriteLine("How many breaths do you want to take?");
        int breaths = int.Parse(Console.ReadLine());
        while (breaths > 0)
        {
            Console.Clear();
            Console.WriteLine("BREATHE IN");
            LoadingAnimation(GameDuration / 2, LoadingMessage);
            Console.Clear();
            Console.WriteLine("BREATHE OUT");
            LoadingAnimation(GameDuration / 2, LoadingMessage);
            Console.Clear();
            breaths--;
        }
        FinishGame();
    }
}
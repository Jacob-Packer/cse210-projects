using System.ComponentModel;
using System.Net;

class Reflecting : Game
{
    public Reflecting()
    {
        GameDuration = 7000;
        LoadingMessage = "Reflecting...";
    }

    public override void Play()
    {
        Console.Clear();
        Console.WriteLine("Think about the best things that happened to you today.");
        LoadingAnimation(GameDuration, LoadingMessage);
        Console.WriteLine("Feelest thou better?");
        FinishGame();
    }
}
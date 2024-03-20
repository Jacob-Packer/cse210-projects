class Game
{
    private string name = "KENZI";
    public Game(){}
    public void DisplayBattlefield()
    {
        // Console.Clear();
        // Set cursor position for duck
        Console.CursorLeft = 0;
        Console.CursorTop = Console.WindowHeight - 5;

        // Print duck ASCII art
        Console.Write("(o>\n<_)");

        // Set cursor position for stick man
        Console.CursorLeft = Console.BufferWidth - 5;
        Console.CursorTop = Console.WindowHeight - 5;

        // Print stick man ASCII art
        Console.WriteLine(" o ");

        Console.CursorLeft = Console.BufferWidth - 5;
        Console.CursorTop = Console.WindowHeight - 4;
        Console.WriteLine("/|\\");

        Console.CursorLeft = Console.BufferWidth - 5;
        Console.CursorTop = Console.WindowHeight - 3;
        Console.WriteLine("/ \\");

        // Add some space for readability
        Console.WriteLine();
    }
    public void DuckLeavingCageAnimation()
    {
        Console.Clear();
        Console.WriteLine("\n\n\n\n");
        Console.WriteLine("  _______  ");
        Console.WriteLine(" / |   | \\ ");
        Console.WriteLine("|  |(o>|  |      >o)");
        Console.WriteLine("|  |<_)|  |      (_>)");
        Console.WriteLine("|__|___|__|");
        Thread.Sleep(2000); // Delay for 1 second
        
        // Clear the screen to simulate animation
        Console.Clear();

        Console.WriteLine("\n\n");
        Console.WriteLine("  |   (o<");
        Console.WriteLine("  |   <_)");
        Console.WriteLine("  |  :.   ");
        Console.WriteLine(" / |   | \\ ");
        Console.WriteLine("|  |   |  |      >o)");
        Console.WriteLine("|  |   |  |      (_>)");
        Console.WriteLine("|__|___|__|");
        Thread.Sleep(1000); // Delay for 0.8 second

        // Clear the screen to simulate animation
        
        double index = 5;
        while (index >= 0)
        {
            Thread.Sleep(500); // Delay for 0.5 second
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("\\   ");
            Console.WriteLine(" \\   ");
            Console.WriteLine("  |   ");
            Console.WriteLine(" / |   | \\      <3");
            Console.WriteLine("|  |   |  |   (o< <o)");
            Console.WriteLine("|  |   |  |   <_) (_>");
            Console.WriteLine("|__|___|__|");

            Thread.Sleep(500); // Delay for 0.5 second
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("\\   ");
            Console.WriteLine(" \\   ");
            Console.WriteLine("  |   ");
            Console.WriteLine(" / |   | \\      <3");
            Console.WriteLine("|  |   |  |   (o> >o)");
            Console.WriteLine("|  |   |  |   <_) (_>");
            Console.WriteLine("|__|___|__|");
            index--;
        }
        Thread.Sleep(2000);

        Console.WriteLine($"Happy Day!\n You freed {name}.");
        Console.Write("Press [ENTER] to continue...");
        Console.ReadLine();

    }
    public string GetName()
    {
        return name;
    }
}
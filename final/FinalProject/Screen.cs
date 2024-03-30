class Screen
{
    public string[,] InitializeScreen()
    {
        string[,] screen = new string[4, 80]; // Declare array
        for (int row = 0; row < 4; row++) 
        {
            for (int col = 0; col < 80; col++)
            {
                screen[row, col] = " "; // Initialize each cell with a space string
            }
        }
        return screen; // Return the initialized array
    }
    public void PrintScreen(Array screen)
    {
        foreach (string c in screen)
        {
            Console.WriteLine(c);
        }
    }
}
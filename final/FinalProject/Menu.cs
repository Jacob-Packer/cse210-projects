class Menu
{
    public List<string> menuOptions { get; set; }
    public Menu()
    {
        menuOptions = new List<string>();
        menuOptions = new List<string>(){"Attack", "Defend"};
    }
    public void DisplayMenu()
    {
        int index = 1;
        foreach (string option in menuOptions)
        {
            Console.WriteLine($"[{index}] {option}");
            index++;
        }
    }
}
public class JournalApp {
    // Menu options
    public void DisplayMenu() 
    {
        // Menu options
        string[] menuOptions = {"New Entry", "Quit", "Display Journal", "Mazda"};
        // Print Menu
        while (true) {
            int index = 1;
            foreach (string option in menuOptions) {
                Console.WriteLine($"{index}. {option}");
                index++;
            }

            // Get user choice
            Console.Write("Choose an option.\n  > ");
            int choice = int.Parse(Console.ReadLine());

            //switch case tree 
            switch (choice){
                case 1:
                    Console.WriteLine("You made it to New Entry!");
                    // NewEntry();    
                    
                break;

                case 2:
                    Console.WriteLine("You Quit");
                    Environment.Exit(0);
                    break;

                case 3:
                    // Instantiate new entry
                    
                    Console.WriteLine("You can view past entries");
                    // entry = new Entry;
                    break;
                default:
                    Console.WriteLine("Choose a valid option.");
                    break;
                
            }
        }
    }

    // Reading/Loading a file
    // Not sure how to make this better
    public string filename;
    public void ReadFile(string filename) {
        this.filename = filename;
        // string filename = "myFile.txt"
        Console.Write("Enter the name of the file\n  > ");
        filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Declare some symbol to split by
            string[] parts = line.Split("(*_*)");

            string date = parts[0];
            string entry = parts[1];
        }
    }

    // Writing/overwriting a file
    public void WriteFile(string filename, string prompt) {
        // string filename = "myFile.txt";
        this.filename = filename;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            outputFile.WriteLine($"Date - {dateText};*_*{prompt}");
        }
    }  


}

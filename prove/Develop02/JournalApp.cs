public class JournalApp {
    // Menu options
    public void DisplayMenu(Journal journal) 
    {
        // Menu options
        string[] menuOptions = {"New Entry", "Save Journal to File", "Load Journal File", "Display Journal Entries", "Quit"};
        // Print Menu
        while (true) {
            int index = 1;
            foreach (string option in menuOptions) {
                Console.WriteLine($"{index}. {option}");
                index++;
            }

            // Get user choice
            Console.WriteLine();
            Console.Write("Choose an option.\n  > ");
            int choice = int.Parse(Console.ReadLine());

            //switch case tree 
            switch (choice){
                case 1:
                    // NewEntry(); 
                    string prompt = journal.GetRandomPrompt();
                    string response = journal.GetResponse(prompt);                    
                    Entry entry = new Entry(prompt, response);
                    journal.entries.Add(entry);
                    entry.DisplayEntry();   
                    break;
                
                case 2:
                    // write file/save file
                    Console.WriteLine("writing/saving journal file...");
                    journal.SaveFile();
                    Console.WriteLine("Your file has been saved.");
                    break;

                case 3:
                    // load journal/read file
                    Console.WriteLine("Reading/Loading journal file...");
                    journal.ReadFile();
                    Console.WriteLine("You have loaded a journal file.");
                    break;

                case 4:
                    // display Journal
                    Console.WriteLine("Displaying journal file...");
                    journal.DisplayJournal();
                    break;

                case 5:
                    Console.WriteLine("You Quit");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Choose a valid option.");
                    break;
                
            }
        }
    }

     


}

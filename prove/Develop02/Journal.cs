// class Journal {
//     // Menu options
//     class Menu {
//         List<string> menuOptions = ["A", "B", "C", "D"];
//     }

//     // Reading/Loading a file
//     public string filename;
//     public void ReadFile(string filename) {
//         this.filename = filename;
//         // string filename = "myFile.txt"
//         string[] lines = System.IO.File.ReadAllLines(filename);

//         foreach (string line in lines)
//         {
//             // Declare some symbol to split by
//             string[] parts = line.Split("(*_*)");

//             string date = parts[0];
//             string entry = parts[1];
//         }
//     }

//     // Writing/overwriting a file
//     public void WriteFile(string filename, string prompt) {
//         // string filename = "myFile.txt";
//         this.filename = filename;
//         using (StreamWriter outputFile = new StreamWriter(filename))
//         {
//             // You can add text to the file with the WriteLine method
//             outputFile.WriteLine("This will be the first line in the file.");
            
//             // You can use the $ and include variables just like with Console.WriteLine
//             DateTime theCurrentTime = DateTime.Now;
//             string dateText = theCurrentTime.ToShortDateString();
//             outputFile.WriteLine($"Date - {dateText};*_*{prompt}");
//         }
//     }  


// }

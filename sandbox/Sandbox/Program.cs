public class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Console.WriteLine("Hello Sandbox ICE Challenge World!");
        Room room = new Room();
        while (true)
        {
            Thread.Sleep(300);
            Console.WriteLine("\nMENU");
            Console.WriteLine("1. Add Device");
            Console.WriteLine("2. Display all devices in room");
            Console.WriteLine("3. Turn off all devices in room");
            Console.WriteLine("4. Turn on all devices in room");
            Console.WriteLine("5. Report All items in the room and their status");
            Console.WriteLine("9. Quit");
            
            //  print device list (1,2,3...)
            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    room.AddDevice();
                    break;
                case 2:
                    room.ReportAllItems();
                    break;
                case 3:
                    Console.WriteLine("Turn off all devices in room");
                    room.TurnOffAllDevices();
                    break;
                case 4:
                    Console.WriteLine("Turn on all devices in room");
                    room.TurnOnAllDevices();
                    break;
                case 5:
                    Console.WriteLine("Report All items in the room and their status");
                    break;
                case 9:
                    Console.WriteLine("You have quit SmartDevice Editor.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Enter a number.");
                    break;
            }
            
        }
    }
}
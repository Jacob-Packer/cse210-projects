using System.Threading.Tasks;

public class Room
{
    private List<SmartDevice> devices = new List<SmartDevice>();   
    int choice = 0;
    // Method to add devices to the room
    public void AddDevice()
    {
        Console.WriteLine("What kind of device would you like to add?\n1. Light\n2. Heater");
        choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            SmartLight newDevice = new SmartLight();
            devices.Add(newDevice);
        }
        else if (choice == 2)
        {
            SmartHeater newDevice = new SmartHeater();
            devices.Add(newDevice);
        }
    }

    // Method to turn on/off all devices in the room 
    public void TurnOnAllDevices()
    {
        foreach (var device in devices)
        {
            device.TurnOn();
        }
    }
    public void TurnOffAllDevices()
    {
        foreach (var device in devices)
        {
            device.TurnOff();
        }
    }
    // Method to report all items in the room and their status
    public void ReportAllItems()
    {
        Console.WriteLine("Devices:");
        int index = 1;
        foreach (var device in devices)
        {
            bool status = device.IsOn();
            string name = device.GetName();
            Console.WriteLine($"{index}. {name}: {(status ? "On" : "Off")}");
            index++;
        }
    }
}
    // Method to report all items that are on
//     public void ReportItemsOn()
//     {
//         Console.WriteLine("Items currently on:");
//         foreach (var device in devices)
//         {
//             if (device.IsOn)
//             {
//                 Console.WriteLine($"Device {device.name}");
//             }
//         }
//     }

//     // Method to report item that has been on the longest
//     // public void ReportLongestOn()
//     // {
//     //     var allItems = new List<ISmartItem>();
//     //     allItems.AddRange(lights);
//     //     allItems.AddRange(devices);

//     //     var longestOnItem = allItems.OrderByDescending(item => item.TimeElapsedSinceLastOn).FirstOrDefault();

//     //     if (longestOnItem != null)
//     //     {
//     //         Console.WriteLine($"Item that has been on the longest: {longestOnItem.Id}");
//     //     }
//     //     else
//     //     {
//     //         Console.WriteLine("No item is currently on in the room.");
//     //     }
//     // }
// }
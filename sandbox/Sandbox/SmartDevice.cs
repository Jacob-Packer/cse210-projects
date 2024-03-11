public abstract class SmartDevice
{
    private string name;
    private bool status = true;
    protected SmartDevice()
    {
        Console.Write("Name your new device.\n > ");
        this.name = Console.ReadLine();
    }
    public bool IsOn()
    {
        return status;
    }
    public void TurnOn()
    {
        if (!status)
        {
            status = true;
            Console.WriteLine($"You turned on {name}.");
        }
    }
    public void TurnOff()
    {
        if (status)
        {
            status = false;
            Console.WriteLine($"You turned off {name}.");
        }
    }
    public string GetName()
    {
        return name;
    }
}

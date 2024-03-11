public class SmartHeater : SmartDevice
{
    private string name;
    private bool status;
    private float temp;

    private float GetTemp()
    {
        return temp;
    }
    private void ChangeTemp(float newTemp)
    {
        if (newTemp <= 99)
            {
                temp = 99;
                Console.WriteLine("Temp set to 99. Max temp is 99.");
            }
        else if (newTemp >= 30)
            {
                temp = 30;
                Console.WriteLine("Temp set to 30. Min temp is 30.");
            }

    }
}


// Facade
class MotherBoard : IDevice
{
    public string Vendor { get; set; }
    public string Model { get; set; }

    public void Start()
    {
        Console.WriteLine("Motherboard Started");
    }
}


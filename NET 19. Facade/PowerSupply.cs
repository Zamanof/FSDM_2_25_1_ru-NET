// Facade
class PowerSupply : IDevice
{
    public string Vendor { get; set; }
    public string Model { get; set; }

    public void Start()
    {
        Console.WriteLine("PowerSupply Started");
    }
}


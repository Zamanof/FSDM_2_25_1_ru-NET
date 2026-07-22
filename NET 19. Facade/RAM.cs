// Facade
class RAM : IDevice
{
    public string Vendor { get; set; }
    public string Model { get; set; }

    public void Start()
    {
        Console.WriteLine("RAM Started");
    }
}


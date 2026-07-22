// Facade
class Case : IDevice
{
    List<IDevice> devices = new List<IDevice>();
    public string Vendor { get; set; }
    public string Model { get; set; }

    public void Start()
    {
        devices.ForEach(d => d.Start());
        Console.WriteLine("PC Started");
    }
    public void AddDevice(IDevice device)
    {
        devices.Add(device);
    }
}


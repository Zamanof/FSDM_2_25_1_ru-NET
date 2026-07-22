class Truck : ITransport
{
    public void Delivery(string productName)
    {
        Console.WriteLine($"Deliver {productName} by land in box.");
    }
}

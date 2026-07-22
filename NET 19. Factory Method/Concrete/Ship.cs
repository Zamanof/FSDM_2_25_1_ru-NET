class Ship : ITransport
{
    public void Delivery(string productName)
    {
        Console.WriteLine($"Deliver {productName} by sea in container.");
    }
}

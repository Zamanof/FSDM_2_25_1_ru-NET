// Observer
// Also know as: Event-Subscriber, Listener

// Subject - Publisher
// Observer - Subscribers




class Employee : Observer
{
    public override void Update(string message)
    {
        Console.WriteLine($"Message to employee: {message}");
    }
}
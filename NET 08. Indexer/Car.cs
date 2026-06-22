// indexer
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/
class Car
{
    public string Model { get; set; }
    public double Price { get; set; }
    public override string ToString()
    {
        return $"{Model} - {Price}$";
    }
}
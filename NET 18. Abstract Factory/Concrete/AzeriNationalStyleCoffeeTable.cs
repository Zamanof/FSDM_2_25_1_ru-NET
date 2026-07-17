class AzeriNationalStyleCoffeeTable : ICoffeeTable
{
    public AzeriNationalStyleCoffeeTable()
    {
        Console.WriteLine("Azerbaijan milli kofe stolu");
    }

    public bool CanOpen() => false;

    public bool HasRotate() => true;

}
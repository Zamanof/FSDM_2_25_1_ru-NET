class AzeriNationalStyleChair : IChair
{
    public AzeriNationalStyleChair()
    {
        Console.WriteLine("Azerbaijan milli stul");
    }

    public bool HasLegs() => true;

    public bool SitOn() => false;
}

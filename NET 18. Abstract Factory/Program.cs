IFurnutureFactory furnutureFactory = new AzeriNationalStyleMebelSexi();
furnutureFactory.CreateCoffeeTable();
furnutureFactory.CreateSofa();
furnutureFactory.CreateChair();

class AzeriNationalStyleMebelSexi : IFurnutureFactory
{
    public IChair CreateChair() => new AzeriNationalStyleChair();

    public ICoffeeTable CreateCoffeeTable()=> new AzeriNationalStyleCoffeeTable();

    public ISofa CreateSofa()=>new AzeriNationalStyleSofa();
}
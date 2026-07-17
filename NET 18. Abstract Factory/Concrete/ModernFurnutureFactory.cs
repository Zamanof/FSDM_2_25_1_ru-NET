class ModernFurnutureFactory : IFurnutureFactory
{
    public IChair CreateChair() => new ModernChair();

    public ICoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();

    public ISofa CreateSofa() => new ModernSofa();
}

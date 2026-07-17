interface IBuilder
{
    public House House { get; set; }
    IBuilder Reset();
    IBuilder BuildWall();
    IBuilder BuildDoor();
    IBuilder BuildGarage();
    IBuilder BuildPool();
    IBuilder BuildWindow();
    IBuilder BuildGarden();
    IBuilder BuildRoof();

    House GetHouse(); // build
}

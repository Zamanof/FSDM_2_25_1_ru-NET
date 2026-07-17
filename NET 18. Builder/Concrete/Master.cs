// Builder Pattern
// https://refactoring.guru/ru/design-patterns/builder

// Product
// Builder
// Builder: Concrete
// Director





class Master //Director
{
    private IBuilder _builder;

    public Master(IBuilder builder)
    {
        _builder = builder;
    }

    public void ChangeBuilder(IBuilder builder)
        => _builder = builder;

    public House Make(string type)
    {
        _builder.Reset();
        switch (type)
        {
            case "A":
                _builder.House.Name = "A type house"; 
                _builder.BuildDoor()
                        .BuildWindow()
                        .BuildWall()
                        .BuildWall()
                        .BuildWall()
                        .BuildWall()
                        .BuildRoof();
                break;
            case "B":
                _builder.House.Name = "B type house"; 
                _builder.BuildDoor()
                        .BuildWindow()
                        .BuildWall()
                        .BuildWall()
                        .BuildWall()
                        .BuildWall()
                        .BuildGarage()
                        .BuildRoof();
                break;

            case "C":
                _builder.House.Name = "C type house"; 
                _builder.BuildDoor()
                        .BuildWindow()
                        .BuildWall()
                        .BuildWall()
                        .BuildWall()
                        .BuildWall()
                        .BuildGarage()
                        .BuildPool()
                        .BuildRoof();
                break;

        }
        return _builder.GetHouse();
    }
}
// Builder Pattern
// https://refactoring.guru/ru/design-patterns/builder

// Product
// Builder
// Builder: Concrete
// Director

IBuilder builder = new IceBuilder();

//var stoneHouse = builder
//                        .BuildDoor()
//                        .BuildWindow()
//                        .BuildWindow()
//                        .BuildWindow()
//                        .BuildWindow()
//                        .BuildDoor()
//                        .BuildGarage()
//                        .BuildGarden()
//                        .GetHouse();


//Console.WriteLine(stoneHouse);

Master master = new(builder);
var house = master.Make("A");
var house2 = master.Make("B");
Console.WriteLine(house);
master.ChangeBuilder(new StoneBuilder());
house = master.Make("B");
Console.WriteLine(house);
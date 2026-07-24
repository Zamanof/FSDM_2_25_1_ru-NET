// Flyweight
List<int> ints = [1, 2];
List<int> ints2 = [1, 2];

Console.WriteLine(ints.GetHashCode());
Console.WriteLine(ints2.GetHashCode());

string name = "Nadir";
string name2 = "Nadir";
Console.WriteLine(name.GetHashCode());
Console.WriteLine(name2.GetHashCode());

List<Unit> units = new();
FlyWeightFactory weightFactory = new();
//for (int i = 0; i < 1_000_000; i++)
//{
//    //Archer archer = new Archer();
//    //Warrior warrior = new Warrior();
//    Unit archer = weightFactory.GetUnit("Archer");
//    Unit warrior = weightFactory.GetUnit("Warrior");

//    Console.WriteLine(archer.GetHashCode());
//    Console.WriteLine(warrior.GetHashCode());
//    units.Add(archer);
//    units.Add(warrior);
//}
abstract class Unit
{
    protected string Name;
    protected int AttackPoint;
    protected int Health;
    public abstract void Display();

}
class Archer : Unit
{
    public Archer()
    {
        Name = "Archer";
        AttackPoint = 120;
        Health = 75;
    }
    public override void Display()
    {
        Console.WriteLine("Archer Created");
    }
}

class Warrior : Unit
{
    public Warrior()
    {
        Name = "Warrior";
        AttackPoint = 100;
        Health = 115;
    }
    public override void Display()
    {
        Console.WriteLine("Warrior Created");
    }
}

class FlyWeightFactory
{
    private Dictionary<string, Unit> _units = new();
    public Unit GetUnit(string key)
    {
        Unit unit = default;
        if (_units.ContainsKey(key))
        {
            unit = _units[key];
        }
        else
        {
            switch (key)
            {
                case "Archer":
                    unit = new Archer();
                    break;
                case "Warrior":
                    unit = new Warrior();
                    break;
            }
            _units.Add(key, unit);
        }
        return unit;
    }
}
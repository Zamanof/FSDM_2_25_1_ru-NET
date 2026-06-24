class Pikachu : Electric
{
    public Pikachu(string name) 
        : base(name)
    {}

    public override void Attack()
    {
        Console.WriteLine($"Pikachu -> {Name} attacked");
    }

    public override void ElectricAttack()
    {
        Console.WriteLine($"Pikachu -> {Name} electric attacked");
    }

    public  void SpecialElectricAttack()
    {
        Console.WriteLine($"Pikachu -> {Name} special electric attacked");
    }

    public override void Sound()
    {
        Console.WriteLine("Pika Pika"); ;
    }
}

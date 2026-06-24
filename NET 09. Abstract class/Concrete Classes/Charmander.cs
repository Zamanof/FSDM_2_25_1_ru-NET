class Charmander : Fire
{
    public Charmander(string name) 
        : base(name)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"Charmander -> {Name} attacked");
    }

    public override void FireAttack()
    {
        Console.WriteLine($"Charmander -> {Name} electric attacked");
    }

    public void SpecialFireAttack()
    {
        Console.WriteLine($"Charmander -> {Name} special fire attacked");
    }

    public override void Sound()
    {
        Console.WriteLine("Chaaaarmaaaandeeeer"); ;
    }
}
abstract class Pokemon
{
    protected Pokemon(string name)
    {
        Name = name;
    }

    public string Name { get; set; } = string.Empty;
    public int Level { get; set; } = 0;

    public virtual void Sound() {
        Console.WriteLine("Pokemon Sound");
    }
    public abstract void Attack();

    public void LevelUp()
    {
        Level++;
        Console.WriteLine($"{Name} level up. Level: {Level}");
    }
    
}


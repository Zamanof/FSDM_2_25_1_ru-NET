class House
{
    public string Name { get; set; }
    public int Wall { get; set; }
    public int Door { get; set; }
    public int Window { get; set; }
    public int Pool { get; set; }
    public int Garage { get; set; }
    public int Garden { get; set; }
    public bool HasRoof { get; set; }

    public override string ToString()
    {
        return $"""
            Name:       {Name}
            Wall:       {Wall}
            Door:       {Door}
            Window:     {Window}
            Pool:       {Pool}
            Garden:     {Garden}
            Garage:     {Garage}
            Has Roof:   {(HasRoof?"Has Roof":"Without Roof")}

            """;
    }

}

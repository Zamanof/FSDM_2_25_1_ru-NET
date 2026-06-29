// Standard Interfaces
class StudentCard
{
    public int Id { get; set; }
    public string Series { get; set; }

    public override string ToString()
    {
        return $"Student Card: {Series} {Id}";
    }
}
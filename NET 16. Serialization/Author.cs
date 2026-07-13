// Serialization
public class Author {
    public Author()
        :this(string.Empty, string.Empty)
    {
    }

    public Author(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }

}

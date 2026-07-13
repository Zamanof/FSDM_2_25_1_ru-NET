// Serialization
public class Book {
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Page { get; set; }
    public Author Author { get; set; }

    public Book()
    {
        Id = Guid.NewGuid();
    }

    public Book(
        string title, 
        string description, 
        double price, 
        int page, 
        Author author)
    {
        Id= Guid.NewGuid();
        Title = title;
        Description = description;
        Price = price;
        Page = page;
        Author = author;
    }

    public override string ToString()
    {
        return $"""
            Id:         {Id}
            Title:      {Title}
            Page:       {Page}
            Price:      {Price}
            Author:     {Author}

            """;
    }

}

// Serialization
using System.Text.Json;
using System.Xml.Serialization;

Author author = new Author("Joseph", "Albahari");

Book book = new Book()
{
    Author = author,
    Title = "C# 12 in a Nutshell",
    Description="Full guide for C# language",
    Page = 1065,
    Price = 53.50
};

List<Book> books = new List<Book>()
{
    new Book()
    {
        Author = new Author()
        {
            FirstName = "Jeffrey",
            LastName = "Richter",
        },
        Title = "C# via CLR",
        Description = ".NET C# guide book",
        Page = 678,
        Price = 62.35
    },

    new Book()
    {
        Author = new Author()
        {
            FirstName = "Andrew",
            LastName = "Troelsen",
        },
        Title = "Pro C# 10 with .NET 6",
        Description = "Comprehensive guide to C# and .NET",
        Page = 1450,
        Price = 79.99
    },

    book,

    new Book()
    {
        Author = new Author()
        {
            FirstName = "Mark",
            LastName = "Price",
        },
        Title = "C# 12 and .NET 8",
        Description = "Modern cross-platform development",
        Page = 850,
        Price = 59.99
    },

    new Book()
    {
        Author = new Author()
        {
            FirstName = "Jon",
            LastName = "Skeet",
        },
        Title = "C# in Depth",
        Description = "Advanced C# concepts",
        Page = 930,
        Price = 64.50
    },

    new Book()
    {
        Author = new Author()
        {
            FirstName = "Robert",
            LastName = "Martin",
        },
        Title = "Clean Code",
        Description = "Handbook of Agile Software Craftsmanship",
        Page = 464,
        Price = 49.99
    },

    new Book()
    {
        Author = new Author()
        {
            FirstName = "Martin",
            LastName = "Fowler",
        },
        Title = "Refactoring",
        Description = "Improving the Design of Existing Code",
        Page = 448,
        Price = 54.99
    },

    new Book()
    {
        Author = new Author()
        {
            FirstName = "Erich",
            LastName = "Gamma",
        },
        Title = "Design Patterns",
        Description = "Elements of Reusable Object-Oriented Software",
        Page = 395,
        Price = 58.75
    },

    new Book()
    {
        Author = new Author()
        {
            FirstName = "Ian",
            LastName = "Griffiths",
        },
        Title = "Programming C#",
        Description = "Building .NET Applications",
        Page = 720,
        Price = 57.90
    },

    new Book()
    {
        Author = new Author()
        {
            FirstName = "Adam",
            LastName = "Freeman",
        },
        Title = "ASP.NET Core in Action",
        Description = "Building modern web applications",
        Page = 1012,
        Price = 66.80
    }
};

#region XML Serialization
#region Single Object to XML
//XmlSerializer serializer = new XmlSerializer(typeof(Book));
//using var file = new FileStream("book.xml", FileMode.OpenOrCreate);
// write to XML file
//serializer.Serialize(file, book);

// read from XML file
//var result = serializer.Deserialize(file) as Book;
//Console.WriteLine(result);
#endregion

#region Collection to XML
//using var file = new FileStream("books.xml", FileMode.OpenOrCreate);
//XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
// Write List to XML
//serializer.Serialize(file, books);

// Read List from XML
//var results = serializer.Deserialize(file) as List<Book>;
//results.ForEach(Console.WriteLine);
#endregion
#endregion

#region JSON Serialization
//using var file = new FileStream("book.json", FileMode.OpenOrCreate);
JsonSerializerOptions serializerOptions = new();
serializerOptions.WriteIndented = true;
//var json = JsonSerializer.Serialize(book, serializerOptions);
//Console.WriteLine(json);
//JsonSerializer.Serialize(file, book, serializerOptions);

//var result = JsonSerializer.Deserialize<Book>(file);
//Console.WriteLine(result);


using var file = new FileStream("books.json", FileMode.OpenOrCreate);
//JsonSerializer.Serialize(file, books, serializerOptions);

var results = JsonSerializer.Deserialize<List<Book>>(file);

results.ForEach(Console.WriteLine);
#endregion
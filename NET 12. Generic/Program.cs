// C# Generic <=> C++ templates
/*
- Class
- Struct
- Method
- Interface
- Delegate
- Collections 
*/

//Some<string> some = new();
//some.Property = "Hello, World!";
//some.Foo();
//some.Bar<int, double>(42, 3.14);

Some<List<int>> some = new();

// Generic class 
class Some<T> where T : class, IEnumerable<int>, new()
{
    public T Property { get; set; }
    public void Display()
    {
        Console.WriteLine($"Value: {Property}");
    }
    public void Foo()
    {
        Console.WriteLine(Property.GetType());
    }
    // Generic method
    public T2 Bar<T2, T3>(T2 param1, T3 param2)
    {
        Console.WriteLine($"Param1: {param1.GetType()}, Param2: {param2.GetType()}");
        return param1;
    }
}

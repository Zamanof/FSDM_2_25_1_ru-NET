//GrandChild <- Derived <- Base
class GrandChild : Derived
{
    public GrandChild()
        :base("Hi", 36, 25)
    {
        //Console.WriteLine("GrandChild class default constructor");
    }

    public GrandChild(string someProperty, int field1, int field2) 
        : base(someProperty, field1, field2)
    {
        //Console.WriteLine("GrandChild class default constructor - public GrandChild(string someProperty, int field1, int field2)");
    }

    public void GrandChildBar()
    {
        Bar();
    }
}
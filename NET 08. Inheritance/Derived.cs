// inheritance -  Наследование (один их 4-х принципов ООП)

// Наследование - это расширение функционала дочерного класса,
// за счет родительского класса.

/*
      Python            C++                     C#

    Superclass        Parent class          Base class

    Subclass          Child  class         Derived class
 
*/

class Derived: Base
{
    public string SomeProperty { get; set; }

    public Derived(string someProperty)
        :this(someProperty, 0, 0)
    {
        SomeProperty = someProperty;
        //    Console.WriteLine("Derived class constructor - public Derived(string someProperty)");
    }
    public Derived()
        :this(string.Empty, 0, 0)
    {
        //Console.WriteLine("Derived class default constructor");
    }
    public Derived(string someProperty, int field1, int field2)
        :base(field1, field2)
    {
        SomeProperty = someProperty; 
        //Console.WriteLine("Derived class constructor public - Derived(string someProperty, int field1, int field2)");
    }

    public void Show()
    {
        base.Show();
        Console.WriteLine(SomeProperty);
    }
    public override string ToString()
    {
        return $"SomeProperty: {SomeProperty} {base.ToString()}";
    }
}

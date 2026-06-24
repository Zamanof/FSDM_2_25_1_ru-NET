// inheritance -  Наследование (один их 4-х принципов ООП)

// Наследование - это расширение функционала дочерного класса,
// за счет родительского класса.

/*
      Python            C++                     C#

    Superclass        Parent class          Base class

    Subclass          Child  class         Derived class
 
*/

// sealed -  "запечатанный" класс от которого невозможно наследоватся
class Base
{
    public int Field1 { get; set; }
    private int field2;

    public Base(int field1, int field2)
    {
        Field1 = field1;
        this.field2 = field2;
        //Console.WriteLine("Base class constructor with parameters");
    }
    public Base()
        : this(0, 0)
    {
        //Console.WriteLine("Base class default constructor");
    }
    public void Show()
        => Console.WriteLine($"Base show() -> Field1 = {Field1}, field2 = {field2}");

    private void Foo() { 
        Console.WriteLine("Base class Private method Foo()"); 
    }
    public void Bar() {
        Console.WriteLine("Base class Protected method Bar()");
        Foo();
    }

    public override string ToString()
    {
        return $" Field1 = {Field1}, field2 = {field2}";
    }
}

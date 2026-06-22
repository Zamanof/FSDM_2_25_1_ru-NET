// inheritance -  Наследование (один их 4-х принципов ООП)

// Наследование - это расширение функционала дочерного класса,
// за счет родительского класса.

/*
      Python            C++                     C#

    Superclass        Parent class          Base class

    Subclass          Child  class         Derived class
 
*/

//Base @base = new();
Derived derived = new("Salam", 25, 65);
//derived.Show();
Console.WriteLine(derived);
// class Derived: Base

// public Derived():this(string.Empty, 0, 0)
// public Derived(string someProperty) :this(someProperty, 0, 0)
// public Derived(string someProperty, int field1, int field2) : base(field1, field2)

// public Base() : this(0, 0) 
// public Base(int field1, int field2)
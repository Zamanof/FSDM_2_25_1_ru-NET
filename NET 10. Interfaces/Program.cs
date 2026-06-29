// Interface - do something (умение нашего класса)
// Если от классов наследуемся, interface мы реализуем (implementation)
// Интерфейс это своего рода "контракт" которую надо соблюдать (явно надо реализовать)
// Одновременно можно реализовать сколько угодно интерфейсов

// Правила связанные с интерфейсами:
//  В интерфейсах создать обычные поля невозможно, можно создавать только свойства
//  Все свойства и описание методов должны быть публичными

#region Interafce

// Interface reference
IHomoSapiens homosappiens = new Student();

//Foo(new Student());
//Foo(new AI());
//Foo(new Cat());


//Bar(new Student());
//Bar(new Cat());


SomeMethod(new Student());

void Foo(IThink think)
{
    think.Think();
}

void Bar(IWalk walk)
{
    walk.Walk();
}

void SomeMethod(IHomoSapiens homoSapiens)
{
    homoSapiens.Walk();
    homoSapiens.Think();
}

abstract class Human
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

interface IThink
{
    void Think();
}

interface IWalk
{
    void Walk();
}

interface IHomoSapiens : IThink, IWalk
{ }

class Student : Human, IHomoSapiens
{
    public float[] Mark { get; set; }
    public void Think()
    {
        Console.WriteLine("I Think like Student");
    }

    public void Walk()
    {
        Console.WriteLine("I Walk like Human");
    }
}

class AI : IThink
{
    public void Think()
    {
        Console.WriteLine("I Think like AI");
    }
}

class Cat : IWalk, IThink
{
    public void Think()
    {
        Console.WriteLine("I Think about Еда и спать");
    }

    public void Walk()
    {
        Console.WriteLine("I Walk like Cat");
    }
}

#endregion





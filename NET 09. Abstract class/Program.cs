// Abstarct classes
// отношение is - является
// (Student is Human, Car is Transport, Cat is Animal)

#region Abstarct classes introduction

//Some some = new();

//Other other = new();
//other.SomeMethod();
////other.SomeAbstarctMethod();
//abstract class Some
//{
//    public int SomeIntField;
//    public string SomeStringProperty { get; set; }
//    public virtual void SomeMethod()
//        => Console.WriteLine("Some Method");
//    public abstract void SomeAbstarctMethod();
//}

//abstract class Other : Some
//{
//    public override void SomeMethod()
//    {
//        Console.WriteLine("Other overrided SomeMethod()");
//    }
//    //public override void SomeAbstarctMethod()
//    //{
//    //    Console.WriteLine("Other overrided SomeAbstarctMethod()");
//    //}
//}

#endregion

Pikachu pikachu = new("Pika Pekson");
Charmander charmander = new("Zippo");


Pokemon[] pokemons = [pikachu, charmander, new Pikachu("Nikto")];
//Fire[] fires = [charmander, new Charmander("Charm al Cheyx")];

//foreach (Pokemon pokemon in pokemons)
//{
//    #region Downcasting - if method without virtual or abstract 
//    // Version 1 
//    //if (pokemon.GetType() == pikachu.GetType())
//    //    ((Pikachu)pokemon).Sound();
//    //if (pokemon.GetType() == charmander.GetType())
//    //    ((Charmander)pokemon).Sound();

//    // Version 2
//    //if (pokemon is Pikachu) ((Pikachu)pokemon).Sound();
//    //if (pokemon is Charmander) ((Charmander)pokemon).Sound();

//    // Version 3
//    //(pokemon as Pikachu)?.Sound();
//    //(pokemon as Charmander)?.Sound();
//    #endregion


//    pokemon.Sound();

//}

//Pikachu[] electrics = [pikachu, new Pikachu("Nikto")];
//foreach (var item in electrics)
//{
//    item.Sound();
//}

Foo(pikachu);
void Foo(Pokemon pokemon)
{
    pokemon.Sound();
}




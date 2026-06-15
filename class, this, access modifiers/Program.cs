// class
foo();
Human human = new("Nadir", "Zamanov", 45, "A+");
human.age = 46;

//Console.WriteLine($@"
//Name:       {human.name}
//Surname:    {human.surname}
//Age:        {human.age}");

//Console.WriteLine(human.Info());
Console.WriteLine(human);


Human human1 = human;

//Console.WriteLine($@"
//Name:       {human1.name}
//Surname:    {human1.surname}
//Age:        {human1.age}");

//Console.WriteLine(human1.Info());
Console.WriteLine(human1);

//Console.WriteLine(Human.PI);
//Console.WriteLine(Human.GetObjectsCount());
void foo()
{
    Human human = new("Nadir", "Zamanov", 45, "A+");
}

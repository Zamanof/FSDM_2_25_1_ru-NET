// class
foo();
Human human = new("Nadir", "Zamanov", 45);
human.age = 46;
Console.WriteLine($@"
Name:       {human.name}
Surname:    {human.surname}
Age:        {human.age}");

Human human1 = human;
Console.WriteLine($@"
Name:       {human1.name}
Surname:    {human1.surname}
Age:        {human1.age}");

void foo()
{
    Human human = new("Nadir", "Zamanov", 45);
}
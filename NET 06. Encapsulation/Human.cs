// Encapsulation
class Human
{
    public string FirstName { private get; set; }
    public string LastName { get; private set; }
    /*
    public string firstName;
    public string lastName;
   classic encapsulation 
    private int age;
    public void SetAge(int value)
    {
        if (value < 0)
            throw new Exception("Incorrect age");
        age = value;
    }

    public int GetAge() => age;
     
    */

    // properties
    //public int Age { get; set; }

    private int age;

    public int Age
    {
        get { return age; }
        set {
            if (value < 0) throw new Exception("Incorrect age");
            age = value; 
        }
    }

    //public int get_Age() => age;
    //public void set_Age(int value) => age = value; 

    // full property
    // public string GroupName{get; set;}
    private string groupName;

    public string GroupName
    {
        get { return groupName; }
        set { groupName = value; }
    }

    public Human(string firstName, string lastName, int age)
    {
        //this.firstName = firstName;
        //this.lastName = lastName;
        FirstName = firstName;
        LastName = lastName;

        if (age < 0)
        {
            throw new Exception("Incorrect age");
        }
        //this.age = age;
        Age = age;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} - {Age}: {GroupName}";
    }
}

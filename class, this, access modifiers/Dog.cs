//class Dog
//{
//    private string name;
//    private int age;
//    private float price;

//    public Dog(string name, int age, float price)
//    {
//        this.name = name;
//        this.age = age;
//        this.price = price;
//    }

//    public override string ToString()
//    {
//        return $"{name} - {age} -> {price} AZN";
//    }
//}

// primary constructor - new in C# 12
class Dog(string name, int age, float price)
{
    public override string ToString()
    {
        return $"{name} - {age} -> {price} AZN";
    }
}
// tuple - C# 7

//(int, double) myTuple = (5, 15.69);
//Console.WriteLine(myTuple.Item1);
//Console.WriteLine(myTuple.Item2);

//Console.WriteLine();

//(int summ, double price, string name) myTuple2 = (2697, 25.14, "Nadir");
//Console.WriteLine(myTuple2.name);
//Console.WriteLine(myTuple2.price);
//Console.WriteLine(myTuple2.summ);

//Console.WriteLine();
//var result = CalculateSumAndAverage(25, 33);
//Console.WriteLine($"{result.Item1} {result.Item2} {result.Item3}");

//Console.WriteLine();
//int some;
//(int sum, float average, some) = CalculateSumAndAverage(25, 33);
//Console.WriteLine($"{sum} {average} {some}");

//(int numb,_, _ ) = CalculateSumAndAverage(25, 33);
//Console.WriteLine();
//Console.WriteLine(numb);

Car car = new("2107", "Vaz", 2027);
var model = car.Model;
var manufacturer = car.Manufacturer;
var year = car.Year;

(_, string man, _) = car;
Console.WriteLine(man);

(int, float, int) CalculateSumAndAverage(int numb1, int numb2)
{
    int sum = numb1 + numb2;
    float average = sum / 2.0f;
    return (sum, average, 98742);
}

// Params

int[] arr = [25, 65, 7, 998, 45, 7, 66];
Console.WriteLine(Summ(arr));
Console.WriteLine(Summ(new int[] {36, 45, 77, 9}));
Console.WriteLine(Summ([25, 265,78]));
//Console.WriteLine(Summ(25, 265,78));
// params
Console.WriteLine("Params");
Console.WriteLine(ParamsSumm(arr));
Console.WriteLine(ParamsSumm(new int[] { 36, 45, 77, 9 }));
Console.WriteLine(ParamsSumm([25, 265, 78]));
Console.WriteLine(ParamsSumm(25, 265, 78, 48, 24, 78, 45));

//Print("Salam", 25, 65.3);
int Summ(int[] arr)
{
    int result = default;
	foreach (var item in arr)
	{
		result += item;
	}
	return result;
}

int ParamsSumm(params int[] arr)
{
    int result = default;
    foreach (var item in arr)
    {
        result += item;
    }
    return result;
}

//void Print(params object[] arr)
//{
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }
//}

int[] arr = new int[20];
Random random = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(10, 99);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();

//python -> lst[0:6] - slicing
// ranges - introducing C# 8
int[] arr2 = arr[2..9];
for (int i = 0; i < arr2.Length; i++)
{
    Console.Write($"{arr2[i]} ");
}
Console.WriteLine();

// python -> lst[-1] - negative indexes
// indecies - introducing C# 8

Console.WriteLine(arr[^1]);
// arrays
// Одномерные массивы
/*
C++ style:
// static arrays
int arr[5] = {1, 2, 3, 4, 5};

// dynamic arrays
int* arr = new int[5]{1, 2, 3, 4, 5}; 
*/

// C# arrays

//int[] arr = new int[5] { 198, 152, 31, 4584, 6545 };
//int[] arr1 = { 41, 27, 323, 544, 5 };
//int[] arr2 = [ 21, 52, 3, 44, 55 ];
//Console.WriteLine(arr[4]);
//Console.WriteLine(arr.Length);
//Console.WriteLine(arr.Rank);

// Многомерные массивы
/*
C++ style:
// static arrays
int arr[2][2] = {{1, 2}, {3, 4}};

// dynamic arrays
int** arr = new int* [2];
arr[0] = new int[2];
arr[1] = new int[2];
*/

// C# arrays
//int[,] mdArr = new int[2, 2] { { 256, 98 }, { 12, 58 } };
//Console.WriteLine(mdArr[0, 1]);
//Console.WriteLine(mdArr.Rank);
//Console.WriteLine(mdArr.Length);

// работа с циклами
//int[] arr = { 41, 27, 323, 544, 5 };
//int i = 0;
//while (i < arr.Length)
//{
//    Console.Write($"{arr[i]} ");
//    i++;
//}
//Console.WriteLine();

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write($"{arr[i]} ");
//}
//Console.WriteLine();

//foreach (var item in arr)
//{
//    Console.Write($"{item} ");
//    //item = 5;
//}
//Console.WriteLine();

// Jagged arrays
int[][] jArr = new int[3][];
jArr[0] = new int[5] { 2, 87, 4, 25, 2};
jArr[1] = new int[3] { 25, 54, 79 };
jArr[2] = new int[2] { 12, 78};

for (int i = 0; i < jArr.Length; i++)
{
	for (int j = 0; j < jArr[i].Length; j++)
	{
		Console.Write($"{jArr[i][j]} ");
	}
    Console.WriteLine();
}

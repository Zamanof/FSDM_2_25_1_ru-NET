// indexer
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/

////Console.WriteLine(garage[5]);
//Console.WriteLine(garage["Third"]);
//garage["Third"].Price = 2654;
//garage["Third"].Model = "Naz Lifan";
//Console.WriteLine(garage["Third"]);
//Console.WriteLine(garage[true]);
//Console.WriteLine(garage[false]);

class MultiArray
{
    private int[,] array;
    public int Rows { get; set; }
    public int Columns { get; set; }

    public MultiArray(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        array = new int[Rows, Columns];
    }

    public int this[int row, int column]
    {
        get => array[row, column];
        set => array[row, column] = value;
    }
}
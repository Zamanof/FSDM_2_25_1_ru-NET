// Strategy

// Dependency inversion

#region Serializer example
//WorkToFile workToFile = new(new JsonSerialize());
//workToFile.Serialize();
//workToFile.Deserialize();

//Console.WriteLine();

//workToFile.SetSerialization(new MuradSerialize());
//workToFile.Serialize();
//workToFile.Deserialize();

//interface ISerialize
//{
//    void Serialize();
//    void Deserialize();
//}

//class JsonSerialize : ISerialize // strategy
//{
//    public void Deserialize()
//        => Console.WriteLine("JSON Deserialize");

//    public void Serialize()
//        => Console.WriteLine("JSON Serialize");

//}

//class XMLSerialize : ISerialize
//{
//    public void Deserialize()
//        => Console.WriteLine("XML Deserialize");

//    public void Serialize()
//        => Console.WriteLine("XML Serialize");

//}

//class MuradSerialize : ISerialize
//{
//    public void Deserialize()
//        => Console.WriteLine("Murad style Deserialize");

//    public void Serialize()
//        => Console.WriteLine("Murad style Serialize");

//}


//class WorkToFile // context
//{
//    private ISerialize _serializer;

//    public WorkToFile(ISerialize serializer)
//    {
//        _serializer = serializer;
//    }

//    public void Serialize() => _serializer.Serialize();
//    public void Deserialize() => _serializer.Deserialize();

//    public void SetSerialization(ISerialize serializer)
//        => _serializer = serializer;

//}
#endregion

#region Sorting Example
List<int> ints = [26, 78, 98, 7, -56, 45, 3];

Sorting<int> sorting = new(new SelectionIntSorting());
var lst = sorting.Sort(ints);
// method1
lst.ForEach(i => Console.Write($"{i} "));

interface ISorting<T>
{
    List<T> Sort(List<T> values);
}

class BubbleIntSorting : ISorting<int>
{
    public List<int> Sort(List<int> values)
    {
        
        for (int i = 0; i < values.Count - 1; i++)
        {
            for (int j = 0; j < values.Count - 1 - i; j++)
            {
                if (values[j] > values[j + 1])
                {
                    int temp = values[j];
                    values[j] = values[j + 1];
                    values[j + 1] = temp;
                }
            }
        }
        return values;
    }
}

class SelectionIntSorting : ISorting<int>
{
    public List<int> Sort(List<int> values)
    {
        for (int i = 0; i < values.Count - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < values.Count; j++)
            {
                if (values[j] < values[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = values[i];
            values[i] = values[minIndex];
            values[minIndex] = temp;
        }

        return values;
    }
}

class InsertionIntSorting : ISorting<int>
{
    public List<int> Sort(List<int> values)
    {
        for (int i = 1; i < values.Count; i++)
        {
            int key = values[i];
            int j = i - 1;

            while (j >= 0 && values[j] > key)
            {
                values[j + 1] = values[j];
                j--;
            }

            values[j + 1] = key;
        }

        return values;
    }
}

class Sorting<T>
{
    private ISorting<T> _sorting;

    public Sorting(ISorting<T> sorting)
    {
        _sorting = sorting;
    }

    public List<T> Sort(List<T> collection) 
        => _sorting.Sort(collection);
}
#endregion


// indexer

// public return_type this[params]{get; set;) 

// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/


class Garage
{
    private Car[] cars;

    public Garage(int count)
    {
        cars = new Car[count];
    }

    public int Count
    {
        get => cars.Length;
    }

    // indexer -> with int parameter
    public Car this[int index]
    {
        get
        {
            if (index >= 0 && index < cars.Length)
            {
                return cars[index];
            }
            throw new IndexOutOfRangeException();
        }
        set
        {
            if (index >= 0 && index < cars.Length)
            {
                cars[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    // indexer -> with string parameter
    public Car this[string model] 
    {
        get
        {
            if(Enum.IsDefined(typeof(StringIndexs), model))
            {
                return cars[(int)Enum.Parse(typeof(StringIndexs), model)];
            }
            return new();
        }
        set
        {
            if (Enum.IsDefined(typeof(StringIndexs), model))
            {
                cars[(int)Enum.Parse(typeof(StringIndexs), model)] = value;
            }
            throw new Exception("Такой модели не существует в гараже");
        }
    }

    public Car this[bool index]
    {
        get
        {
            if (index)
            {
                return cars[1];
            }
            else
            {
                return cars[0];
            }
            
        }
        set
        {
            if (index)
            {
                cars[1] = value;
            }
            else
            {
                cars[0] = value;
            }
        }
    }
}

enum StringIndexs
{
    First,
    Second, 
    Third, 
    Fourth, 
    Fifth, 
    Sixth,
    Seventh
}
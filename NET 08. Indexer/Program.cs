// indexer
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/

//Garage garage = new Garage(7);

//garage[0] = new Car { Model = "Toyota", Price = 326412 };
//garage[1] = new Car { Model = "BMW", Price = 64584 };
//garage[2] = new Car { Model = "Tesla", Price = 48885 };
//garage[3] = new Car { Model = "Vaz", Price = 1_000_000 };
//garage[4] = new Car { Model = "Subaru", Price = 25 };
//garage[5] = new Car { Model = "Mitsubishi", Price = 1254 };
//garage[6] = new Car { Model = "Nissan", Price = 594000 };

// int[,] array = new int [3, 3]; 
MultiArray array = new(3, 3);
Random random = new();

for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 3; j++)
	{
		array[i, j] = random.Next(10, 99);
	}
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{array[i, j]} "); 
    }
    Console.WriteLine();
}
// Garbage Collector

/*
1. Stack - Раздел памяти, который используется для хранения 
           локальных переменных и вызовов функций. 
           Он работает по принципу LIFO (Last In, First Out), 
           что означает, что последняя добавленная переменная будет удалена 
           первой. Память в стеке выделяется и освобождается автоматически 
           при входе и выходе из функций или когда приложение заканчивается.

2. Heap
        - Managed Heap -  Управляемый куча, где размещаются объекты, созданные с помощью оператора new. 
          Память в управляемой куче выделяется динамически и освобождается сборщиком мусора (Garbage Collector).
             Managed Heap состоит из нескольких поколений (Generations), которые помогают оптимизировать процесс сборки мусора.   
                * Generation 0 - Содержит недавно созданные объекты.                                    
                * Generation 1
                * Generation 2
          
        - LOH (Large Object Heap) - Объекты размером больше 85000 byte создаются в этой памяти

        - Pinned Heap - Garbage Collector не может перемещать объекты которые созданы в этой памяти
                        В основном используется с unmanaged code

        - Unmanaged Heap
*/

//Console.WriteLine(GC.MaxGeneration);
GarbageHelper garbageHelper = new GarbageHelper();
//garbageHelper.MakeGarbage();
//Console.WriteLine($"Generation {GC.GetGeneration(garbageHelper)}");
//Console.WriteLine($"Memory: {GC.GetTotalMemory(false)} bytes");
//GC.Collect();
//Console.WriteLine($"Generation {GC.GetGeneration(garbageHelper)}");
//GC.Collect();
//Console.WriteLine($"Generation {GC.GetGeneration(garbageHelper)}");

var genNumber = 0;
for (int i = 0; i < 1_000_000; i++)
{
    garbageHelper.MakeGarbage();
    if(genNumber != GC.GetGeneration(garbageHelper))
    {
        Console.WriteLine($"{i} - Generation {GC.GetGeneration(garbageHelper)}");
        genNumber++;
    }
}
Console.WriteLine(GC.CollectionCount(0));
Console.WriteLine(GC.CollectionCount(1));
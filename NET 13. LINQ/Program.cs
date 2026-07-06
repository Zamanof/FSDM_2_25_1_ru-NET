// LINQ - Language Integrated Query
// Язык запросов для работы с коллекциями данных в C#.
// Позволяет писать запросы к данным в стиле SQL, но прямо в коде C#.
/*
LINQ to Objects - позволяет выполнять запросы к коллекциям объектов в памяти.
LINQ to Datasets - позволяет выполнять запросы к данным в DataSet.
LINQ to XML - позволяет выполнять запросы к данным в формате XML.
LINQ to SQL - позволяет выполнять запросы к данным в базе данных SQL Server.
LINQ to Entities - позволяет выполнять запросы к данным в Entity Framework.
PLINQ - Parallel LINQ позволяет выполнять параллельные запросы к коллекциям объектов в памяти.
*/
// LINQ запросы это декларативные запросы,
// которые описывают, что нужно получить, а не как это сделать.
List<int> numbers = [ 98, 54, -48, 4, -78, 12, 974, 100, 15, -58, 0, 8, -98];
ShowList(numbers);

#region from select
// from - определяет источник данных для запроса.
// select - определяет, какие данные будут возвращены в результате запроса.
IEnumerable<int> query = from n in numbers
                         select n;
// LINQ -запросы не выполняются сразу, а только тогда, когда к ним обращаются.
// Это называется отложенным выполнением (deferred execution).
//ShowList(query);

//numbers[0] = 45;

//ShowList(numbers);
//ShowList(query);
#endregion

#region where
// where - определяет условие фильтрации данных.
//List<int> ints = [];
//foreach (var item in numbers)
//{
//    if (item > 0 && item % 2 == 0)
//    {
//        ints.Add(item);
//    }
//}
//ShowList(ints);

//query = from n in numbers
//        where n > 0 && n % 2 == 0
//        select n;
//ShowList(query);
#endregion

#region orderby ascending(by default) / descending
// orderby - определяет порядок сортировки данных.
//query = from n in numbers
//        where n > 0
//        orderby n descending
//        select n;
//ShowList(query);
#endregion

#region group by
// group by - определяет группировку данных по определенному признаку.

//IEnumerable<IGrouping<int, int>> queryGroup = from n in numbers
//                                              where n > 0
//                                              group n by n % 2; // 0 1

//foreach (var item in queryGroup)
//{
//    Console.WriteLine(item.Key);
//    foreach (var value in item)
//    {
//        Console.WriteLine($"    {value}");
//    }

//}
#endregion

#region into
// into - позволяет продолжить запрос после группировки или проекции.

//var queryInto = from n in numbers
//                where n > 0
//                group n by n % 2 into g
//                from j in g
//                group j by j % 10;
//foreach (var item in queryInto)
//{
//    Console.WriteLine(item.Key);
//    foreach (var value in item)
//    {
//        Console.WriteLine($"    {value}");
//    }
//}
#endregion

void ShowList(IEnumerable<int> ints)
{
    foreach (var item in ints)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
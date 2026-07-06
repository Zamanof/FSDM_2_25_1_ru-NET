using System.Collections.Generic;

List<int> numbers = new();
FillList(numbers, 20);
ShowList(numbers);

#region method and delegate
//Func<int, bool> peredicate = IsEven;

//var evens = numbers.Where(peredicate).ToList();
//var evens = numbers.Where(IsEven).ToList();

//ShowList(evens);


//bool IsEven(int number)
//{
//    return number % 2 == 0;
//}
#endregion

#region Anonymous methods
/* delegate (int x) {return x % 2 == 0; }
        equals
bool IsEven(int number)
{
    return number % 2 == 0;
}
*/

//var evenNumbers = numbers.Where(delegate (int x) { return x % 2 == 0; }).ToList();
//ShowList(evenNumbers);

#endregion

#region Lambda expression
// (parameter_list) => expression_or_statement_block
// (x)=> x % 2 == 0 <=> delegate (int x) { return x % 2 == 0; }
//var evens = numbers.Where(x => x % 2 == 0).ToList();
//ShowList(evens);
#endregion

// В некоторых случаях, когда метод очень большой
// то не рекомендуется это писать как лямбда выражение,
// а лучше вынести в отдельный метод.

var fill = (List<int> lst, int count) =>
{
    Random random = new Random();
    for (int i = 0; i < count; i++)
    {
        lst.Add(random.Next(-100, 100));
    }
};


// Лямбда выражение в основном это чистые методы,
// которые не имеют побочных эффектов,
// то есть не изменяют состояние программы.
// И при одинаковых входных данных всегда возвращают одинаковый результат.
void FillList(List<int> list, int count)
{
    Random random = new Random();
    for (int i = 0; i < count; i++)
    {
        list.Add(random.Next(-100, 100));
    }
}

void ShowList(List<int> list)
{
    foreach (var item in list)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

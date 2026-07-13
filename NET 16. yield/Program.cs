// yield return, yield break

var hellos = GetResults();
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);

//while (hellos.MoveNext())
//{
//    Console.WriteLine(hellos.Current);
//}\

//foreach (var hello in GetValues())
//{
//    Console.WriteLine(hello);
//}

foreach (var item in MyRange(5, 45, 3))
{
    Console.WriteLine(item);
}
IEnumerator<string> GetResults()
{
    yield return "Salam";
    yield return "Hi";
    yield return "Hello";
    yield return "Ola";
    yield return "Salam Aleykum";
    yield return "Aloha";

}
IEnumerable< string> GetValues()
{
    List<string> values = [
        "Saqol", 
        "Bye", 
        "Goodbye", 
        "Elvida", 
        "Aloha", 
        "Salam Aleykum"];
    for (int i = 0; i < values.Count; i++)
    {
        yield return values[i].ToUpper();
    }
}
// range(3)         - 0, 1, 2
// range(3, 6)      - 3, 4, 5
// range(3, 10, 2)  - 3, 5, 7, 9
IEnumerable<int> MyRange(
    int start, 
    int? end = null, 
    int steps = 1)
{
    if (start > end && steps > 0) yield break;

    if (end is null)
    {
        end = start;
        start = 0;
    }
    for (int i = start; i < end; i+= steps) 
    {
        yield return i;
    }

}
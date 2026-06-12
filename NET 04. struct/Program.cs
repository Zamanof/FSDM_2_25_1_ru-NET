// Structs
/*
 1. struct обьекты создаются в stack
 
 2. Когда создаем конструктор с параметрами, конструктор по умолчанию не удаляеться

 3. В структурах копирование всегда глубокое копирование(deep copy) (копируются значения)

 4.  От структур невозможно наследоватся   
*/

Point point = new Point();
point.x = 75;
point.y = 668;

Console.WriteLine($"point.x = { point.x}, point.y = {point.y}");
Point point1 = point;
Console.WriteLine($"point1.x = { point1.x}, point1.y = {point1.y}");
point.x = 6;
Console.WriteLine($"point.x = { point.x}, point.y = {point.y}");
Console.WriteLine($"point1.x = { point1.x}, point1.y = {point1.y}");

Console.WriteLine(point.arr[0]);

Console.WriteLine(point1.arr[0]);
point.arr[0] = 35;

Console.WriteLine(point.arr[0]);

Console.WriteLine(point1.arr[0]);

Console.WriteLine(point.GetType());
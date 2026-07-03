// boxing - unboxing
// Boxing - Это процесс упаковки значения типа в объект.
// Когда значение типа (например, int, double, struct) присваивается переменной типа object,
// оно автоматически упаковывается в объект.
// Это позволяет использовать значение типа как
// объект и передавать его в методы, которые ожидают объект.

object obj = 42; // Boxing
Console.WriteLine($"Boxing {obj}");
Console.WriteLine(obj.GetType());

// Unboxing - Это процесс извлечения значения типа из объекта.
int unboxedValue = (int)obj; // Unboxing
Console.WriteLine($"Unboxed {unboxedValue}");

//double unboxedValue = (double)obj; // Unboxing
// System.InvalidCastException: Unable to cast object of type 'System.Int32' to type 'System.Double'.
//Console.WriteLine($"Unboxed {unboxedValue}");

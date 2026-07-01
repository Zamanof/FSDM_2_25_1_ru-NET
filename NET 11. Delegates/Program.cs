// Delegates
// delegate return_type delegate_name (parameters_list)
#region deleagte
//double numb1 = default;
//double numb2 = default;

//Console.WriteLine("Enter first value");
//double.TryParse(Console.ReadLine(), out numb1);
//Console.WriteLine("Enter second value");
//double.TryParse(Console.ReadLine(), out numb2);

//char operation = default;
//Console.WriteLine("Enter math operation: +, -, *, /");
//char.TryParse(Console.ReadLine(), out operation);
//CalculatorDelegate calculator = null!;
//switch ((ArithmeticOperators)operation)
//{
//    case ArithmeticOperators.ADD:
//        calculator = Add;
//        break;
//    case ArithmeticOperators.SUBTRACT:
//        calculator = Subtract;
//        break;
//    case ArithmeticOperators.MULTIPLE:
//        calculator = Multiple;
//        break;
//    case ArithmeticOperators.DIVIDE:
//        calculator = Divide;
//        break;
//}
//Console.WriteLine(calculator(numb1, numb2));

//Console.WriteLine(Calculator(numb1, numb2, Average));
#endregion

#region multicast delegate
//CalculatorDelegate operations = Add;
//operations += Subtract;
//operations += Multiple;
//operations += Divide;

//double number1 = 89, number2 = 3;
//Console.WriteLine(operations(number1, number2));
//Console.WriteLine(operations.Invoke(number1, number2));

//foreach (CalculatorDelegate item in operations.GetInvocationList())
//{
//    Console.WriteLine(item(number1, number2));
//}

//var delegateArray = operations.GetInvocationList();
//Console.WriteLine(delegateArray[0].Method);
//Console.WriteLine(delegateArray[1].Method);
//Console.WriteLine(delegateArray[2].Method);
//Console.WriteLine(delegateArray[3].Method);

//Console.WriteLine(delegateArray[3].DynamicInvoke(number1, number2));


#endregion

#region GenericDelegate
//GenericCalculator<double> genericCalculator = Divide;
//Console.WriteLine(genericCalculator(3, 2));
//GenericCalculator<int> genericCalculator1 = DivideInt;
//Console.WriteLine(genericCalculator1(3, 2));
#endregion

#region Filter example + anonymous delegate
//List<int> arr = [35, 65, -78, -5, 0, 25, 98, 15, 35];

//var lst = Filter(arr, delegate(int x) { return x % 2 == 0; });
//foreach (var item in lst)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();
#endregion
List<Human> humans = [
    new Human(){Name = "Nadir", Age =45},
    new Human(){Name = "Ali", Age =25},
    new Human(){Name = "Mahir", Age =17},
    new Human(){Name = "Fazil", Age = 145},
    new Human(){Name = "Krokodil", Age =54},
    ];
#region example Sort with own class


//foreach (var human in humans)
//{
//    Console.WriteLine(human);
//}

//Console.WriteLine();

////humans.Sort(NameComparison);
//humans.Sort(delegate (Human left, Human right)
//{
//    if (left.Age > right.Age) return -1;
//    else if (left.Age < right.Age) return 1;
//    else return 0;

//});
//foreach (var human in humans)
//{
//    Console.WriteLine(human);
//}

//Console.WriteLine();

#endregion

#region Standard generic delegates
#region Action<T>
// Action<T> - принимает до 16-и параметров и ничего не возвращает.
// делегат который может хранить ссылку на методы которые void
// Action<int> <=> public delegate void delegate_name(int x)
// Action<int, int> <=> public delegate void delegate_name(int x, int y)
//Random random = new();
//int[] arr = new int[20];
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = random.Next(-99, 99);
//}

//foreach (var item in arr)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//FilterShow(arr, ShowNegative);
//void ShowNegative(int value)
//{
//    if (value < 0) Console.Write($"{value} ");
//}
#endregion

#region Func<T>
// Func<T> - принимает до 16-и параметров и имеет возвращаемое значение
//  делегат который может хранить ссылку на методы которые возвращают значение
//Func<double, double, double> func = Add;
//Func<int, bool> func1 = IsNegative;
//Console.WriteLine(Calculator(25, 65, Add));
#endregion

// Predicate<T> - принимет 1 параметр и возвращает bool значение
Predicate<int> pred = IsNegative;

// Copmarison<T> - принимет 2 параметра и возвращает int значение
Comparison<Human> comparison = NameComparison;
#endregion
double Add(double a, double b)
    => a + b;

double Subtract(double left, double right)
    => left - right;

double Multiple(double first, double second)
    => first * second;

double Divide(double value1, double value2)
    => value2 != 0 ? value1 / value2 : throw new DivideByZeroException();

int DivideInt(int value1, int value2)
    => value2 != 0 ? value1 / value2 : throw new DivideByZeroException();

double Average(double numb1, double numb2)
{
    return (numb1 + numb2) / 2;
}
bool IsNegative(int value) => value < 0;

List<int> Filter(List<int> ints, FilterDelegate filterDelegate)
{
    List<int> tmp = [];
    foreach (var item in ints)
    {
        if (filterDelegate(item)) tmp.Add(item);
    }
    return tmp;

}

void FilterShow(int[] arr, Action<int> action)
{
    foreach (var item in arr)
    {
        action(item);
    }
}
int NameComparison(Human left, Human right)
    => left.Name.CompareTo(right.Name);

double Calculator(double numb1, double numb2, Func<double, double, double> f)
=> f(numb1, numb2);

public delegate double CalculatorDelegate(double left, double right);
// Generic(template) delegates
public delegate T GenericCalculator<T>(T left, T right);

public delegate bool FilterDelegate(int value);

//public delegate void Some(int value);
enum ArithmeticOperators
{
    ADD = '+',
    SUBTRACT = '-',
    MULTIPLE = '*',
    DIVIDE = '/'
}

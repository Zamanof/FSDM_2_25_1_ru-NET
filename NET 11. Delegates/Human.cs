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

class Human
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name} -> {Age}";
    }
}

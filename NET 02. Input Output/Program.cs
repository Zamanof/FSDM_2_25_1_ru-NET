// Output (console)
//Console.BackgroundColor = ConsoleColor.DarkGreen;
//Console.ForegroundColor = ConsoleColor.DarkRed;
//Console.WriteLine("Hello");
//Console.WriteLine("HI"); // snippet cw + Tab

//string name = "Nadir";
//int age = 46;
//Console.Write("HI my name is ");
//Console.Write(name);
//Console.Write(" I am ");
//Console.Write(age);
//Console.WriteLine(" years old");
//// interpolation $
//Console.WriteLine($"HI my name is {name} \nI am {age} years old");

//Console.ReadKey();

// .Clear()
//Console.Clear();

// @ - verbatim
//Console.WriteLine(@$"HI my name is {name} \n
//I am {age} years old");

//Console.Beep(2500, 500);
//Thread.Sleep(300);
//Console.Beep(2500, 500);
//Thread.Sleep(100);
//Console.Beep(2800, 100);
//Thread.Sleep(5100);
//Console.Beep(3000, 100);

// input

//var data = Console.Read();
//Console.WriteLine(data);

//var data1 = Console.ReadLine();
//Console.WriteLine(data1);

// .Parse
//var number = int.Parse(Console.ReadLine());
//Console.WriteLine(number + 3);

// .TryParse()

//int number1;
//int.TryParse(Console.ReadLine(), out number1);
//Console.WriteLine(number1);

// Convert
//var number3 = Convert.ToInt32(Console.ReadLine());

//var key = Console.ReadKey();
//Console.WriteLine(key.Key);

//while (true)
//{
//    var key = Console.ReadKey();
//    if (key.Key == ConsoleKey.Enter) break;
//    Console.WriteLine();
//    Console.WriteLine($"Key name = {key.Key}");
//}
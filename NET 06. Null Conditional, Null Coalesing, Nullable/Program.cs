#region Null Conditional operator ?.

//string name = null;
//if (name != null)
//{
//    name = name.ToLower();

//}

//if (name is not null)
//{
//    name = name.ToLower();
//}


//name = name?.ToLower();

//Console.WriteLine(name);
#endregion

#region Null Coalesing operator ??
//string name = null;
//if (name == null)
//{
//    name = "Salam";

//}

//if (name is null)
//{
//    name = "Salam";
//}

//name = name is null ? "Salam" : name;

//name = name ?? "Salam";
//Console.WriteLine(name);
#endregion

#region null forgiving operator
//string name = null!;
//Console.WriteLine(name);
#endregion

#region Nullable type
//int? number = null;
//number = 45;

//Nullable<int> number1 = null;
//number1 = 45;
#endregion
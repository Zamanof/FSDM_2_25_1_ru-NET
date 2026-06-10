// string

#region string initialize and compare
//string str1 = "Hello";
//string str2 = new string ("Hello");

//Console.WriteLine(str1 == str2);
//Console.WriteLine(str1.Equals(str2));
//Console.WriteLine(str1.CompareTo(str2));
#endregion

#region string constructors with char parameteres 
//char[] chars = ['S', 'a', 'l', 'a', 'm'];
//Console.WriteLine(chars);
//string str3 = new string(chars);
//Console.WriteLine(str3);
//string str4 = new string('_', 25);
//Console.WriteLine(str4);
#endregion

#region intern pool
//string name1 = "Nadir";
//string name2 = "Nadir";
//string name3 = name1;
//string na = "Na";
//string dir = "dir";
//string name4 = na + dir;

//Console.WriteLine($"Value compare name1, name2: {name1} == {name2} -> {name1 == name2}");
//Console.WriteLine($"Value compare name1, name3: {name1} == {name3} -> {name1 == name3}");
//Console.WriteLine($"Value compare name1, name4: {name1} == {name4} -> {name1 == name4}");
//Console.WriteLine($"RefereneceEquals name1, name3 {object.ReferenceEquals(name1, name3)}");
//Console.WriteLine($"RefereneceEquals name1, name2 {object.ReferenceEquals(name1, name2)}");
//Console.WriteLine($"RefereneceEquals name1, name4 {object.ReferenceEquals(name1, name4)}");
#endregion

#region string range, indicies
//string word = "lorem ispsum dolor sit amet";
//Console.WriteLine(word[0]);
//Console.WriteLine(word[0..5]);
//Console.WriteLine(word[^1]);

//string newWord = word[0].ToString().ToUpper() + word[1..];
//Console.WriteLine(newWord);
#endregion

#region Raw string literals -> introducing C# 11
int numb = 256;
string code = $$"""
    string word = "lorem ispsum dolor sit amet";
    Console.WriteLine(word[0]);
    Console.WriteLine(word[0..5]);
    Console.WriteLine(word[^1]);
    if (numb > 256){
        Console.WriteLine({{numb}});
    }
    string newWord = word[0].ToString().ToUpper() + word[1..];
    Console.WriteLine(newWord);
    """;
Console.WriteLine(code);
#endregion
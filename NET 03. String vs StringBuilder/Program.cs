using System.Text;

//string str = "Hi";
//for (int i = 0; i < 1000; i++)
//{
//    str += 'a';
//}

StringBuilder sb = new StringBuilder("Hi");
Console.WriteLine(sb.Capacity);
Console.WriteLine(sb.Length);
for (int i = 0; i < 1000; i++)
{
    sb.Append('a');
    Console.WriteLine(sb.Capacity);
}
string newWord = sb.ToString();

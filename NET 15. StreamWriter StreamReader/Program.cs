// StreamWriter StreamReader
using System.Text;

#region writer
//string txt = "Lorem Ipsum Dolor Sit Amet";
//FileStream fs = null;
//StreamWriter sw = null;
//try
//{
//    fs = new("MyFile.txt", FileMode.Create);
//    sw = new StreamWriter(fs, Encoding.Unicode);
//    foreach (char c in txt)
//    {
//        sw.Write($"{c} ");
//    }
//}
//finally
//{
//    sw.Close();
//    fs.Close();
//}

#endregion

#region read
//string txt = string.Empty;
//FileStream fs = null;
//StreamReader sr = null;
//try
//{
//    fs = new("MyFile.txt", FileMode.Open);
//    sr = new StreamReader(fs, Encoding.Unicode);
//    txt = sr.ReadToEnd();
//    Console.WriteLine(txt);
//}
//finally
//{
//    sr.Close();
//    fs.Close();
//}
#endregion

#region writer with using
//string txt = "Lorem Ipsum Dolor Sit Amet";
//using (FileStream fs = new("MyFile.txt", FileMode.Create))
//{
//    using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
//    {
//        foreach (char c in txt)
//        {
//            sw.Write($"{c} + ");
//        }
//    }
//}
#endregion

#region read with using
string txt = string.Empty;
using FileStream fs = new("MyFile.txt", FileMode.Open);
using StreamReader sr = new StreamReader(fs, Encoding.Unicode);
txt = sr.ReadToEnd();
Console.WriteLine(txt);

#endregion
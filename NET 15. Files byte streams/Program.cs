// FileStream, MemoryStream, BufferedStream -> Stream

/*
Absolute path:
    - C:\Users\zamanov\Documents\FSDM_2_25_1_ru-NET\NET 15. Files byte streams\bin\Debug\net9.0\file.txt
    - C:\Users\zamanov\Documents\FSDM_2_25_1_ru-NET\NET 15. Files byte streams\bin\Debug\net9.0\Files\file.txt
    - C:\Users\zamanov\Documents\FSDM_2_25_1_ru-NET\file.txt
    - C:\Users\zamanov\Documents\FSDM_2_25_1_ru-NET\Datas\file.txt

Relative path:
    - file.txt
    - Files\file.txt
    - ..\file.txt
    - ..\Datas\file.txt
*/

using System.Text;

string filePath = @"file.txt";
//Console.WriteLine("Введите текст");
//string text = Console.ReadLine();
//SaveToFile(filePath, text);
Console.WriteLine(LoadFromFile(filePath));


void SaveToFile(string path, string text)
{
    FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
    byte[] buffer = Encoding.Default.GetBytes(text);
    fileStream.Write(buffer, 0, buffer.Length);
    fileStream.Close();
}

string LoadFromFile(string path)
{
    FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
    byte[] data = new byte[fileStream.Length];
    fileStream.Read(data, 0, data.Length);
    fileStream.Close();
    return Encoding.Default.GetString(data);
}
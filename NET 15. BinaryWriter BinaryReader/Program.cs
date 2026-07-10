// BinaryWriter BinaryReader

using System.Text;

string filePath = "BinaryFile.txt";
#region writer
//string txt = "Salam";
//int number = 26;
//float value = 36.15f;

//using FileStream fs = new(filePath, FileMode.Create);
//using BinaryWriter binaryWriter = new BinaryWriter(fs, Encoding.Unicode);
//binaryWriter.Write(txt);
//binaryWriter.Write(value);
//binaryWriter.Write(number);
#endregion

#region writer
using FileStream fs = new(filePath, FileMode.Open);
using BinaryReader binaryReader = new(fs, Encoding.Unicode);
Console.WriteLine(binaryReader.ReadString());
Console.WriteLine(binaryReader.ReadSingle());
Console.WriteLine(binaryReader.ReadInt32());
#endregion

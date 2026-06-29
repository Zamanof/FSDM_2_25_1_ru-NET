// Standard Interfaces
//Console.WriteLine();
//Auditory auditory = new();
//Console.WriteLine("Students:");

// foreach работает только c обьектами которые реализуют interface IEnumerable
//foreach (var student in auditory)
//{
//    Console.WriteLine($"{student}");
//    Console.WriteLine();
//}

//auditory.Sort();
//auditory.Sort(new AgeComparer());
//Console.WriteLine();
//Console.WriteLine("Sorted Students:");
//Console.ForegroundColor = ConsoleColor.Red;
//foreach (var student in auditory)
//{
//    Console.WriteLine($"{student}");
//    Console.WriteLine();
//}
//Console.ForegroundColor = ConsoleColor.White;


Student student = new()
{
    FirstName = "Ilon",
    LastName = "Mask",
    Email = "ilonmask@spacex.com",
    BirthDate = new DateTime(1971, 6, 28),
    StudentCard = new StudentCard() { Id = 126454, Series = "IM" }
};

#region Shallow Copy
//Student student1 = student;
//student1.FirstName = "Salam";

//Console.WriteLine("First Student");
//Console.WriteLine(student);

//Console.WriteLine();

//Console.WriteLine("Second Student");
//Console.WriteLine(student1);
#endregion

#region Deep Copy
Student student2 = student.Clone() as Student;

student2.FirstName = "Salam";
student2.StudentCard.Series = "SL";

Console.WriteLine(student);
Console.WriteLine();

Console.WriteLine(student2);
Console.WriteLine();
#endregion

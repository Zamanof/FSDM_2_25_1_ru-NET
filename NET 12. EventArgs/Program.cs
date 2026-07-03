// EventArgs - это базовый класс для всех классов, которые содержат данные событий.
// Он используется в .NET для передачи информации
// о событии от источника события к обработчику события.
// Когда событие происходит, объект EventArgs может быть создан и передан в обработчик события,
// чтобы предоставить дополнительную информацию о событии.

List<Student> students = new List<Student>
{
    new Student { FirstName = "Alice", LastName="Seleznova", Age = 20, MarkAverage=10.5 },
    new Student { FirstName = "Bob", LastName="Ivanov", Age = 22, MarkAverage=8.0 },
    new Student { FirstName = "Charlie", LastName="Petrov", Age = 19, MarkAverage=9.2 },
    new Student { FirstName = "Diana", LastName="Sidorova", Age = 21, MarkAverage=7.5 },
    new Student { FirstName = "Eve", LastName="Smirnova", Age = 23, MarkAverage=6.8 },
    new Student { FirstName = "Frank", LastName="Kuznetsov", Age = 20, MarkAverage=9.0 },
    new Student { FirstName = "Grace", LastName="Popova", Age = 22, MarkAverage=8.5 },
    new Student { FirstName = "Hannah", LastName="Fedorova", Age = 19, MarkAverage=7.8 },
    new Student { FirstName = "Ivan", LastName="Morozov", Age = 21, MarkAverage=9.5 },
    new Student { FirstName = "Judy", LastName="Nikolaeva", Age = 23, MarkAverage=6.0 }
};

Teacher teacher = new Teacher();
Teacher teacher2 = new Teacher();
teacher.FirstName = "Nadir";
teacher2.FirstName = "Tamerlan";

for (int i = 0; i < students.Count; i++)
{
   if(i % 2 == 0)
    {
        teacher.ExamEvent += students[i].Exam;
    }
    else
    {
        teacher2.ExamEvent += students[i].Exam;
    }
}

ExamEventArgs examEvent = new ExamEventArgs { Task = "Solve the C#" };
teacher.Exam(examEvent);
teacher2.Exam(new ExamEventArgs { Task = "Solve the C++"});



// Events - события в C# - это механизм,
// который позволяет объектам уведомлять другие объекты
// о произошедших изменениях или событиях.
// События часто используются в графических интерфейсах пользователя (GUI),
// где действия пользователя, такие как нажатие кнопки или изменение значения,
// могут вызывать определенные реакции в программе.

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

foreach (var student in students)
{
    // event subscribe
    // Подписка на событие ExamEvent для каждого студента 
    teacher.ExamEvent += student.Exam;
}
teacher.ExamEvent -= students[0].Exam; // Unsubscribe the last student from the event

teacher.Exam("Solve the equation x^2 + 2x - 3 = 0");
delegate void ExamDelegate(string task);


// Events
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double MarkAverage { get; set; }

    public void Exam(object sender, ExamEventArgs args)
    {
        if(MarkAverage >= 8)
        {
            Console.WriteLine($"Student {FirstName} {LastName} solved {args.Task}. Exam teacher {(sender as Teacher).FirstName}");

        }
        else
        {
            Console.WriteLine($"Student {FirstName} {LastName} ne propuskayetsya na ekzamen. Exam teacher {(sender as Teacher).FirstName}");
        }
    }


}


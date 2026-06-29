// Standard Interfaces
class Student: IComparable, ICloneable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public StudentCard StudentCard { get; set; }

    public object Clone()
    {
        // deep copy
        Student tmp = this.MemberwiseClone() as Student;
        tmp.StudentCard = new StudentCard { Id = StudentCard.Id, Series = StudentCard.Series };

        //Student tmp = new Student
        //{
        //    FirstName = this.FirstName,
        //    LastName = this.LastName,
        //    BirthDate = this.BirthDate,
        //    Email = this.Email,
        //    StudentCard = new StudentCard { Id = StudentCard.Id, Series = StudentCard.Series }
        //};
        return tmp;
    }

    public int CompareTo(object? obj)
    {
        if(obj is Student)
        {
            return LastName.CompareTo((obj as Student)?.LastName);
        }
        throw new Exception("Can not compare objects");
    }

    public override string ToString()
    {
        return $"""
                    Name:           {FirstName}
                    Surname:        {LastName}
                    Birthday:       {BirthDate.ToShortDateString()}
                    Email:          {Email}
                    Student Card:   {StudentCard}
            """;
    }

}

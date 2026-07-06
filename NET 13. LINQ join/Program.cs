List<Group> groups = new List<Group>()
{
    new Group() { Id = 1, Name = "FSDM_2_25_1_ru", Faculty="Programming" },
    new Group() { Id = 2, Name = "FSDE_2_25_2_ru", Faculty="Programming" },
    new Group() { Id = 3, Name = "FSDA_2_32_3_az", Faculty="Design" },
    new Group() { Id = 4, Name = "FSDB_2_32_4_az", Faculty="Design" },
    new Group() { Id = 5, Name = "FSDE_2_25_5_ru", Faculty="CyberSecurity" },
    new Group() { Id = 6, Name = "FSDF_2_25_6_ru", Faculty="CyberSecurity" },
    new Group() { Id = 7, Name = "FSDA_2_32_7_az", Faculty="Design" },
    new Group() { Id = 8, Name = "FSDB_2_32_8_az", Faculty="Design" },
    new Group() { Id = 9, Name = "FSDE_2_25_9_ru", Faculty="CyberSecurity" },
};
List<Student> students = new List<Student>()
{
    new Student() { Id = 1, FirstName="Ali", LastName="Aliyev", Age=23, GroupId=1 },
    new Student() { Id = 2, FirstName="Veli", LastName="Mammadov", Age=21, GroupId=1 },
    new Student() { Id = 3, FirstName="Rashad", LastName="Hasanov", Age=22, GroupId=1 },
    new Student() { Id = 4, FirstName="Elvin", LastName="Quliyev", Age=24, GroupId=1 },
    new Student() { Id = 5, FirstName="Murad", LastName="Ismayilov", Age=20, GroupId=1 },
    new Student() { Id = 6, FirstName="Nijat", LastName="Karimov", Age=23, GroupId=1 },
    new Student() { Id = 7, FirstName="Kamran", LastName="Tagiyev", Age=22, GroupId=1 },

    new Student() { Id = 8, FirstName="Aysel", LastName="Aliyeva", Age=21, GroupId=2 },
    new Student() { Id = 9, FirstName="Leyla", LastName="Mammadova", Age=22, GroupId=2 },
    new Student() { Id = 10, FirstName="Nigar", LastName="Hasanova", Age=20, GroupId=2 },
    new Student() { Id = 11, FirstName="Gunel", LastName="Quliyeva", Age=23, GroupId=2 },
    new Student() { Id = 12, FirstName="Sabina", LastName="Ismayilova", Age=24, GroupId=2 },
    new Student() { Id = 13, FirstName="Konul", LastName="Karimova", Age=22, GroupId=2 },
    new Student() { Id = 14, FirstName="Sevda", LastName="Tagiyeva", Age=21, GroupId=2 },

    new Student() { Id = 15, FirstName="Orxan", LastName="Abbasov", Age=22, GroupId=3 },
    new Student() { Id = 16, FirstName="Tural", LastName="Jafarov", Age=23, GroupId=3 },
    new Student() { Id = 17, FirstName="Elnur", LastName="Suleymanov", Age=20, GroupId=3 },
    new Student() { Id = 18, FirstName="Samir", LastName="Rzayev", Age=24, GroupId=3 },
    new Student() { Id = 19, FirstName="Rauf", LastName="Mustafayev", Age=21, GroupId=3 },
    new Student() { Id = 20, FirstName="Anar", LastName="Huseynov", Age=22, GroupId=3 },
    new Student() { Id = 21, FirstName="Ilkin", LastName="Bayramov", Age=23, GroupId=3 },

    new Student() { Id = 22, FirstName="Amina", LastName="Abbasova", Age=21, GroupId=4 },
    new Student() { Id = 23, FirstName="Laman", LastName="Jafarova", Age=22, GroupId=4 },
    new Student() { Id = 24, FirstName="Narmin", LastName="Suleymanova", Age=20, GroupId=4 },
    new Student() { Id = 25, FirstName="Fidan", LastName="Rzayeva", Age=23, GroupId=4 },
    new Student() { Id = 26, FirstName="Zahra", LastName="Mustafayeva", Age=24, GroupId=4 },
    new Student() { Id = 27, FirstName="Ulker", LastName="Huseynova", Age=22, GroupId=4 },
    new Student() { Id = 28, FirstName="Aytaj", LastName="Bayramova", Age=21, GroupId=4 },

    new Student() { Id = 29, FirstName="Farid", LastName="Asadov", Age=22, GroupId=5 },
    new Student() { Id = 30, FirstName="Emil", LastName="Rahimov", Age=23, GroupId=5 },
    new Student() { Id = 31, FirstName="Nurlan", LastName="Mikayilov", Age=20, GroupId=5 },
    new Student() { Id = 32, FirstName="Javid", LastName="Aghayev", Age=24, GroupId=5 },
    new Student() { Id = 33, FirstName="Ramin", LastName="Bagirov", Age=21, GroupId=5 },
    new Student() { Id = 34, FirstName="Yusif", LastName="Salmanov", Age=22, GroupId=5 },
    new Student() { Id = 35, FirstName="Sahil", LastName="Shiriyev", Age=23, GroupId=5 },

    new Student() { Id = 36, FirstName="Aydin", LastName="Nasibov", Age=21, GroupId=6 },
    new Student() { Id = 37, FirstName="Elshan", LastName="Mahmudov", Age=22, GroupId=6 },
    new Student() { Id = 38, FirstName="Vugar", LastName="Guliyev", Age=20, GroupId=6 },
    new Student() { Id = 39, FirstName="Tofig", LastName="Sadigov", Age=23, GroupId=6 },
    new Student() { Id = 40, FirstName="Kanan", LastName="Aliyarov", Age=24, GroupId=6 },
    new Student() { Id = 41, FirstName="Ramil", LastName="Mammadli", Age=22, GroupId=6 },
    new Student() { Id = 42, FirstName="Emin", LastName="Hajiyev", Age=21, GroupId=6 },

    new Student() { Id = 43, FirstName="Shahla", LastName="Asadova", Age=22, GroupId=7 },
    new Student() { Id = 44, FirstName="Naila", LastName="Rahimova", Age=23, GroupId=7 },
    new Student() { Id = 45, FirstName="Aynur", LastName="Mikayilova", Age=20, GroupId=7 },
    new Student() { Id = 46, FirstName="Parvana", LastName="Aghayeva", Age=24, GroupId=7 },
    new Student() { Id = 47, FirstName="Chinara", LastName="Bagirova", Age=21, GroupId=7 },
    new Student() { Id = 48, FirstName="Khumar", LastName="Salmanova", Age=22, GroupId=7 },
    new Student() { Id = 49, FirstName="Afaq", LastName="Shiriyeva", Age=23, GroupId=7 },

    new Student() { Id = 50, FirstName="Ruslan", LastName="Nabiyev", Age=21, GroupId=8 },
    new Student() { Id = 51, FirstName="Teymur", LastName="Mursalov", Age=22, GroupId=8 },
    new Student() { Id = 52, FirstName="Zaur", LastName="Rustamov", Age=20, GroupId=8 },
    new Student() { Id = 53, FirstName="Fuad", LastName="Aliyev", Age=23, GroupId=8 },
    new Student() { Id = 54, FirstName="Aqil", LastName="Mammadov", Age=24, GroupId=8 },
    new Student() { Id = 55, FirstName="Shahin", LastName="Hasanov", Age=22, GroupId=8 },
    new Student() { Id = 56, FirstName="Riad", LastName="Quliyev", Age=21, GroupId=8 },

    new Student() { Id = 57, FirstName="Namiq", LastName="Orujov", Age=22, GroupId=9 },
    new Student() { Id = 58, FirstName="Eldar", LastName="Gurbanov", Age=23, GroupId=9 },
    new Student() { Id = 59, FirstName="Araz", LastName="Veliyev", Age=20, GroupId=9 },
    new Student() { Id = 60, FirstName="Mahir", LastName="Qasimov", Age=24, GroupId=9 },
    new Student() { Id = 61, FirstName="Togrul", LastName="Samedov", Age=21, GroupId=9 },
    new Student() { Id = 62, FirstName="Azer", LastName="Aliyev", Age=22, GroupId=9 },
    new Student() { Id = 63, FirstName="Rovshan", LastName="Mammadli", Age=23, GroupId=9 },
    new Student() { Id = 64, FirstName="Jalal", LastName="Huseynov", Age=20, GroupId=9 },
    new Student() { Id = 65, FirstName="Nurlan", LastName="Abdullayev", Age=24, GroupId=9 }
};

var result = from g in groups
             join s in students on g.Id equals s.GroupId
             orderby s.FirstName
             select new
             {
                 FirstName = s.FirstName,
                 LastName = s.LastName,
                 Age = s.Age,
                 GroupName = g.Name,
                 Faculty = g.Faculty
             };

//foreach (var item in result)
//{
//    Console.WriteLine($"""
//            FirstName: {item.FirstName}
//            LastName:  {item.LastName}
//            Age:       {item.Age}
//            GroupName: {item.GroupName}
//            Faculty:   {item.Faculty}

//        """);
//}

//var groupByGroup = from g in result
//                   group g by g.GroupName;

//foreach (var group in groupByGroup)
//{
//    Console.WriteLine(group.Key);
//    foreach(var student in group)
//    {
//        Console.WriteLine($"""
//                    FirstName: {student.FirstName}
//                    LastName:  {student.LastName}
//                    Age:       {student.Age}
//                    GroupName: {student.GroupName} 
//                    Faculty:   {student.Faculty}

//            """);
//    }
//}

//var groupByFaculty = from g in result
//                     group g by g.Faculty;
//foreach (var group in groupByFaculty)
//{
//    Console.WriteLine(group.Key);
//    foreach (var student in group)
//    {
//        Console.WriteLine($"""
//                    FirstName: {student.FirstName}
//                    LastName:  {student.LastName}
//                    Age:       {student.Age}
//                    GroupName: {student.GroupName} 
//                    Faculty:   {student.Faculty}

//            """);
//    }
//}

var designStudents = from s in result
                     where s.Faculty == "Design" && s.LastName.StartsWith("A")
                     select s;

foreach (var student in designStudents)
{
    Console.WriteLine($"""
                FirstName: {student.FirstName}
                LastName:  {student.LastName}
                Age:       {student.Age}
                GroupName: {student.GroupName} 
                Faculty:   {student.Faculty}

        """);
}
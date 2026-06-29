// Standard Interfaces
using System.Collections;

class Auditory: IEnumerable
{
    Student[] students =
{
    new Student
{
    FirstName = "Napoleon",
    LastName = "Bonaparte",
    Email = "napoleon.bonaparte@history.edu",
    BirthDate = new DateTime(1769, 8, 15),
    StudentCard = new StudentCard { Id = 100001, Series = "NP" }
},

new Student
{
    FirstName = "Julius",
    LastName = "Caesar",
    Email = "julius.caesar@history.edu",
    BirthDate = new DateTime(1, 7, 13),
    StudentCard = new StudentCard { Id = 100002, Series = "JC" }
},

new Student
{
    FirstName = "Alexander",
    LastName = "TheGreat",
    Email = "alexander.great@history.edu",
    BirthDate = new DateTime(1, 7, 20),
    StudentCard = new StudentCard { Id = 100003, Series = "AG" }
},

new Student
{
    FirstName = "Leonardo",
    LastName = "DaVinci",
    Email = "leonardo.davinci@history.edu",
    BirthDate = new DateTime(1452, 4, 15),
    StudentCard = new StudentCard { Id = 100004, Series = "LD" }
},

new Student
{
    FirstName = "Isaac",
    LastName = "Newton",
    Email = "isaac.newton@history.edu",
    BirthDate = new DateTime(1643, 1, 4),
    StudentCard = new StudentCard { Id = 100005, Series = "IN" }
},

new Student
{
    FirstName = "Albert",
    LastName = "Einstein",
    Email = "albert.einstein@history.edu",
    BirthDate = new DateTime(1879, 3, 14),
    StudentCard = new StudentCard { Id = 100006, Series = "AE" }
},

new Student
{
    FirstName = "Nikola",
    LastName = "Tesla",
    Email = "nikola.tesla@history.edu",
    BirthDate = new DateTime(1856, 7, 10),
    StudentCard = new StudentCard { Id = 100007, Series = "NT" }
},

new Student
{
    FirstName = "Galileo",
    LastName = "Galilei",
    Email = "galileo.galilei@history.edu",
    BirthDate = new DateTime(1564, 2, 15),
    StudentCard = new StudentCard { Id = 100008, Series = "GG" }
},

new Student
{
    FirstName = "Johann",
    LastName = "Bach",
    Email = "johann.bach@history.edu",
    BirthDate = new DateTime(1685, 3, 31),
    StudentCard = new StudentCard { Id = 100009, Series = "JB" }
},

new Student
{
    FirstName = "Wolfgang",
    LastName = "Mozart",
    Email = "wolfgang.mozart@history.edu",
    BirthDate = new DateTime(1756, 1, 27),
    StudentCard = new StudentCard { Id = 100010, Series = "WM" }
},

new Student
{
    FirstName = "Ludwig",
    LastName = "Beethoven",
    Email = "ludwig.beethoven@history.edu",
    BirthDate = new DateTime(1770, 12, 17),
    StudentCard = new StudentCard { Id = 100011, Series = "LB" }
},

new Student
{
    FirstName = "Christopher",
    LastName = "Columbus",
    Email = "christopher.columbus@history.edu",
    BirthDate = new DateTime(1451, 10, 31),
    StudentCard = new StudentCard { Id = 100012, Series = "CC" }
},

new Student
{
    FirstName = "Marco",
    LastName = "Polo",
    Email = "marco.polo@history.edu",
    BirthDate = new DateTime(1254, 9, 15),
    StudentCard = new StudentCard { Id = 100013, Series = "MP" }
},

new Student
{
    FirstName = "George",
    LastName = "Washington",
    Email = "george.washington@history.edu",
    BirthDate = new DateTime(1732, 2, 22),
    StudentCard = new StudentCard { Id = 100014, Series = "GW" }
},

new Student
{
    FirstName = "Abraham",
    LastName = "Lincoln",
    Email = "abraham.lincoln@history.edu",
    BirthDate = new DateTime(1809, 2, 12),
    StudentCard = new StudentCard { Id = 100015, Series = "AL" }
},

new Student
{
    FirstName = "Winston",
    LastName = "Churchill",
    Email = "winston.churchill@history.edu",
    BirthDate = new DateTime(1874, 11, 30),
    StudentCard = new StudentCard { Id = 100016, Series = "WC" }
},

new Student
{
    FirstName = "Mahatma",
    LastName = "Gandhi",
    Email = "mahatma.gandhi@history.edu",
    BirthDate = new DateTime(1869, 10, 2),
    StudentCard = new StudentCard { Id = 100017, Series = "MG" }
},

new Student
{
    FirstName = "Martin",
    LastName = "LutherKing",
    Email = "martin.lutherking@history.edu",
    BirthDate = new DateTime(1929, 1, 15),
    StudentCard = new StudentCard { Id = 100018, Series = "MK" }
},

new Student
{
    FirstName = "Nelson",
    LastName = "Mandela",
    Email = "nelson.mandela@history.edu",
    BirthDate = new DateTime(1918, 7, 18),
    StudentCard = new StudentCard { Id = 100019, Series = "NM" }
},

new Student
{
    FirstName = "MustafaKemal",
    LastName = "Ataturk",
    Email = "mustafakemal.ataturk@history.edu",
    BirthDate = new DateTime(1881, 5, 19),
    StudentCard = new StudentCard { Id = 100020, Series = "MA" }
},
};

    public IEnumerator GetEnumerator()
    {
        return students.GetEnumerator();
    }

    public void Sort()
    {
        Array.Sort(students);
    }

    public void Sort(IComparer comparer)
    {
        Array.Sort(students, comparer);
    }
}
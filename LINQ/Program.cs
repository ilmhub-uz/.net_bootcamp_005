using LINQ;

void ItterateAndPrint<T> (IEnumerable<T> soucre) 
{
    foreach (var item in soucre)
    {
        Console.WriteLine(item.ToString());
    }
}

var stuffs = new List<Stuff>
{
    new Teacher()
    {
        Id = 1,
        FullName = "Furqat",
        Subjects = new List<Subject>()
        {
            new Subject{ Id = 1,Name = ".NET BootCamp",Duration = new TimeOnly(3,30),Price = 200},
            new Subject{ Id = 2,Name = "Foundation of Programming",Duration = new TimeOnly(1,30),Price = 0.30M}
        },
    },
    new Teacher()
    {
        Id = 2,
        FullName = "Javlon",
        Subjects = new List<Subject>()
        {
            new Subject{ Id = 1,Name = ".NET BootCamp",Duration = new TimeOnly(3,30),Price = 200},
            new Subject{ Id = 2,Name = "Foundation of Programming",Duration = new TimeOnly(1,30),Price = 0.30M}
        },
    },
    new Admin()
    {
        Id = 3,
        FullName = "Davron"
    }
};

var subjects = new List<Subject>()
{
    new Subject{ Id = 1,Name = ".NET BootCamp",Duration = new TimeOnly(3,30),Price = 200},
    new Subject{ Id = 2,Name = "Foundation of Programming",Duration = new TimeOnly(1,30),Price = 0.30M}
};

var students = new List<Student>
{
    new Student { FullName = "Samandar", Subjects = subjects, Id = 1, TeacherId = 1 },
    new Student { FullName = "Olmos", Subjects = subjects, Id = 2, TeacherId = 1 },
    new Student { FullName = "Bexruz", Subjects = subjects, Id = 3, TeacherId = 1 },
    new Student { FullName = "Nizomjon", Subjects = subjects, Id = 4, TeacherId = 1 },
    new Student { FullName = "Numon", Subjects = subjects, Id = 5, TeacherId = 2 },
    new Student { FullName = "Abbos", Subjects = subjects, Id = 6, TeacherId = 2 },
    new Student { FullName = "SHOHJAHON", Subjects = subjects, Id = 7, TeacherId = 2 },
    new Student { FullName = "Omadbek", Subjects = subjects, Id = 8, TeacherId = 2 },
    new Student { FullName = "Omadbek", Subjects = subjects, Id = 9, TeacherId = 2 }
};



//var myStudents = teacher.Students.Where(s => s.TeacherId == teacher.Id);
// var myStudents = teacher.Students.TakeLast(3); Oxiridan  sanab qaytaradi
//var myStudents = teacher.Students.Take(3); berilgan songa qarab boshidan oladi
//var myStudents = students.Skip(1).Take(10);

//var distinctStudents = students.DistinctBy(x=>(x.TeacherId ,x.FullName));
//var teacher = stuffs.OfType<Admin>();
//var numbers = new List<int> { 12, 23, 45, 67, 0, 899 };
//ItterateAndPrint<Student>(distinctStudents);
//ItterateAndPrint<Stuff>(teacher);
//ItterateAndPrint<int>(numbers);

// var newSubjects = students
//     .SelectMany(n => n.Subjects.
//         Select(s => new { SubjectName = s.Name , SubjectCost = s.Price}));
//
// var subjectDuplicate = from student in students
//     where student.TeacherId == 1
//     select student.Subjects;
//
// ItterateAndPrint<Subject>(subjectDuplicate.SelectMany(s=>s));

    
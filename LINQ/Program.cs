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
    new Student { FullName = "Omadbek", Subjects = subjects, Id = 9, TeacherId = 2 },
    new Student { FullName = "Omadbek", Subjects = subjects, Id = 9, TeacherId = 2 }
};

var secondList = new List<Student>
{
    new Student { FullName = "Kamol", Subjects = subjects, Id = 12, TeacherId = 1 },
    new Student { FullName = "Behruz", Subjects = subjects, Id = 23, TeacherId = 1 },
    new Student { FullName = "Bobur", Subjects = subjects, Id = 31, TeacherId = 1 },
    new Student { FullName = "Furqat", Subjects = subjects, Id = 4, TeacherId = 1 },
    new Student { FullName = "Numon", Subjects = subjects, Id = 5, TeacherId = 2 },
    new Student { FullName = "Abbos", Subjects = subjects, Id = 6, TeacherId = 2 },
    new Student { FullName = "SHOHJAHON", Subjects = subjects, Id = 7, TeacherId = 2 },
    new Student { FullName = "Omadbek", Subjects = subjects, Id = 9, TeacherId = 2 },
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

// var numbers = new[] { 1, 2, 3 };
// // 6
// var sum = numbers.Aggregate(2, (c, n) => c * 120 / n);
// Console.WriteLine(sum);
// // 6
// var sumLinq = numbers.Sum();
// Console.WriteLine(sumLinq);

// var latestStudent = students.MaxBy(s=>s.Id);
// Console.WriteLine(latestStudent);

// var result = students.Any(s => s.FullName == "Numon");
// Console.WriteLine(emptyList.Any());
// Console.WriteLine(result);

// var tengmi = students.SequenceEqual(emptyList);
// Console.WriteLine(tengmi);

// var numbers = new[] { 1, 2, 3, 4 };
// var moreNumbers = new[] { 1, 2, 3, 4 };
//
// var equal = numbers.SequenceEqual(moreNumbers);
// Console.WriteLine(equal);

// var mystudents = students.Join(stuffs,
//     s=> s.TeacherId, t=>t.Id,
//     (student,teacher) => new
//     {
//         StudentFullname = student.FullName,
//         TeacherFullname = teacher.FullName,
//         TeacherId = teacher.Id,
//         Subject = student.Subjects
//             .Where(subject => subject.Name == ".NET BootCamp")
//     });
//
// foreach (var student in mystudents)
// {
//     foreach (var subject in student.Subject)
//     {
//         Console.WriteLine($"{student.StudentFullname}  {student.TeacherFullname}  {student.TeacherId}" +
//                           $"{subject}");
//     }
// }

/*var zipped = students.Zip(new int[] {}, (y, x) => (x, y)).ToList();

foreach (var item in zipped)
{
    Console.WriteLine($"{item.x} {item.Item2}");
}*/

//First
/*
var result = students.First(x => x.FullName == "Omadbek");
Console.WriteLine(result);
*/


/*var result = students.First(x => x.FullName == "Temurmalik");
Console.WriteLine(result);*/

/*
var result = students.FirstOrDefault(x => x.FullName == "Temurmalik");
Console.WriteLine(result);
*/

// var sortedSubjects = students.ToLookup(s => s.FullName, st => st.Subjects);
//
// foreach (var group in sortedSubjects)
// {
//     var key = group.Key;
//     var subj = group.ToList();
//
//     Console.WriteLine($"Key: {key}");
//
//     foreach (var subject in subjects)
//     {
//         // Access properties or perform operations on each subject
//         Console.WriteLine($"Subject: {subject.ToString()}");
//     }
// }

// var dict = subjects.ToDictionary(s=>s.Id);
//
// foreach (KeyValuePair<int, Subject> kvp in dict)
// {
//     int key = kvp.Key;
//     Subject subject = kvp.Value;
//
//     // Access properties or perform operations on each subject
//     Console.WriteLine($"Key: {key}, Subject: {subject.ToString()}");
// }

// var numbers1 = new[] { 1, 1, 2 };
// var numbers2 = new[] { 2, 3, 4 };
//
// var unique = numbers1.Union(numbers2);
// ItterateAndPrint(unique);

// var united = secondList.Union(students);
// ItterateAndPrint(united);




    
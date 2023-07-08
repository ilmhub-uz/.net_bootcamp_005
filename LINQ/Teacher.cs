using System.Text;

namespace LINQ
{
    public class Stuff
    {
        public  int Id { get; set; }
        public required string FullName { get; set; }

        public override string ToString()
            => $"ID : {Id} FullName : {FullName}";
    }

    public class Admin : Stuff
    {
        
    }
    
    public class Teacher : Stuff
    {
        public List<Subject> Subjects { get; set; }

        public override string ToString() => $"ID: {Id} FullName : {FullName} Subjects : \n {PrintSubjects(Subjects)}";
        
        private  string PrintSubjects(List<Subject> subjects)
        {
            var result = new StringBuilder();
            foreach (var subject in subjects)
            {
                result.AppendLine(subject.ToString());
            }

            return result.ToString();
        }

    }

    public class Student
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public required string FullName { get; set; }
        
        public List<Subject> Subjects { get; set; }
        
        public override string ToString() => $"Id : {Id} TeacherId : {TeacherId} " +
                                             $" FullName : {FullName} Subjects : \n {PrintSubjects(Subjects)}";

        private  string PrintSubjects(List<Subject> subjects)
        {
            var result = new StringBuilder();
            foreach (var subject in subjects)
            {
                result.AppendLine(subject.ToString());
            }

            return result.ToString();
        }
    }
    
    public class Subject
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public TimeOnly Duration { get; set; }
        public decimal  Price { get; set; }

        public override string ToString()
            => $" ID : {Id} Name : {Name} Duration : {Duration}  Price {Price}";
    }
}   
using Lab4.Data;
using Lab4.Models;

namespace Lab4.Helper.Seeders
{
    public class StudentSeeder
    {
        public readonly Lab4Context _lab4Context;
        public StudentSeeder(Lab4Context lab4Context)
        {
            _lab4Context = lab4Context;
        }
        public void SeedInitialStudents()
        {
            if(!_lab4Context.Students.Any())
            {
                var student1 = new Student
                {
                    Name = "Student1",
                    Age = 21,
                    IsDeleted = false
                };
                var student2 = new Student
                {
                    Name = "Student2",
                    Age = 22,
                    IsDeleted = false
                };
                _lab4Context.Add(student1);
                _lab4Context.Add(student2);
            }
        }
    }
}

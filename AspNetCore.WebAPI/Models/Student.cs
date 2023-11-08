using Microsoft.EntityFrameworkCore;

namespace AspNetCore.WebAPI.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
            if(Database.EnsureCreated())
            {
                Students.Add(new Student { Name = "Иван", Surname = "Иваненко", Age = 20, GPA = 10.5f });
                Students.Add(new Student { Name = "Сергей", Surname = "Алексеенко", Age = 23, GPA = 11.5f });
                Students.Add(new Student { Name = "Петр", Surname = "Петренко", Age = 25, GPA = 12f });
                SaveChanges();
            }
        }
    }
    public class Student
    {
        // Идентификатор студента
        public int Id { get; set; }
        // Имя студента
        public string? Name { get; set; }
        // Фамилия студента
        public string? Surname { get; set; }
        // Возраст студента
        public int Age { get; set; }
        // Средний балл
        public double GPA { get; set; }
    }
}

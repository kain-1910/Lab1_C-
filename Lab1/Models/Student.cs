using System.Reflection;

namespace Lab1.Models
{
    public class Student
    {
        public Student() { }
        public Student(int id, string? name, string? email, string? password, Branch? branch, Gender? gender, string? address, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Branch = branch;
            Gender = gender;
            Address = address;
            DateOfBirth = dateOfBirth;
        }

        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? Email { get; set; } 
        public string? Password { get; set; }
        public Branch? Branch { get; set; }
        public Gender? Gender { get; set; }
        public string? Address { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage ="Vui lòng nhập trường này")]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [StringLength(maximumLength:100, MinimumLength = 4, ErrorMessage ="Tên phải tối thiểu 4 kí tự")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@gmail\.com$", ErrorMessage ="Vui lòng nhập chính xác dữ liệu, email cần có gmail.com")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [StringLength(maximumLength:20, MinimumLength = 8, ErrorMessage ="Mật khẩu phải tối thiểu 8 kí tự")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).+$", ErrorMessage ="Mật khẩu phải gồm số, chữ, chữ hoa và kí tự đặc biệt")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        public Branch? Branch { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        public Gender? Gender { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        public string? Address { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập trường này")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Dữ liệu phải là số")]
        [Range(0.0, 10.0, ErrorMessage ="Vui lòng nhập số lớn hơn 0 , nhỏ hơn 10")]
        public string? Point { get; set; }
    }
}

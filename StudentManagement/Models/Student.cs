namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string ? Name { get; set; }
        public int Age { get; set; } = 0;
        public string Course { get; set; } = string.Empty;

    }
}

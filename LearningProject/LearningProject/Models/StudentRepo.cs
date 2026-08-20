namespace LearningProject.Models
{
    public static class StudentRepo
    {
        public static List<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student {Id=1, Name="ahmed" ,ImageUrl="image1.jpg"},
                new Student {Id=2, Name="aly" ,ImageUrl="image2.jpg"},
                new Student {Id=3, Name="asma" ,ImageUrl="image3.jpg"}
            };
        }
    }
}

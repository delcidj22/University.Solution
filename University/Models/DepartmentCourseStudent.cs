namespace University.Models
{
  public class DepartmentCourseStudent
    {       
        public int DepartmentCourseStudentId { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int? CourseId { get; set; }
        public Course Course { get; set; }
        public int? StudentId { get; set; }
        public Student Student { get; set; }
    }
}
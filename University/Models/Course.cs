using System.Collections.Generic;

namespace University.Models
{
  public class Course
  {
    public Course()
    {
      this.DepartmentCourseStudentEntity = new HashSet<DepartmentCourseStudent>();
    }

    public int CourseId { get; set; }
    public string Name { get; set; }

    // public boolean IsComplete {get; set;}
    public virtual ICollection<DepartmentCourseStudent> DepartmentCourseStudentEntity { get; set; }
  }
}
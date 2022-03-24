using System.Collections.Generic;

namespace University.Models
{
  public class Student
  {
    public Student()
    {
      this.DepartmentCourseStudentEntity = new HashSet<DepartmentCourseStudent>();
    }

    public int StudentId { get; set; }
    public string Name { get; set; }
    public string DateOfAdmit {get; set;}

    public virtual ICollection<DepartmentCourseStudent> DepartmentCourseStudentEntity { get;}
  }
}

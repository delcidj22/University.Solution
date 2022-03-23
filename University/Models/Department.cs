using System.Collections.Generic;

namespace University.Models
{
  public class Department
  {
    public Department()
    {
      this.DepartmentCourseStudentEntity = new HashSet<DepartmentCourseStudent>();
    }

    public int DepartmentId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<DepartmentCourseStudent> DepartmentCourseStudentEntity { get;}
  }
}
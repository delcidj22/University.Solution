using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using System.Collections.Generic;
using System.Linq;

namespace University.Controllers
{
  public class CoursesController : Controller
  {
    private readonly UniversityContext _db;

    public CoursesController(UniversityContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Course> model = _db.Courses.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Course course)
    {
      _db.Courses.Add(course);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Course thisCourse = _db.Courses
          .Include(course => course.DepartmentCourseStudentEntity)
          .ThenInclude(join => join.Student)
          .FirstOrDefault(course => course.CourseId == id);
      return View(thisCourse);
    }

    public ActionResult Edit(int id)
    {
      Course thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
      return View(thisCourse);
    }

    [HttpPost]
    public ActionResult Edit(Course course)
    {
      _db.Entry(course).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Course thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
      return View(thisCourse);
    }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   Course thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id); 
    //   List<DepartmentCourseStudent> joins = _db.DepartmentCourseStudents.Where(join => join.Course == id).ToList();
    //   foreach (DepartmentCourseStudent join in joins)
    //   {
    //     _db.DepartmentCourseStudents.Remove(join);
    //   }
    //   _db.Courses.Remove(thisCourse);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");

    // }
  }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using OpalCollege.Models;
using System.Collections.Generic;
using System.Linq;

namespace OpalCollege.Controllers
{
  public class StudentsController : Controller
  {
    private readonly OpalCollegeContext _db;

    public StudentsController(OpalCollegeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Student> model = _db.Students.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Title");
      return View();
    }

    public ActionResult AddCourse (int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Title");
      return View(thisStudent);
    }

    [HttpPost]
    public ActionResult AddCourse (Student student, int courseId)
    {
#nullable enable
      StudentCourse? joinEntity = _db.StudentCourses.FirstOrDefault(join => (join.CourseId == courseId && join.StudentId == student.StudentId));
#nullable disable
      if (joinEntity == null && courseId != 0)
      {
        _db.StudentCourses.Add(new StudentCourse() { CourseId = courseId, StudentId = student.StudentId});
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = student.StudentId });
    }
    
    [HttpPost]
    public ActionResult Create(Student student)
    {
      _db.Students.Add(student);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Student foundStudent = _db.Students
                                .Include(student => student.JoinEntities)
                                .ThenInclude(join => join.Course)
                                .FirstOrDefault(student => student.StudentId == id);
      return View(foundStudent);
    }

    public ActionResult Edit(int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Title");
      return View(thisStudent);
    }

    [HttpPost]
    public ActionResult Edit(Student student)
    {
      _db.Students.Update(student);
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = student.StudentId});
    }

        public ActionResult Delete(int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
      return View(thisStudent);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
      _db.Students.Remove(thisStudent);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteJoin(int joinId)
    {
      StudentCourse joinEntry = _db.StudentCourses.FirstOrDefault(entry => entry.StudentCourseId == joinId);
      _db.StudentCourses.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
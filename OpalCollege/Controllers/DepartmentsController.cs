using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using OpalCollege.Models;
using System.Collections.Generic;
using System.Linq;

namespace OpalCollege.Controllers
{
  public class DepartmentsController : Controller
  {
    private readonly OpalCollegeContext _db;

    public DepartmentsController(OpalCollegeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Departments.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Department department)
    {
      _db.Departments.Add(department);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      ViewBag.thisDeptsStudents = _db.Students.Where(student => student.DepartmentId == id).ToList();
      ViewBag.thisDeptsCourses = _db.Courses.Where(course => course.DepartmentId == id).ToList();
      Department thisDept = _db.Departments.FirstOrDefault(dept => dept.DepartmentId == id);
      return View(thisDept);
    }
    public ActionResult Edit (int id)
    {
      Department thisDept = _db.Departments.FirstOrDefault(dept => dept.DepartmentId == id);
      return View(thisDept);
    }
    [HttpPost]
    public ActionResult Edit (Department department)
    {
      _db.Departments.Update(department);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete (int id)
    {
      Department thisDept = _db.Departments.FirstOrDefault(dept => dept.DepartmentId == id);
      return View(thisDept);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed (int id)
    {
      Department thisDept = _db.Departments.FirstOrDefault(dept => dept.DepartmentId == id);
      _db.Remove(thisDept);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}

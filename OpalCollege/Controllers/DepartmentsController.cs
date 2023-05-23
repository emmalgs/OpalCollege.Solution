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
      Department thisDept = _db.Departments
                                .Include(department => department.JoinCourses)
                                .ThenInclude(join => join.Course)
                                .FirstOrDefault(dept => dept.DepartmentId == id);
      return View(thisDept);
    }
  }
}

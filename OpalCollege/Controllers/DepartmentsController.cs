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
  }
}

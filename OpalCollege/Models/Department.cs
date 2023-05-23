using System;
using System.Collections.Generic;

namespace OpalCollege.Models
{
  public class Department
  {
    public int DepartmentId { get; set; }
    public string Subject { get; set; }
    public List<Student> Students { get; set; }
    public List<Course> Courses { get; set; }
  }
}
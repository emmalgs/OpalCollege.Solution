using System;
using System.Collections.Generic;

namespace OpalCollege.Models
{
  public class Department
  {
    // public int CourseId { get; set; }
    // public string Title { get; set; }
    // public string Subject { get; set; }
    // public int Level { get; set; }
    // public string Professor { get; set; }

    public int DepartmentId { get; set; }
    public string Subject { get; set; }
    public List<Student> Students { get; set; }
    // public List<Professor> Professors { get; set; }
    public List<Course> Courses { get; set; }
    public List<DepartmentCourse> JoinEntities { get; }    
  }
}
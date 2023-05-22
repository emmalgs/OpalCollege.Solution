using System;
using System.Collections.Generic;

namespace OpalCollege.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    public string Title { get; set; }
    public string Subject { get; set; }
    public int Level { get; set; }
    public string Professor { get; set; }
    public List<StudentCourse> JoinEntities { get; }    
  }
}
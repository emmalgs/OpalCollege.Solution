using System;
using System.Collections.Generic;

namespace OpalCollege.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime EnrollDate { get; set; }
        public List<StudentCourse> JoinEntities { get; }
    }
}
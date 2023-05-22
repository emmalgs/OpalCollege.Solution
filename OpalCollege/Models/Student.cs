using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpalCollege.Models
{
    public class Student
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime EnrollDate { get; set; }
        public List<StudentCourse> JoinEntities { get; }
    }
}
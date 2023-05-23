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
        [Required(ErrorMessage ="Please add a name!!!!! YOU MUST!!!!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please select a date of enrollment, you coocoo caca insana")]
        [DataType(DataType.DateTime, ErrorMessage = "PLEASE ENTER A DATE, PLEASE!!!!")]
        [Range(typeof(DateTime), "2022-01-01", "2024-12-31", ErrorMessage = "ARe you insande thats snot ebven real")]
        public DateTime? EnrollDate { get; set; }
        public List<StudentCourse> JoinEntities { get; }
    }
}
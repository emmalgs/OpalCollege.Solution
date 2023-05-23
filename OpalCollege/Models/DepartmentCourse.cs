namespace OpalCollege.Models
{
  public class DepartmentCourse
  {
    public int DepartmentCourseId { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
  }
}
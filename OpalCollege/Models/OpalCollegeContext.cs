using Microsoft.EntityFrameworkCore;

namespace OpalCollege.Models
{
  public class OpalCollegeContext : DbContext
  {
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<DepartmentCourse> DepartmentCourses { get; set; }
    public OpalCollegeContext(DbContextOptions options) : base(options) { }
  }
}
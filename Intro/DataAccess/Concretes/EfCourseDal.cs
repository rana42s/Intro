using Intro.DataAccess.Abstracts;
using Intro.Entities;

namespace Intro.DataAccess.Concretes;

public class EfCourseDal:ICourseDal
{
    List<Course> courses;
    public EfCourseDal()
    {
        Course course1 = new Course();
        course1 = new Course();
        course1.Name = "JavaScript";
        course1.Id = 1;
        course1.Description = "JS 4.21...";
        course1.Price = 10;

        Course course2 = new Course();
        course2 = new Course();
        course2.Name = "C#";
        course2.Id = 2;
        course2.Description = ".NET 8...";
        course2.Price = 20;

        Course course3 = new Course();
        course3 = new Course();
        course3.Name = "Java";
        course3.Id = 3;
        course3.Description = "Java 17...";
        course3.Price = 30;

        courses = new List<Course> { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {
        //burada db işlemleri yapılır
        //sql
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}

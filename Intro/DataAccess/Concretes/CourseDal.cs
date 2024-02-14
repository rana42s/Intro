using Intro.DataAccess.Abstracts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes;

public class CourseDal:ICourseDal //dal:data access layer. repository veya dal görürsek: veritabanı ile çalışan bir yer
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course();
        course1 = new Course();
        course1.Name = "Python";
        course1.Id = 1;
        course1.Description = "Python 3.12...";
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

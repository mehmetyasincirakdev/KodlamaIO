using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> _courses;
    public CourseDal()
    {
        _courses = new List<Course> {
        new Course { CourseId = 1, CourseName = "C#", Description = "Yazılım geliştirme" },
        new Course { CourseId = 2, CourseName = "Python", Description = "Veri bilimi ve yapay zeka" },
        new Course { CourseId = 3, CourseName = "JavaScript", Description = "Web geliştirme" },
        new Course { CourseId = 4, CourseName = "Java", Description = "Android uygulama geliştirme" },
    };
    }
    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Delete(Course course)
    {
        _courses.Remove(course);
    }

    public void DeleteById(int id)
    {
        _courses.Remove(_courses.SingleOrDefault(x => x.CourseId == id));
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public void Update(Course course)
    {
        Course updatedCourse=new Course();
        updatedCourse.CourseId = course.CourseId;
        updatedCourse.CourseName = course.CourseName;
        updatedCourse.Description = course.Description;
    }
}

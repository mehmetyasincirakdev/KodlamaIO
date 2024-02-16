using Business.Concretes;
using DataAccess.Concretes;

CourseManager courseManager = new CourseManager(new CourseDal());
foreach (var course in courseManager.GetAll())
{
    Console.WriteLine(course.CourseName);
}
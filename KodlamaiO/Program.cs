using Business.Concretes;
using DataAccess.Concretes;

CourseManager courseManager = new CourseManager(new CourseDal());
foreach (var course in courseManager.GetAll())
{
    Console.WriteLine(course.CourseName);
}

Console.WriteLine("\n---------------------------------------------------\n");
CategoryManager categoryManager = new CategoryManager(new CategoryDal());
foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine(category.CategoryName);
}
Console.WriteLine("\n---------------------------------------------------\n");
InstructorManager instructorManager=new InstructorManager(new InstructorDal());
foreach (var instructor in instructorManager.GetAll())
{
    Console.WriteLine($"{instructor.InstructorFirstName}   {instructor.InstructorLastName}");
}
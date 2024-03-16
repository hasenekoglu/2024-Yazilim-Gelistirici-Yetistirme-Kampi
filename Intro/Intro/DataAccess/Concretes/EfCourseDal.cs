using Intro.DataAccess.Abstracts;
using Intro.Entities;

public class EfCourseDal : ICourseDal
{
    List<Course> courses;

    public EfCourseDal()
    {
        Course course1 = new Course();
        Course course2 = new Course();
        Course course3 = new Course();

        course1.Id = 1;
        course2.Id = 2;
        course3.Id = 3;

        course1.Name = "C#";
        course2.Name = "JavaScript";
        course3.Name = "Python";

        course1.Description = ".NET 8 vs...";
        course2.Description = "Java 17...";
        course3.Description = "Python 3.12 ...";

        course1.Price = 10;
        course2.Price = 20;
        course3.Price = 30;

        courses = new List<Course> { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {
        //burada db işlemleri yapılır
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}



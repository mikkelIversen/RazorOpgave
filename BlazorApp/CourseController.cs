using Microsoft.AspNetCore.Mvc;

namespace BlazorApp;

public class CourseController : Controller
{
    public static List<Course> courses = new List<Course>();
    
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Details()
    {
        return View();
    }

    public static void PopulateCourses()
    {
        courses.Add(
            new Course()
            {
                Id = 1,
                DurationInWeeks = 12,
                Teacher = "test",
                Title = "tets"
            }
        );
        courses.Add(
            new Course()
            {
                Id = 1,
                DurationInWeeks = 12,
                Teacher = "test",
                Title = "tets"
            }
        );
        courses.Add(
            new Course()
            {
                Id = 1,
                DurationInWeeks = 12,
                Teacher = "test",
                Title = "tets"
            }
        );
        courses.Add(
            new Course()
            {
                Id = 1,
                DurationInWeeks = 12,
                Teacher = "test",
                Title = "tets"
            }
        );
        courses.Add(
            new Course()
            {
                Id = 1,
                DurationInWeeks = 12,
                Teacher = "test",
                Title = "tets"
            }
        );
    }
}
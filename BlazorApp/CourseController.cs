using Microsoft.AspNetCore.Mvc;

namespace BlazorApp;

public class CourseController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Details()
    {
        return View();
    }
}
using Courses.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Courses.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService courseService;

        [HttpGet]
        public IActionResult Get() {
            var courses = courseService.GetCourses();
            return Ok(courses);
        }

        


    }
}

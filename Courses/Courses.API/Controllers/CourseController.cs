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
        public async Task<IActionResult> Get() {
            var courses = await courseService.GetCourcesAsync();
            return Ok(courses);
        }

        


    }
}

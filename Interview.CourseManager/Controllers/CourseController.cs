using Interview.CourseManager.Models;
using Interview.CourseManager.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Interview.CourseManager.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpPost("Reservation")]
        public IActionResult Reservation(CourseReservationModel courseReservationModel)
        {
           var reservation= _courseService.addReservation(courseReservationModel);
            return Ok(reservation);
        }
    }
}

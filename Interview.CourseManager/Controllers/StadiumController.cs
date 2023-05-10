using Interview.CourseManager.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Interview.CourseManager.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StadiumController : Controller
    {
        private readonly IStadiumService _stadiumService;

        public StadiumController(IStadiumService stadiumService)
        {
            _stadiumService = stadiumService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var Stadiums = _stadiumService.GetAll();
            return Ok(Stadiums);
        }
    }
}

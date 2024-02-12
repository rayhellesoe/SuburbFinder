using Microsoft.AspNetCore.Mvc;
using SuburbFinder.Server.Models;

namespace SuburbFinder.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class SuburbFinderController : ControllerBase
    {
        [HttpGet("{Id:int}")]
        public Suburb Get(int Id)
        {
            Suburb suburb = new Suburb { Id = 1, Name = "Arch Hill", Latitude = -36.8659669, Longitude = 174.7148012 };
            return suburb;
        }
    }
}

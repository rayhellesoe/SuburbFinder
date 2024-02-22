using Microsoft.AspNetCore.Mvc;
using SuburbFinder.Server.Models;
using SuburbFinder.Server.Services;

namespace SuburbFinder.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class SuburbsController : ControllerBase
    {
        private readonly SuburbService _suburbService;

        public SuburbsController(SuburbService suburbService)
        {
            _suburbService = suburbService;
        }

        [HttpGet("nearest")]
        public ActionResult<Suburb> NearestSuburb([FromQuery] Coordinates inputCoordinates)
        {
            /* Check coordinate range is valid */
            if (inputCoordinates.Longitude < -180 || inputCoordinates.Longitude > 180 || inputCoordinates.Latitude < -90 || inputCoordinates.Latitude > 90)
                return BadRequest("Invalid range. Longitude must be between -180 to 180 degrees. Latitude must be between -90 to 90 degrees.");

            Suburb nearestSuburb = _suburbService.GetNearestSuburb(inputCoordinates);

            return nearestSuburb;
        }
    }
}

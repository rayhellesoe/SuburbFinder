using Microsoft.AspNetCore.Mvc;
using SuburbFinder.Server.Models;

namespace SuburbFinder.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class SuburbFinderController : ControllerBase
    {
        private static readonly IEnumerable<Suburb> Suburbs = new[]
        {
                new Suburb{ Id = 1, Name = "Arch Hill", Latitude = -36.8659669, Longitude = 174.7148012 },
                new Suburb{ Id = 2, Name = "Auckland CBD", Latitude = -36.859454, Longitude = 174.5660387 },
                new Suburb{ Id = 3, Name = "Avondale", Latitude = -36.8852381, Longitude = 174.6649163 },
                new Suburb{ Id = 4, Name = "Balmoral", Latitude = -36.8976578, Longitude = 174.7250972 },
                new Suburb{ Id = 5, Name = "Birkenhead", Latitude = -36.8120427, Longitude = 174.7260381 },
                new Suburb{ Id = 6, Name = "Blockhouse Bay", Latitude = -36.9262628, Longitude = 174.7000563 },
                new Suburb{ Id = 7, Name = "Botany Downs", Latitude = -36.9228705, Longitude = 174.9154983 },
                new Suburb{ Id = 8, Name = "Ellerslie", Latitude = -36.8922751, Longitude = 174.8077355 },
                new Suburb{ Id = 9, Name = "Epsom", Latitude = -36.8904851, Longitude = 174.7721629 },
                new Suburb{ Id = 10, Name = "Freemans Bay", Latitude = -36.8473856, Longitude = 174.7484948 },
                new Suburb{ Id = 11, Name = "Glen Eden", Latitude = -36.9073821, Longitude = 174.6540207 },
                new Suburb{ Id = 12, Name = "Glendowie", Latitude = -36.8562427, Longitude = 174.8603797 },
                new Suburb{ Id = 13, Name = "Glen Innes", Latitude = -36.8746129, Longitude = 174.867097 },
                new Suburb{ Id = 14, Name = "Greenlane", Latitude = -36.9056422, Longitude = 174.7936316 },
                new Suburb{ Id = 15, Name = "Grey Lynn", Latitude = -36.8578676, Longitude = 174.7346636 },
                new Suburb{ Id = 16, Name = "Helensville", Latitude = -36.6758295, Longitude = 174.4549806 },
                new Suburb{ Id = 17, Name = "Henderson", Latitude = -36.8780201, Longitude = 174.6297256 },
                new Suburb{ Id = 18, Name = "Hillsborough", Latitude = -36.910192, Longitude = 174.7615561 },
                new Suburb{ Id = 19, Name = "Hobsonville", Latitude = -36.8106112, Longitude = 174.6122461 },
                new Suburb{ Id = 20, Name = "Howick", Latitude = -36.8921132, Longitude = 174.9276323 },
                new Suburb{ Id = 21, Name = "Kingsland", Latitude = -36.8701045, Longitude = 174.7468094 },
                new Suburb{ Id = 22, Name = "Kohimarama", Latitude = -36.8484597, Longitude = 174.8300028 },
                new Suburb{ Id = 23, Name = "Lynfield", Latitude = -36.9221502, Longitude = 174.7362421 },
                new Suburb{ Id = 24, Name = "Manukau", Latitude = -36.9928233, Longitude = 174.8840329 },
                new Suburb{ Id = 25, Name = "Manurewa", Latitude = -37.0201001, Longitude = 174.9044646 },
                new Suburb{ Id = 26, Name = "Massey", Latitude = -36.8332165, Longitude = 174.6023569 },
                new Suburb{ Id = 27, Name = "Meadowbank", Latitude = -36.8746629, Longitude = 174.8457256 },
                new Suburb{ Id = 28, Name = "Milford", Latitude = -36.7701083, Longitude = 174.7468292 },
                new Suburb{ Id = 29, Name = "Mission Bay", Latitude = -36.8473856, Longitude = 174.8291591 },
                new Suburb{ Id = 30, Name = "Morningside", Latitude = -36.8730933, Longitude = 174.7346636 },
        };

        [HttpGet("{Id:int}")]
        public Suburb Get(int Id)
        {
            Suburb suburb = Suburbs.FirstOrDefault(suburb => suburb.Id == Id);
            return suburb;
        }
    }
}

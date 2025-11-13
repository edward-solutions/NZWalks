using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using static System.Net.WebRequestMethods;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Auckand Region",
                    Code = "AR",
                    RegionImageUrl = "https://images.pexels.com/photos/1054218/pexels-photo-1054218.jpeg",
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Wellington Region",
                    Code = "WR",
                    RegionImageUrl = "https://images.pexels.com/photos/1054218/pexels-photo-1054218.jpeg",
                },
            };

            return Ok(regions);
        }

    }
}

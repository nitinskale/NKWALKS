using Microsoft.AspNetCore.Mvc;
using NKWalks.API.Models.Domain;

namespace NKWalks.API.Controllers
{
    [ApiController]
    [Route("API/reg")]
    public class RegionsController : Controller
    {
        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions = new List<Region>()
           {
               new Region
               {
                   Id= Guid.NewGuid(),
                   Name = "Welington",
                   Code ="WLG",
                   Area=227755,
                   Lat=1.8822,
                   Long=299.88,
                   Populate=500000
               },new Region
               {
                   Id= Guid.NewGuid(),
                   Name = "Auckland",
                   Code ="Auck",
                   Area=250000,
                   Lat=2.8822,
                   Long=29.88,
                   Populate=600000
               }
           };
            return Ok(regions);
        }
    }
}

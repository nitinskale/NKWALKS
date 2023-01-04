using Microsoft.AspNetCore.Mvc;
using NKWalks.API.Models.Domain;
using NKWalks.API.Repository;

namespace NKWalks.API.Controllers
{
    [ApiController]
    [Route("API/reg")]
    public class RegionsController : Controller
    {
        private readonly IResionRepository resionRepository;

        public RegionsController(IResionRepository resionRepository)
        {
            this.resionRepository = resionRepository;
        }
        [HttpGet]
        public IActionResult GetAllRegions()
        {
         var regions =  resionRepository.GetAllRegions();
            return Ok(regions);
        }
    }
}

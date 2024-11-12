using apiintegration.Datastore;
using apiintegration.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiintegration.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly Nationlize _nation;
        public NameController(Nationlize nation ) 
        {
            _nation = nation;
        
        }
        [HttpGet]
        public async Task<IActionResult> GetNationPrediction(string name)
        {
            var predict = await _nation.GetNationAsync(name);

            //var predict =  _nation.GetNationAsync(name);
            if (predict == null)
            {
                return NotFound("No prediction found.");
            }
            return Ok(predict);
        }
    }
}

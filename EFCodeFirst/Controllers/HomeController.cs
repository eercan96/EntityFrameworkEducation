using EFCodeFirst.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //Deneme2Context context = new Deneme2Context();

        Deneme2Context _context;

        public HomeController(Deneme2Context context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            var result =_context.Tests.ToList();
            return Ok(result);

        }
    }
}

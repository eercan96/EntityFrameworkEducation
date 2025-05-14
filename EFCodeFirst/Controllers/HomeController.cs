using EFCodeFirst.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        Deneme2Context context = new Deneme2Context();


        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            var result =context.Tests.ToList();
            return Ok(result);

        }
    }
}

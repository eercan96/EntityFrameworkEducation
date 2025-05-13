using EntityFrameworkEducation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkEducation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EFController : ControllerBase
    {
        DenemeContext context=new();

        [HttpGet("[action]")]
        public IActionResult Getlist()
        {
            var result =context.SimpleTables.ToList();

            return Ok(result);
        }

        [HttpPost("[action]")]
        public IActionResult Add(SimpleTable simpleTable) 
        {
            context.SimpleTables.Add(simpleTable);
            context.SaveChanges();
            return Ok("Kayıt EF");
        }

        [HttpPost("[action]")]
        public IActionResult Update(SimpleTable simpleTable)
        {
            context.SimpleTables.Update(simpleTable);
            context.SaveChanges();
            return Ok("Güncelleme EF");
        }

        [HttpPost("[action]")]
        public IActionResult Delete(SimpleTable simpleTable)
        {
            context.SimpleTables.Remove(simpleTable);
            context.SaveChanges();
            return Ok("Silme EF");
        }


        [HttpPost("[action]")]
        public IActionResult DeleteRange(SimpleTable[] simpleTables)
        {
            context.SimpleTables.RemoveRange(simpleTables);
            context.SaveChanges();
            return Ok("Silmeler EF");
        }

    }
}

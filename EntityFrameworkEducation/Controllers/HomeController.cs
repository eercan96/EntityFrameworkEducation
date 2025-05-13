using EntityFrameworkEducation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace EntityFrameworkEducation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        SqlConnection connection = new SqlConnection("Server=EMRE\\SQLEXPRESS01;Database=Database1;Integrated Security=true;");



        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SimpleTables", connection);
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);

            var result=Newtonsoft.Json.JsonConvert.SerializeObject(dt);


            return Ok(result);
        }

        [HttpPost("[action]")]
        public IActionResult Add(SimpleTable simpleTable)
        {
            SqlCommand command = new SqlCommand("insert into SimpleTables(Name) values(@parametre)", connection);
            command.Parameters.AddWithValue("@parametre", simpleTable.Name);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return Ok("Kayıt başarılı");

        }
        [HttpPost("[action]")]
        public IActionResult Update(SimpleTable simpleTable) 
        {
            SqlCommand command = new SqlCommand("update SimpleTables set Name=@parametreName where Id=@parametreId",connection);
            command.Parameters.AddWithValue("@parametreName",simpleTable.Name);
            command.Parameters.AddWithValue("parametreId", simpleTable.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return Ok("Güncelleme Tamamlandı");
        }
        [HttpPost("[action]")]
        public IActionResult Delete(SimpleTable simpleTable)
        {
            SqlCommand command = new SqlCommand("delete from SimpleTables where Id=@parametreId", connection);
            command.Parameters.AddWithValue("parametreId", simpleTable.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return Ok("Silme Tamamlandı");
        }



    }
}

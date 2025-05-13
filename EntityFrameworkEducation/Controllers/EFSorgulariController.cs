using EntityFrameworkEducation.Dtos;
using EntityFrameworkEducation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkEducation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EFSorgulariController : ControllerBase
    {
        DenemeContext context=new DenemeContext();

        [HttpGet("[action]")]
        public IActionResult GetList() 
        {

            //var products=context.Products.ToList();
            //var bestExpensiveProduct = context.Products.Max(p => p.Price);
            //var bestExpensive = context.Products.OrderByDescending(p => p.Price).FirstOrDefault();

            //var bestCheapProduct = context.Products.Min(p => p.Price);
            //var bestCheap = context.Products.OrderBy(p => p.Price).FirstOrDefault();


            //var list=context.SimpleTables.AsQueryable();

            var result = from product in context.Products
                         join category in context.Categories on product.CategoryId equals category.Id
                         select new ProductDto
                         {
                             Id = product.Id,
                             CategoryId = product.CategoryId,
                             CategoryName = category.Name,
                             Price = product.Price,

                         };

            return Ok(result.AsQueryable());


        }


        //public void Sorgular()
        //{
            //List,Ilist,Ienumarable,IQueryable
            //var result=context.SimpleTables.ToList();


            //ve &&
            //veya ||
            // içerir ifadesi için name.contains("aa")


            //IQueryable<SimpleTable> result=context.SimpleTables.AsQueryable();
            // result.Where(p=>p.Id==1||p.Id==2 || p.Name.Contains("a"));       //bellekte yer edinmez en performanslı olan


            //IEnumerable<SimpleTable> result1=context.SimpleTables.ToList();
            //result.Where(p=>p.Id==1);           //bellekte yer edinir


            //List<SimpleTable> result2=context.SimpleTables.ToList();
            //result.Where(p=>p.Id==1);      //değişime izin verir ve bellekte yer edinir

            //var result4=context.SimpleTables.ToList(); //liste getirir

            //var result5=context.SimpleTables.ToList().Where(p=> p.Id==1); //liste getirir ama ıd si 1 olanı

            //var result6=context.SimpleTables.ToList().Where(p=> p.Id==1).FirstOrDefault(); //tek elemanı getirir ama ilk ıd si 1 olanı yoksa null

            //var result7=context.SimpleTables.ToList().Where(p=> p.Id==1).SingleOrDefault(); //aradığımız kayıttan tek bir tane varsa döner ama 2 tane varsa hata yollar
            //var result8 = context.SimpleTables.FirstOrDefault(p => p.Id == 1);

            //var result9=context.SimpleTables.ToList().Where(p=> p.Name.Contains("a")).Take(5);
            //var result10=context.SimpleTables.ToList().Where(p=> p.Name.Contains("a")).OrderBy(p=>p.Id).Take(5);
            //var result11=context.SimpleTables.ToList().Where(p=> p.Name.Contains("a")).OrderByDescending(p=>p.Id).Take(5);

       // }

    }
}

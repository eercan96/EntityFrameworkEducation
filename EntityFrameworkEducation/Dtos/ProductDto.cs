using EntityFrameworkEducation.Models;

namespace EntityFrameworkEducation.Dtos
{
    public class ProductDto :Product
    {
        public string CategoryName { get; set; }
    }
}

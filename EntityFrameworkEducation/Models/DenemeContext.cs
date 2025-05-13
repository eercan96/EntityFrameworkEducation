using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkEducation.Models
{
    public class DenemeContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EMRE\\SQLEXPRESS01;Database=Database1;Integrated Security=true;TrustServerCertificate=True;");
        }
        public DbSet<SimpleTable> SimpleTables { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        

    }
}

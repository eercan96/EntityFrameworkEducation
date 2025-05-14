using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst.Model
{
    public class Deneme2Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EMRE\\SQLEXPRESS01;Database=Database2CodeFirst;Integrated Security=true;TrustServerCertificate=True;");
        }

        public DbSet<Test> Tests { get; set; }

    }
}

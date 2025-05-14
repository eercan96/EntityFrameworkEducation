using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCodeFirst.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnType("varchar(100)").IsRequired();
        }
    }
}

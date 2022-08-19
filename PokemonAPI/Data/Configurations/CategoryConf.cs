using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonAPI.Models;

namespace PokemonAPI.Data.Configurations
{
    public class CategoryConf : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(256);

            builder.HasData(
                new Category() { Name = "Electric" },
                new Category() { Name = "Water" },
                new Category() { Name = "Leaf" }
            );
        }
    }
}

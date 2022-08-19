using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonAPI.Models;

namespace PokemonAPI.Data.Configurations
{
    public class CountryConf : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(256);

            builder.HasData(
                new Country()
                {
                    Id = 1,
                    Name = "Kanto"
                }, 
                new Country()
                {
                    Id = 2,
                    Name = "Saffron City"
                },
                new Country()
                {
                    Id = 3,
                    Name = "Millet Town"
                }
                );
        }
    }
}

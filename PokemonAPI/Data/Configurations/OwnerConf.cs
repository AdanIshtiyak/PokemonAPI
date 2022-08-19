using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonAPI.Models;

namespace PokemonAPI.Data.Configurations
{
    public class OwnerConf : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Gym).IsRequired().HasMaxLength(150);
            builder.HasOne(x => x.Country).WithMany(x => x.Owners).HasForeignKey(x => x.CountryId);

            builder.HasData(
                new Owner()
                {
                    Id = 1,
                    FirstName = "Jack",
                    LastName = "London",
                    Gym = "Brocks Gym",
                    Country = new Country {Id = 4, Name = "Tokmok" }
                },
                new Owner()
                {
                    Id = 2,
                    FirstName = "Harry",
                    LastName = "Potter",
                    Gym = "Mistys Gym",
                    CountryId = 2
                },
                new Owner()
                {
                    Id = 3,
                    FirstName = "Ash",
                    LastName = "Ketchum",
                    Gym = "Ashs Gym",
                    CountryId = 3
                }
                );
        }
    }
}

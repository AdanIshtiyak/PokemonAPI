    using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonAPI.Models;

namespace PokemonAPI.Data.Configurations
{
    public class PokemonOwnerConf : IEntityTypeConfiguration<PokemonOwner>
    {
        public void Configure(EntityTypeBuilder<PokemonOwner> builder)
        {
            builder.HasKey(x => new { x.PokemonId, x.OwnerId });
            builder.HasOne(x => x.Pokemon).WithMany(x => x.PokemonOwners).HasForeignKey(x => x.PokemonId);
            builder.HasOne(x => x.Owner).WithMany(x => x.PokemonOwners).HasForeignKey(x => x.OwnerId);

            builder.HasData(
                new PokemonOwner()
                {
                    Pokemon = new Pokemon()
                    {
                        Id = 1,
                        Name = "Pikachu",
                        BirthDate = new DateTime(1903, 1, 1),
                        PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory {Category = new Category() {Id = 1, Name = "Electric"}}
                            },
                        Reviews = new List<Review>()
                            {

                                new Review {Id = 1, Title="Pikachu",Text = "Pickahu is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){Id = 1, FirstName = "Teddy", LastName = "Smith" } },
                                new Review {Id = 2,  Title="Pikachu", Text = "Pickachu is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){Id = 2, FirstName = "Taylor", LastName = "Jones" } },
                                new Review {Id = 3,  Title="Pikachu",Text = "Pickchu, pickachu, pikachu", Rating = 1,
                                Reviewer = new Reviewer(){Id = 3, FirstName = "Jessica", LastName = "McGregor" } },
                            }
                    },
                    Owner = 
                },
                new PokemonOwner()
                {
                    Pokemon = new Pokemon()
                    {
                        Id = 2,
                        Name = "Squirtle",
                        BirthDate = new DateTime(1903, 1, 1),
                        PokemonCategories = new List<PokemonCategory>()
                        {
                            new PokemonCategory { Category = new Category() {Id = 2, Name = "Water"}}
                        },
                        Reviews = new List<Review>()
                        {
                            new Review {Id = 4,  Title= "Squirtle", Text = "squirtle is the best pokemon, because it is electric", Rating = 5,
                            Reviewer = new Reviewer(){Id = 4,  FirstName = "Teddy", LastName = "Smith" } },
                            new Review {Id = 5, Title= "Squirtle",Text = "Squirtle is the best a killing rocks", Rating = 5,
                            Reviewer = new Reviewer(){Id = 5, FirstName = "Taylor", LastName = "Jones" } },
                            new Review {Id = 6, Title= "Squirtle", Text = "squirtle, squirtle, squirtle", Rating = 1,
                            Reviewer = new Reviewer(){Id = 6, FirstName = "Jessica", LastName = "McGregor" } },
                        }
                    },
                    Owner = 
                },
                new PokemonOwner()
                {
                    Pokemon = new Pokemon()
                    {
                            Id = 3,
                            Name = "Venasuar",
                            BirthDate = new DateTime(1903, 1, 1),
                            PokemonCategories = new List<PokemonCategory>()
                        {
                            new PokemonCategory { Category = new Category() {Id = 3, Name = "Leaf"}}
                        },
                        Reviews = new List<Review>()
                        {
                            new Review {Id = 7, Title="Veasaur",Text = "Venasuar is the best pokemon, because it is electric", Rating = 5,
                            Reviewer = new Reviewer(){Id = 7, FirstName = "Teddy", LastName = "Smith" } },
                            new Review {Id = 8, Title="Veasaur",Text = "Venasuar is the best a killing rocks", Rating = 5,
                            Reviewer = new Reviewer(){Id = 8, FirstName = "Taylor", LastName = "Jones" } },
                            new Review {Id = 9, Title="Veasaur",Text = "Venasuar, Venasuar, Venasuar", Rating = 1,
                            Reviewer = new Reviewer(){Id = 9, FirstName = "Jessica", LastName = "McGregor" } },
                        }
                    },
                    Owner = 
                });
        }
    }
}

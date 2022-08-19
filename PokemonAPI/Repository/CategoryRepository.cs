using PokemonAPI.Data;
using PokemonAPI.Interfaces;
using PokemonAPI.Models;

namespace PokemonAPI.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PokemonDbContext _context;

        public CategoryRepository(PokemonDbContext context)
        {
            _context = context;
        }

        public bool CategoryExists(int categoryId)
        {
            return _context.Pokemon.Any(x => x.Id == categoryId);
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int categoryId)
        {
            return _context.Categories.Where(x => x.Id == categoryId).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(x => x.CategoryId == categoryId).Select(x => x.Pokemon).ToList();
        }
    }
}

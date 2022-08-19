using PokemonAPI.Data;
using PokemonAPI.Interfaces;
using PokemonAPI.Models;

namespace PokemonAPI.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokemonDbContext _context;

        public PokemonRepository(PokemonDbContext context)
        {
            _context = context;
        }

        public Pokemon GetPokemon(int pokeId)
        {
            return _context.Pokemon.Where(x => x.Id == pokeId).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(x => x.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRaiting(int pokeId)
        {
            var review = _context.Reviews.Where(x => x.Pokemon.Id == pokeId);
            if (review.Count() <= 0)
                return 0;
            return ((decimal)review.Sum(x => x.Rating) / review.Count());
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.ToList();
        }

        public bool PokemonExists(int pokeId)
        {
            return _context.Pokemon.Any(x => x.Id == pokeId);
        }
    }
}

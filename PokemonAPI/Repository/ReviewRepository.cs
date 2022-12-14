using PokemonAPI.Data;
using PokemonAPI.Interfaces;
using PokemonAPI.Models;

namespace PokemonAPI.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly PokemonDbContext _context;

        public ReviewRepository(PokemonDbContext context)
        {
            _context = context;
        }
        public Review GetReview(int reviewId)
        {
            return _context.Reviews.Where(x => x.Id == reviewId).FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        public ICollection<Review> GetReviewsOfAPokemon(int pokeId)
        {
            return _context.Reviews.Where(x => x.Pokemon.Id == pokeId).ToList();
        }

        public bool ReviewExists(int reviewId)
        {
            return _context.Reviews.Any(x => x.Id == reviewId);
        }
    }
}

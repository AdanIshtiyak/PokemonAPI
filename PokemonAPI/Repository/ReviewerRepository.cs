using Microsoft.EntityFrameworkCore;
using PokemonAPI.Data;
using PokemonAPI.Interfaces;
using PokemonAPI.Models;

namespace PokemonAPI.Repository
{
    public class ReviewerRepository : IReviewerRepository
    {
        private readonly PokemonDbContext _context;

        public ReviewerRepository(PokemonDbContext context)
        {
            _context = context;
        }
        public ICollection<Review> GetReviewsByReviewer(int reviewerId)
        {
            return _context.Reviews.Where(x => x.Reviewer.Id == reviewerId).ToList();
        }

        public Reviewer GetReviewer(int reviewerId)
        {
            return _context.Reviewers.Where(x => x.Id == reviewerId).Include(x => x.Reviews).FirstOrDefault();
        }

        public ICollection<Reviewer> GetReviewers()
        {
            return _context.Reviewers.ToList();
        }

        public bool ReviewerExists(int reviewerId)
        {
            return _context.Reviewers.Any(x => x.Id == reviewerId);
        }
    }
}

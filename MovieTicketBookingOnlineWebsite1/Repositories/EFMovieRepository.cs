using Microsoft.EntityFrameworkCore;
using MovieTicketBookingOnlineWebsite1.Models;

namespace MovieTicketBookingOnlineWebsite1.Repositories
{
    public class EFMovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;
        public EFMovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            // return await _context.Products.ToListAsync();
            return await _context.Movies.Include(p => p.Category) // Include thông tin về category
        .ToListAsync();


        }


        public async Task<Movie> GetByIdAsync(int id)
        {
            // return await _context.Products.FindAsync(id);
            // lấy thông tin kèm theo category
            return await _context.Movies.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
        }


        public async Task AddAsync(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateAsync(Movie movie)
        {
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
        }


    }
}

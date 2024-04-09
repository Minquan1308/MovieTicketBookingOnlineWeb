using System.ComponentModel.DataAnnotations;

namespace MovieTicketBookingOnlineWebsite1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public string? ImageUrl { get; set; }
        public List<MovieImage>? Images { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}

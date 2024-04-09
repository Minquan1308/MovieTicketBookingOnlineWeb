namespace MovieTicketBookingOnlineWebsite1.Models
{
    public class MovieImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}

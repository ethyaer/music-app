namespace API.Domain.Entities
{
    public class TrackPlay
    {
        public int TrackPlayId { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public int? TrackId { get; set; }
        public Track? Track { get; set; }
        public DateOnly PlayedAt { get; set; }
    }
}

namespace API.Domain.Entities
{
    public class TrackNotion
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int TrackId { get; set; } 
        public Track Track { get; set; } = null!;
        public int? NotionId { get; set; }
        public TrackNotionType? TrackNotionType { get; set; }
    }
}

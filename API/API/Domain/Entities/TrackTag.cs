namespace API.Domain.Entities
{
    /// <summary>
    /// Join entity linking a track to a tag.
    /// </summary>
    public class TrackTag
    {
        /// <summary>
        /// Foreign key to the track.
        /// </summary>
        public int TrackId { get; set; }

        /// <summary>
        /// Navigation property to the track.
        /// </summary>
        public Track Track { get; set; } = null!;

        /// <summary>
        /// Foreign key to the tag.
        /// </summary>
        public int TagId { get; set; }

        /// <summary>
        /// Navigation property to the tag.
        /// </summary>
        public Tag Tag { get; set; } = null!;
    }
}

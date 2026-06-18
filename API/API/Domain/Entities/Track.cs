namespace API.Domain.Entities
{
    /// <summary>
    /// Represents an audio track with metadata and relationships to compositions, tags, plays and creators.
    /// </summary>
    public class Track
    {
        /// <summary>
        /// Primary key of the track.
        /// </summary>
        public int TrackId { get; set; }

        /// <summary>
        /// The display name or title of the track.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Duration of the track in seconds.
        /// </summary>
        public int DurationSec { get; set; } = 0;

        /// <summary>
        /// URL to the cover image for the track.
        /// </summary>
        public string CoverImgURL { get; set; } = null!;

        /// <summary>
        /// URL to the audio file for the track.
        /// </summary>
        public string AudioURL { get; set; } = null!;

        /// <summary>
        /// Optional additional information about the track.
        /// </summary>
        public string? Info { get; set; }

        /// <summary>
        /// Composition-to-track relationships for compositions that include this track.
        /// </summary>
        public ICollection<CompositionTrack> CompositionTracks { get; set; } = new List<CompositionTrack>();

        /// <summary>
        /// Play events for this track.
        /// </summary>
        public ICollection<TrackPlay> TrackPlays { get; set; } = new List<TrackPlay>();

        /// <summary>
        /// Tags associated with this track.
        /// </summary>
        public ICollection<TrackTag> TrackTags { get; set; } = new List<TrackTag>();

        /// <summary>
        /// User notions (likes, bookmarks, etc.) for this track.
        /// </summary>
        public ICollection<TrackNotion> TrackNotions { get; set; } = new List<TrackNotion>();

        /// <summary>
        /// Creators linked to this track and their roles.
        /// </summary>
        public ICollection<TrackCreator> TrackCreators { get; set; } = new List<TrackCreator>();
    }
}

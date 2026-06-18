namespace API.Domain.Entities
{
    /// <summary>
    /// Represents a tag that can be applied to compositions and tracks.
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Primary key of the tag.
        /// </summary>
        public int TagId { get; set; }

        /// <summary>
        /// Display name of the tag.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Composition-tag relationships for compositions using this tag.
        /// </summary>
        public ICollection<CompositionTag> CompositionTags { get; set; } = new List<CompositionTag>();

        /// <summary>
        /// Track-tag relationships for tracks using this tag.
        /// </summary>
        public ICollection<TrackTag> TrackTags { get; set; } = new List<TrackTag>();
    }
}

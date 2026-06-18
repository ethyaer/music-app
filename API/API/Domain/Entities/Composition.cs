namespace API.Domain.Entities
{
    /// <summary>
    /// Represents a musical composition which may contain tracks, creators, tags and genre associations.
    /// </summary>
    public class Composition
    {
        /// <summary>
        /// Primary key for the composition.
        /// </summary>
        public int CompId { get; set; }

        /// <summary>
        /// Title of the composition.
        /// </summary>
        public string Title { get; set; } = null!;

        /// <summary>
        /// Creation date or year of the composition (stored as string).
        /// </summary>
        public DateOnly CreationDate { get; set; }

        /// <summary>
        /// Optional URL to a cover image for the composition.
        /// </summary>
        public string? CoverImageURL { get; set; }

        /// <summary>
        /// Foreign key referencing the composition type.
        /// </summary>
        public int? CompTypeId { get; set; }
        public CompositionType? CompositionType { get; set; }

        /// <summary>
        /// Foreign key referencing the composition subtype.
        /// </summary>
        public int? CompSubtypeId { get; set; }
        public CompositionSubtype? CompositionSubtype { get; set; }

        /// <summary>
        /// Optional additional information about the composition.
        /// </summary>
        public string? Info { get; set; }

        /// <summary>
        /// Whether the composition is private.
        /// </summary>
        public bool IsPrivate { get; set; } = false;

        /// <summary>
        /// Creators associated with this composition (and their roles).
        /// </summary>
        public ICollection<CompositionCreator> CompositionCreators { get; set; } = new List<CompositionCreator>();

        /// <summary>
        /// Tracks that belong to this composition.
        /// </summary>
        public ICollection<CompositionTrack> CompositionTracks { get; set; } = new List<CompositionTrack>();

        /// <summary>
        /// Genre/subgenre relationships for this composition.
        /// </summary>
        public ICollection<CompositionSubgenre> CompositionSubgenres { get; set; } = new List<CompositionSubgenre>();

        /// <summary>
        /// Tags assigned to this composition.
        /// </summary>
        public ICollection<CompositionTag> CompositionTags { get; set; } = new List<CompositionTag>();
    }
}

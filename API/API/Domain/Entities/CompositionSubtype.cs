namespace API.Domain.Entities
{
    /// <summary>
    /// Represents a more specific category (subtype) of a <see cref="CompositionType"/>.
    /// </summary>
    /// <remarks>
    /// Examples: if a CompositionType is "Symphony", subtypes could be "Chamber Symphony" or "Symphonic Poem".
    /// DocFX will include these comments in generated API documentation.
    /// </remarks>
    public class CompositionSubtype
    {
        /// <summary>
        /// Primary key for the composition subtype.
        /// </summary>
        public int CompSubtypeId { get; set; }

        /// <summary>
        /// Compositions that belong to this subtype.
        /// </summary>
        /// <remarks>
        /// One subtype can be referenced by many compositions.
        /// </remarks>
        public ICollection<Composition> Compositions { get; set; } = new List<Composition>();

        /// <summary>
        /// Foreign key referencing the parent composition type.
        /// </summary>
        public int? CompTypeId { get; set; }

        /// <summary>
        /// Navigation property to the parent <see cref="CompositionType"/>.
        /// </summary>
        /// <remarks>
        /// This property allows navigation to the parent composition type.
        /// </remarks>
        public CompositionType? CompositionType { get; set; }

        /// <summary>
        /// The display name of the composition subtype.
        /// </summary>
        public string Name { get; set; } = null!;
    }
}

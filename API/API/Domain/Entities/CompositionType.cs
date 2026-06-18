namespace API.Domain.Entities
{
    /// <summary>
    /// Represents a type or category for a <see cref="Composition"/>.
    /// </summary>
    /// <remarks>
    /// This entity is used to group compositions by type (for example: "Symphony", "Sonata", "Concerto").
    /// DocFX will pick up these XML comments when generating API documentation.
    /// </remarks>
    public class CompositionType
    {
        /// <summary>
        /// Primary key for the composition type.
        /// </summary>
        public int CompTypeId { get; set; }

        /// <summary>
        /// Compositions that belong to this type.
        /// </summary>
        /// <remarks>
        /// One composition type can be associated with many compositions.
        /// </remarks>
        public ICollection<Composition> Compositions { get; set; } = new List<Composition>();

        /// <summary>
        /// The display name of the composition type.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Collection of subtypes associated with this composition type.
        /// </summary>
        /// <remarks>
        /// Use this collection to access more specific categories that belong to this type.
        /// </remarks>
        public ICollection<CompositionSubtype> CompositionSubtypes { get; set; } = null!;
    }
}

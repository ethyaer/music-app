namespace API.Domain.Entities
{
    /// <summary>
    /// Join entity linking a composition to a subgenre.
    /// </summary>
    public class CompositionSubgenre
    {
        /// <summary>
        /// Foreign key to the composition.
        /// </summary>
        public int CompId { get; set; }

        /// <summary>
        /// Navigation property to the composition.
        /// </summary>
        public Composition Composition { get; set; } = null!;

        /// <summary>
        /// Foreign key to the subgenre.
        /// </summary>
        public int SubgenreId { get; set; }

        /// <summary>
        /// Navigation property to the subgenre.
        /// </summary>
        public Subgenre Subgenre { get; set; } = null!;
    }
}

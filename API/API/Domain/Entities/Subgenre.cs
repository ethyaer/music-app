namespace API.Domain.Entities
{
    /// <summary>
    /// Represents a subgenre that belongs to a genre.
    /// </summary>
    public class Subgenre
    {
        /// <summary>
        /// Primary key of the subgenre.
        /// </summary>
        public int SubgenreId { get; set; }

        /// <summary>
        /// Foreign key to the parent genre.
        /// </summary>
        public int GenreId { get; set; }

        /// <summary>
        /// Navigation property to the parent genre.
        /// </summary>
        public Genre Genre { get; set; } = null!;

        /// <summary>
        /// Display name of the subgenre.
        /// </summary>
        public string Name { get; set; } = null!;
    }
}

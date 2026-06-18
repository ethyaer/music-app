namespace API.Domain.Entities
{
    /// <summary>
    /// Represents a musical genre and its child subgenres.
    /// </summary>
    public class Genre
    {
        /// <summary>
        /// Primary key of the genre.
        /// </summary>
        public int GenreId { get; set; }

        /// <summary>
        /// Foreign key to the parent category.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Navigation property to the category.
        /// </summary>
        public Category Category { get; set; } = null!;

        /// <summary>
        /// Display name of the genre.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Subgenres belonging to this genre.
        /// </summary>
        public ICollection<Subgenre> Subgenres { get; set; } = new List<Subgenre>();
    }
}

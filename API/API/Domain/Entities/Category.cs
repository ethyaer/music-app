namespace API.Domain.Entities
{
    /// <summary>
    /// Top-level category grouping genres.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Primary key of the category.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Display name of the category.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Genres contained in this category.
        /// </summary>
        public ICollection<Genre> Genres { get; set; } = new List<Genre>();
    }
}

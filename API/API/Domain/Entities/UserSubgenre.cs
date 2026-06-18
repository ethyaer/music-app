namespace API.Domain.Entities
{
    /// <summary>
    /// Join entity linking users to their preferred subgenres.
    /// </summary>
    public class UserSubgenre
    {
        /// <summary>
        /// Foreign key to the user.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Navigation property to the user.
        /// </summary>
        public User User { get; set; } = null!;

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

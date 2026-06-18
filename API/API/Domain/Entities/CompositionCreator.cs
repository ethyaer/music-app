namespace API.Domain.Entities
{
    /// <summary>
    /// Join entity linking a composition with a user and role.
    /// </summary>
    public class CompositionCreator
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
        /// Foreign key to the user.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Navigation property to the user.
        /// </summary>
        public User User { get; set; } = null!;

        /// <summary>
        /// Foreign key to the role.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Navigation property to the role.
        /// </summary>
        public Role Role { get; set; } = null!;
    }
}

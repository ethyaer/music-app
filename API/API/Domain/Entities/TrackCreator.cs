namespace API.Domain.Entities
{
    /// <summary>
    /// Join entity linking a track to a user and role.
    /// </summary>
    public class TrackCreator
    {
        /// <summary>
        /// Foreign key to the track.
        /// </summary>
        public int TrackId { get; set; }

        /// <summary>
        /// Navigation property to the track.
        /// </summary>
        public Track Track { get; set; } = null!;

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

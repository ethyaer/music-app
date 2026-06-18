namespace API.Domain.Entities
{
    /// <summary>
    /// Represents an application user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Primary key for the user.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Login identifier for the user.
        /// </summary>
        public string Login { get; set; } = null!;

        /// <summary>
        /// Hashed password for authentication.
        /// </summary>
        public string PasswordHash { get; set; } = null!;

        /// <summary>
        /// Display name of the user.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Optional biography or about text for the user.
        /// </summary>
        public string? Biography { get; set; }

        /// <summary>
        /// Optional URL to the user's profile image.
        /// </summary>
        public string? ProfileImageURL { get; set; }

        /// <summary>
        /// Optional URL to the user's background image.
        /// </summary>
        public string? BackgroundImageURL { get; set; }

        /// <summary>
        /// Follow relationships for this user.
        /// </summary>
        public ICollection<Follow> Follows { get; set; } = new List<Follow>();

        /// <summary>
        /// Track notions (likes, bookmarks) made by this user.
        /// </summary>
        public ICollection<TrackNotion> TrackNotions { get; set; } = new List<TrackNotion>();

        /// <summary>
        /// Creator links for tracks where this user participated.
        /// </summary>
        public ICollection<TrackCreator> TrackCreators { get; set; } = new List<TrackCreator>();

        /// <summary>
        /// Plays performed by this user.
        /// </summary>
        public ICollection<TrackPlay> TrackPlays { get; set; } = new List<TrackPlay>();

        /// <summary>
        /// Subgenres preferred by this user.
        /// </summary>
        public ICollection<UserSubgenre> UserSubgenres { get; set; } = new List<UserSubgenre>();
    }
}

namespace API.Domain.Entities
{
    /// <summary>
    /// Represents a role a user can have in relation to a composition or track (e.g. "Composer", "Performer").
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Primary key of the role.
        /// </summary>
        public int RoleId { get ; set; }

        /// <summary>
        /// Display name of the role.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Track creators associated with this role.
        /// </summary>
        public ICollection<TrackCreator> TrackCreators { get; set; } = new List<TrackCreator>();

        /// <summary>
        /// Composition creators associated with this role.
        /// </summary>
        public ICollection<CompositionCreator> CompositionCreators { get; set; } = new List<CompositionCreator>();
    }
}

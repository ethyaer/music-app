namespace API.Domain.Entities
{
    /// <summary>
    /// Join entity linking a composition to a track and storing the track's position within the composition.
    /// </summary>
    public class CompositionTrack
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
        /// Foreign key to the track.
        /// </summary>
        public int TrackId { get; set; }

        /// <summary>
        /// Navigation property to the track.
        /// </summary>
        public Track Track { get; set; } = null!;

        /// <summary>
        /// Position (order) of the track inside the composition.
        /// </summary>
        public int Position { get; set; }
    }
}

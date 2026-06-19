using System.Collections.Generic;

namespace API.Application.DTOs
{
    /// <summary>
    /// Data transfer object representing a user for API responses.
    /// Contains scalar user properties and collections of related entity ids.
    /// </summary>
    public class UserDTO
    {
        /// <summary>
        /// Primary key of the user.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Login identifier for the user.
        /// </summary>
        public string Login { get; set; } = null!;

        /// <summary>
        /// Display name of the user.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Optional biography.
        /// </summary>
        public string? Biography { get; set; }

        /// <summary>
        /// Optional URL to profile image.
        /// </summary>
        public string? ProfileImageURL { get; set; }

        /// <summary>
        /// Optional URL to background image.
        /// </summary>
        public string? BackgroundImageURL { get; set; }

        /// <summary>
        /// Preferred subgenre ids for the user.
        /// </summary>
        public IEnumerable<int> SubgenreIds { get; set; } = new List<int>();

        /// <summary>
        /// Tracks where the user is a creator (track ids).
        /// </summary>
        public IEnumerable<int> TrackIdsCreated { get; set; } = new List<int>();

        /// <summary>
        /// Compositions where the user is a creator (composition ids).
        /// </summary>
        public IEnumerable<int> CompositionIdsCreated { get; set; } = new List<int>();

        /// <summary>
        /// Track play event ids tied to the user.
        /// </summary>
        public IEnumerable<int> TrackPlayIds { get; set; } = new List<int>();

        /// <summary>
        /// Follow type ids the user follows.
        /// </summary>
        public IEnumerable<int> FollowTypeIds { get; set; } = new List<int>();
    }
}

using API.Domain.Enums;

namespace API.Application.DTOs
{
    // Tracks, compositions
    public class CardDTO
    {
        public int CardId { get; init; }

        public string Title { get; init; } = string.Empty;

        // Required image; may be empty if not available
        public string ImageUrl { get; init; } = string.Empty;

        public int CreatorId { get; init; }
        public string CreatorName { get; init; } = string.Empty;

        // Use enum for category
        public CardCategories CardCategory { get; init; }

        // Optional composition subtype information (only for albums)
        public int? CompSubtypeId { get; init; }
        public string? CompSubtypeName { get; init; }
    }
}

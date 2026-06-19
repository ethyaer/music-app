using API.Domain.Enums;

namespace API.Application.DTOs
{
    public class RecommendationQuery
    {
        public Guid? UserId { get; set; }
        public int TimePeriodDays { get; set; } = 50;
        public int? NotionTypeId { get; set; }
        public int? FollowTypeId { get; set; }

        public RecommendationTypes Type { get; set; }
    }
}

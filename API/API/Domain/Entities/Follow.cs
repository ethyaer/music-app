namespace API.Domain.Entities
{
    public class Follow
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int FollowTypeId { get; set; }
        public FollowType FollowType { get; set; } = null!;
    }
}

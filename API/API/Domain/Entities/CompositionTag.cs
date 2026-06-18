namespace API.Domain.Entities
{
    public class CompositionTag
    {
        public int CompId { get; set; }
        public Composition Composition { get; set; } = null!;
        public int TagId { get; set; }
        public Tag Tag { get; set; } = null!;
    }
}

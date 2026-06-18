using Microsoft.EntityFrameworkCore;
using API.Domain.Entities;

namespace API.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Subgenre> Subgenres { get; set; } = null!;
        public DbSet<UserSubgenre> UserSubgenres { get; set; } = null!;

        public DbSet<Tag> Tags { get; set; } = null!;

        public DbSet<CompositionType> CompositionTypes { get; set; } = null!;
        public DbSet<CompositionSubtype> CompositionSubtypes { get; set; } = null!;
        public DbSet<Composition> Compositions { get; set; } = null!;
        public DbSet<CompositionSubgenre> CompositionSubgenres { get; set; } = null!;
        public DbSet<CompositionCreator> CompositionCreators { get; set; } = null!;
        public DbSet<CompositionTrack> CompositionTracks { get; set; } = null!;
        public DbSet<CompositionTag> CompositionTags { get; set; } = null!;

        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Track> Tracks { get; set; } = null!;
        public DbSet<TrackCreator> TrackCreators { get; set; } = null!;
        public DbSet<TrackTag> TrackTags { get; set; } = null!;
        public DbSet<TrackPlay> TrackPlays { get; set; } = null!;

        public DbSet<FollowType> FollowTypes { get; set; } = null!;
        public DbSet<Follow> Follows { get; set; } = null!;

        public DbSet<TrackNotionType> TrackNotionTypes { get; set; } = null!;
        public DbSet<TrackNotion> TrackNotions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Table mappings (match snake_case names used in DB schema)
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Category>().ToTable("categories");
            modelBuilder.Entity<Genre>().ToTable("genres");
            modelBuilder.Entity<Subgenre>().ToTable("subgenres");
            modelBuilder.Entity<UserSubgenre>().ToTable("user_subgenres");

            modelBuilder.Entity<Tag>().ToTable("tags");

            modelBuilder.Entity<CompositionType>().ToTable("composition_types");
            modelBuilder.Entity<CompositionSubtype>().ToTable("composition_subtypes");
            modelBuilder.Entity<Composition>().ToTable("compositions");
            modelBuilder.Entity<CompositionSubgenre>().ToTable("composition_subgenres");
            modelBuilder.Entity<CompositionCreator>().ToTable("composition_creators");
            modelBuilder.Entity<CompositionTrack>().ToTable("composition_tracks");
            modelBuilder.Entity<CompositionTag>().ToTable("composition_tags");

            modelBuilder.Entity<Role>().ToTable("roles");
            modelBuilder.Entity<Track>().ToTable("tracks");
            modelBuilder.Entity<TrackCreator>().ToTable("track_creators");
            modelBuilder.Entity<TrackTag>().ToTable("track_tags");
            modelBuilder.Entity<TrackPlay>().ToTable("track_plays");

            modelBuilder.Entity<FollowType>().ToTable("follow_types");
            modelBuilder.Entity<Follow>().ToTable("follows");

            modelBuilder.Entity<TrackNotionType>().ToTable("track_notion_types");
            modelBuilder.Entity<TrackNotion>().ToTable("track_notions");

            // Composite keys for join tables
            modelBuilder.Entity<UserSubgenre>().HasKey(us => new { us.UserId, us.SubgenreId });
            modelBuilder.Entity<CompositionSubgenre>().HasKey(cs => new { cs.CompId, cs.SubgenreId });
            modelBuilder.Entity<CompositionCreator>().HasKey(cc => new { cc.CompId, cc.UserId });
            modelBuilder.Entity<CompositionTrack>().HasKey(ct => new { ct.CompId, ct.TrackId });
            modelBuilder.Entity<TrackCreator>().HasKey(tc => new { tc.TrackId, tc.UserId });
            modelBuilder.Entity<TrackTag>().HasKey(tt => new { tt.TrackId, tt.TagId });
            modelBuilder.Entity<CompositionTag>().HasKey(ct => new { ct.CompId, ct.TagId });
            modelBuilder.Entity<Follow>().HasKey(f => new { f.UserId, f.FollowTypeId });
            modelBuilder.Entity<TrackNotion>().HasKey(tn => new { tn.UserId, tn.TrackId });

            // DateOnly columns mapping
            modelBuilder.Entity<Composition>().Property(c => c.CreationDate).HasColumnType("date");
            modelBuilder.Entity<TrackPlay>().Property(tp => tp.PlayedAt).HasColumnType("date");

            // Optional FKs are inferred from nullable properties; no further configuration required here.
        }
    }
}

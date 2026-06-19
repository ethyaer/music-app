using API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using API.Application.DTOs;
using API.Domain.Enums;
using System.Reflection;

namespace API.Infrastructure.Repositories
{
    public class RecommendationRepository : IRecommendationRepository
    {
        private readonly AppDbContext context;

        public RecommendationRepository(AppDbContext context) => this.context = context;
        public IQueryable<TrackPlay> TrackPlays => context.TrackPlays.AsNoTracking();
        public IQueryable<TrackNotion> TrackNotions => context.TrackNotions.AsNoTracking();
        public IQueryable<Follow> Follows => context.Follows.AsNoTracking();
        //public IQueryable<CompositionSubtype> CompositionSubtypes => context.CompositionSubtypes.AsNoTracking();
        //public IQueryable<CompositionTrack> CompositionTracks => context.CompositionTracks.AsNoTracking();

        //public CardCategories CardCategory { get; private set; }

        public async Task<List<Track>> GetTracksByIdsAsync(IEnumerable<int> trackIds) => await context.Tracks.Where(x => trackIds.Contains(x.TrackId)).ToListAsync();
        public async Task<List<CardDTO>> GetCardsByIdsAsync(IEnumerable<int> trackIds) => await context.Tracks.Where(x => trackIds.Contains(x.TrackId)).Select(x => new CardDTO
        {
            CardId = x.TrackId,
            Title = x.Name,
            ImageUrl = x.CoverImgURL,
            CreatorName = x.TrackCreators.Select(y => y.User.Name).FirstOrDefault(),
            CardCategory = Domain.Enums.CardCategories.Track,
            CompSubtypeId = x.CompositionTracks.Select(z => z.Composition.CompositionSubtype.CompSubtypeId).FirstOrDefault(),
            CompSubtypeName = x.CompositionTracks.Select(z => z.Composition.CompositionSubtype.Name).FirstOrDefault()
        }).ToListAsync();
    }
}

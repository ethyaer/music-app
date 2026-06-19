using API.Domain.Entities;
using API.Application.DTOs;

namespace API.Infrastructure.Repositories
{
    public interface IRecommendationRepository
    {
        IQueryable<TrackPlay> TrackPlays { get; }
        IQueryable<TrackNotion> TrackNotions { get; }
        IQueryable<Follow> Follows { get; }
        //IQueryable<CompositionSubtype> CompositionSubtypes { get; }
        //IQueryable<CompositionTrack> CompositionTracks { get; }

        Task<List<Track>> GetTracksByIdsAsync(IEnumerable<int> trackIds);
        Task<List<CardDTO>> GetCardsByIdsAsync(IEnumerable<int> trackIds);
    }
}

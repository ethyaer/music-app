using System.Linq;
using API.Application.DTOs;
using API.Domain.Entities;

namespace API.Application.Mappers
{
    public static class CardMapper
    {
        public static CardDTO FromComposition(Composition comp, int creatorId, string creatorName)
        {
            return new CardDTO
            {
                CardId = comp.CompId,
                Title = comp.Title ?? string.Empty,
                ImageUrl = comp.CoverImageURL ?? string.Empty,
                CreatorId = creatorId,
                CreatorName = creatorName,
                CardCategory = API.Domain.Enums.CardCategories.Album,
                CompSubtypeId = comp.CompSubtypeId,
                CompSubtypeName = comp.CompositionSubtype?.Name
            };
        }

        public static CardDTO FromTrack(Track track, int creatorId, string creatorName)
        {
            var isInComposition = track.CompositionTracks?.Any() == true;
            return new CardDTO
            {
                CardId = track.TrackId,
                Title = track.Name ?? string.Empty,
                ImageUrl = track.CoverImgURL ?? string.Empty,
                CreatorId = creatorId,
                CreatorName = creatorName,
                CardCategory = API.Domain.Enums.CardCategories.Track,
                CompSubtypeId = null,
                CompSubtypeName = isInComposition ? "TrackInAlbum" : "Single"
            };
        }
    }
}

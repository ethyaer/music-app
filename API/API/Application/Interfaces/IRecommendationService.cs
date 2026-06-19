using API.Application.DTOs;
using API.Domain.Entities;

namespace API.Application.Interfaces
{
    public interface IRecommendationService
    {
        Task<List<CardDTO>> GetRecommendationAsync(RecommendationQuery query, int take = 20);
    }
}

using API.Application.Interfaces;
using API.Application.DTOs;
using API.Domain.Entities;
using API.Infrastructure.Repositories;

namespace API.Application.Services
{
    public class RecommendationService
    {
        private readonly IScoringService scoringService;
        private readonly IRecommendationRepository recommendationRepository;

        public RecommendationService(IScoringService scoringService, IRecommendationRepository recommendationRepository)
        {
            this.scoringService = scoringService;
            this.recommendationRepository = recommendationRepository;
        }

        public async Task<List<CardDTO>> GetRecommendationAsync(RecommendationQuery query, int take = 20) 
        {
            
        }
    }
}

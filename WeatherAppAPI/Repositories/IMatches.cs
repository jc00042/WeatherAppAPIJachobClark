using WeatherAppAPI.Entities;

namespace WeatherAppAPI.Repositories

// This API was done by Andrew Forman

{
    public interface IMatches
    {
        public Task<List<MatchResults>> GetMatchResults(int MatchResultsID);
    }
}
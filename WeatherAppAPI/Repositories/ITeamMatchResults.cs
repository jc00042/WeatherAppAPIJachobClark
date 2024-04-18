using WeatherAppAPI.Entities;

//This API was done by Andrew Forman

namespace WeatherAppAPI.Repositories
{
    public interface ITeamMatchResults
    {
        public Task<List<MatchResults>> GetTeamMatchResults(int TeamID);
    }
}
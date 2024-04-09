using WeatherAppAPI.Entities;

//This API done by Jachob Clark
/**
 * This interface is the interface for ITeamService.
 * ITeamService is a service that will get you the list
 * of teams in the same desired city. The naming convention
 * does not say what it does directly and can be misleading.
 */

namespace WeatherAppAPI.Repositories
{
    public interface ITeamService
    {
        public Task<List<Team>> SameLocation(string TeamLocation);
    }
}

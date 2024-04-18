using WeatherAppAPI.Entities;

//This API was done by Braelynne Sandreth

/**
 * The Match Result interface is a service responsible for managing match results.
 * The interface specifies the method InsertMatchResults, which is expected to.
 */

namespace WeatherAppAPI.Repositories

{
    public interface IMatchResultsService
    {
        public Task<List<MatchResults>> PlayerInfo(int PID);


    }
}


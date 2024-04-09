using WeatherAppAPI.Data;
using WeatherAppAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

//This API done by Jachob Clark
/**
 * This is the service for ITeamService.
 * ITeamService is a service that will get you the list
 * of teams in the same desired city. The naming convention
 * does not say what it does directly and can be misleading.
 */

namespace WeatherAppAPI.Repositories
{
    public class TeamService : ITeamService
    {
        private readonly DbContextClass _dbContextClass;
        public TeamService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Team>> SameLocation(string TeamLocation)
        {
            var param = new SqlParameter("@TeamLocation", TeamLocation);
            var sameLocation = await Task.Run(() => _dbContextClass.Team.FromSqlRaw("exec spSameLocation @TeamLocation", param).ToListAsync());
            return sameLocation;
        }
    }
}

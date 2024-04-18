using WeatherAppAPI.Data;
using WeatherAppAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

//This API was done by Andrew Forman

namespace WeatherAppAPI.Repositories
{
    public class TeamMatchResults : ITeamMatchResults
    {
        private readonly DbContextClass _dbContextClass;
        public TeamMatchResults(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<MatchResults>> GetTeamMatchResults(int TeamID)
        {
            var param = new SqlParameter("@TID", TeamID);
            var TeammatchDetails = await Task.Run(() => _dbContextClass.MatchResults.FromSqlRaw("exec spGetTeamMatchResults @TeamID", param).ToListAsync());
            return TeammatchDetails;
        }
    }
}
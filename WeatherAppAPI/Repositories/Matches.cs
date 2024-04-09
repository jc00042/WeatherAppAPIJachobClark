using WeatherAppAPI.Data;
using WeatherAppAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
// This API was done by Andrew Forman

namespace WeatherAppAPI.Repositories
{
    public class Matches : IMatches
    {
        private readonly DbContextClass _dbContextClass;
        public Matches(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<MatchResults>> GetMatchResults(int MatchResultsID)
        {
            var param = new SqlParameter("@MatchResultsID", MatchResultsID);
            var matchDetails = await Task.Run(() => _dbContextClass.MatchResults.FromSqlRaw("exec spGetMatchResults @MatchResultsID", param).ToListAsync());
            return matchDetails;
        }
    }
}

using WeatherAppAPI.Data;
using WeatherAppAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

//This API done by Jachob Clark
/**
 * This  is the service for NewPlayerService.
 * NewPlayerService is a service that will get you the information
 * of a desired player. The naming convention does not say what it
 * does directly and can be misleading.
 */

namespace WeatherAppAPI.Repositories
{
    public class NewPlayerService : INewPlayerService
    {
        private readonly DbContextClass _dbContextClass;
        public NewPlayerService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<NewPlayer>> PlayerInfo(int PID)
        {
            var param = new SqlParameter("@PID", PID);
            var playerInfo = await Task.Run(() => _dbContextClass.NewPlayer.FromSqlRaw("exec spPlayerInfo @PID", param).ToListAsync());
            return playerInfo;
        }

    }
}

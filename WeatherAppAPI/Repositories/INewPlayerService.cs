using WeatherAppAPI.Entities;

//This API done by Jachob Clark

/**
 * This interface is the interface for NewPlayerService.
 * NewPlayerService is a service that will get you the information
 * of a desired player. The naming convention does not say what it
 * does directly and can be misleading.
 */

namespace WeatherAppAPI.Repositories
{
    public interface INewPlayerService
    {
        public Task<List<NewPlayer>> PlayerInfo(int PID);

    }

}

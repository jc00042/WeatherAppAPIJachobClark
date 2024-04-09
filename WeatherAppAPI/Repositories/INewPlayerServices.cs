using WeatherAppAPI.Entities;

//This API is by Braelynne Sandreth

/**
 * This interface declares a method which is responsible for inserting a new player into the system. 
 */


namespace WeatherAppAPI.Repositories
{
    public interface INewPlayerServices
    {
        Task InsertNewPlayer(NewPlayer newPlayer);
    }
}
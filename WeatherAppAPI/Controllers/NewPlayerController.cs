using Microsoft.AspNetCore.Mvc;
using WeatherAppAPI.Entities;
using WeatherAppAPI.Repositories;

//This API done by Jachob Clark
/**
 * This controller is the controller for NewPlayerService.
 * NewPlayerService is a service that will get you the information
 * of a desired player. The naming convention does not say what it
 * does directly and can be misleading.
 */

namespace WeatherAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewPlayerController : Controller
    {
        private readonly INewPlayerService newPlayerService;
        public NewPlayerController(INewPlayerService newPlayerService)
        {
            this.newPlayerService = newPlayerService;
        }
        [HttpGet("{PID}")]
        public async Task<List<NewPlayer>> PlayerInfo(int PID)
        {
            var playerInfo = await newPlayerService.PlayerInfo(PID);
            if (playerInfo == null)
            {
                //return NotFound();
            }
            return playerInfo;
        }
    }
}

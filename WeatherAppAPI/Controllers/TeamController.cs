using Microsoft.AspNetCore.Mvc;
using WeatherAppAPI.Entities;
using WeatherAppAPI.Repositories;

//This API done by Jachob Clark
/**
 * This controller is the controller for ITeamService.
 * ITeamService is a service that will get you the list
 * of teams in the same desired city. The naming convention
 * does not say what it does directly and can be misleading.
 */

namespace WeatherAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : Controller
    {
        private readonly ITeamService teamService;
        public TeamController(ITeamService teamService) 
        {
            this.teamService = teamService;
        }
        [HttpGet("{TeamLocation}")]
        public async Task<List<Team>> SameLocation(string TeamLocation)
        {
            var sameLocation = await teamService.SameLocation(TeamLocation);
            if (sameLocation == null )
            {
                //return NotFound();
            }
            return sameLocation;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using WeatherAppAPI.Entities;
using WeatherAppAPI.Repositories;

// This API was done by Andrew Forman

namespace WeatherAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchResultsController : Controller
    {
        private readonly IMatches matches;
        public MatchResultsController(IMatches matches)
        {
            this.matches = matches;
        }

        [HttpGet("{MatchResultsID}")]
        public async Task<ActionResult<List<MatchResults>>> GetMatchResults(int MatchResultsID)
        {
            var matchDetails = await matches.GetMatchResults(MatchResultsID);
            if (matchDetails == null)
            {
                return NotFound();
            }
            return matchDetails;
        }
    }
}
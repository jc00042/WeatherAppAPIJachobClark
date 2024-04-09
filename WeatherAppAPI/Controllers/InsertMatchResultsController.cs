using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Storage;
using System.Runtime.CompilerServices;
using WeatherAppAPI.Entities;
using WeatherAppAPI.Repositories;


// This API is by Braelynne Sandreth
/**
 * This controller is responsible for inserting match results into the Database.
 * It handles HTTP POST requests to InsertDataOperation match result data provided in the request body
 */

namespace WeatherAppAPI.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class InsertMatchResultsController : ControllerBase
    {
        private readonly IMatchResultsService matchResultsService;

        public InsertMatchResultsController(IMatchResultsService matchResultsService)
        {
            this.matchResultsService = matchResultsService;
        }
        [HttpPost]
        public async Task<IActionResult> InsertMatchResults(MatchResults matchResults)

    }

}
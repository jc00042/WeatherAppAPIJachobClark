using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Storage;
using System.Runtime.CompilerServices;
using WeatherAppAPI.Entities;
using WeatherAppAPI.Repositories;

// This API is by Braelynne Sandreth
/**
 * This controller is responsible for inserting matvh results into the Database
 * It handles HHTP POST requests to InsertDataOperation match reslut data provided indexer the request FromBodyAttribute.
 * */


namespace WeatherAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsertNewPlayerController : ControllerBase
    {
        private readonly INewPlayerService _newPlayerService;

        public InsertNewPlayerController(INewPlayerService newPlayerService)
        {
            _newPlayerService = newPlayerService;
        }
       // [HttpPost]
       // public async Task<IActionResult> InsertNewPlayer(NewPlayer newPlayer)



    }
}
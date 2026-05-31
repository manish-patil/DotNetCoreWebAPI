using F1API.Models;
using F1API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace F1API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RacesController(IRacesService service) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Race>>> GetRaces()
        {
            return await service.GetAllRacesAsync();
        }

        // [HttpGet("{season}/{round}/{raceName}")]
        [HttpGet("{season}/{round}")]
        public async Task<ActionResult<Race?>> GetRaceById(int season, int round)
        {
            var race = await service.GetRaceByIdAsync(season, round);

            if (race == null)
            {
                return NotFound("Race Not Found");
            }

            return race;
        }

        [HttpDelete("{season}/{round}")]
        public async Task<ActionResult<bool>> DeleteRaceById(int season, int round)
        { 
            var result = await service.DeleteRaceAsync(season, round);

            if (!result)
            {
                return BadRequest();
            }

            return result;
        }
    }
}


using F1API.DTOs;
using F1API.Models;
using F1API.Services;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        public async Task<ActionResult<Race?>> AddRace(CreateRaceRequest race)
        {
            var newRace = await service.AddRaceAsync(race);

            if (newRace == null)
            {
                return BadRequest();
            }

            return newRace;
        }

        [HttpPut]
        public async Task<ActionResult<bool>> UpdateRace(Race race)
        {
            bool raceUpdated = await service.UpdateRaceAsync(race);

            if (raceUpdated == false)
            {
                return BadRequest();
            }

            return true;
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> DeleteRace(int season, int round)
        {
            bool raceDeleted = await service.DeleteRaceAsync(season, round);

            if (raceDeleted == false)
            {
                return BadRequest();
            }

            return true;
        }
    }
}


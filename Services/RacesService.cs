using F1API.Data;
using F1API.DTOs;
using F1API.Models;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.EntityFrameworkCore;

namespace F1API.Services
{
    public class RacesService(AppDbContext context) : IRacesService
    {
        public async Task<List<Race>> GetAllRacesAsync()
        {
            return await context.Races.Include(r => r.Circuit).ThenInclude(c => c.Location).ToListAsync();
        }

        public async Task<Race?> GetRaceByIdAsync(int season, int round)
        {
            var race = await context.Races
                .Include(r => r.Circuit)
                .ThenInclude(c => c.Location)
                .FirstOrDefaultAsync(r => r.Season == season && r.Round == round);

            return race;
        }

        public async Task<Race?> AddRaceAsync(CreateRaceRequest race)
        {
            try
            {
                var newRace = new Race()
                {
                    Season = race.Season,
                    Round = race.Round,
                    RaceName = race.RaceName,
                    RaceDate = race.RaceDate,
                    CircuitId = race.CircuitId,
                };

                var _newRace = context.Races.Add(newRace);

                await context.SaveChangesAsync();

                return _newRace.Entity;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Creating Race");
            }
            
            return null;
        }

        public Task<bool> UpdateRaceAsync(Race race)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteRaceAsync(int season, int round)
        {
            Race raceToDelete = context.Races.FirstOrDefault(r => r.Season == season && r.Round == round);

            if (raceToDelete is null)
            {
                return false;
            }

            context.Races.Remove(raceToDelete);

            await context.SaveChangesAsync();

            return true;
        }
    }
}

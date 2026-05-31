using F1API.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace F1API.Services
{
    public class RacesService : IRacesService
    {
        static List<Race> races = new List<Race> {
            new Race {Season = 2026, Round = 1, RaceName = "Australia", RaceDate = new DateTime(2026, 3, 8), Circuit = new Circuit { CircuitName = "Melbourne Grand Prix Circuit", Location = new Location { City ="Melbourne", Country ="Australia"} } },
            new Race {Season = 2026, Round = 2, RaceName = "China", RaceDate = new DateTime(2026, 3, 15), Circuit = new Circuit { CircuitName = "Shanghai International Circuit", Location = new Location { City = "Shanghai", Country ="China"} } },
            new Race {Season = 2026, Round = 3, RaceName = "Japan", RaceDate = new DateTime(2026, 3, 29), Circuit = new Circuit { CircuitName = "Suzuka Circuit", Location = new Location { City ="Suzuka", Country ="Japan"} } },
        };
        public async Task<List<Race>> GetAllRacesAsync()
        {
            return await Task.FromResult(races);
        }

        // public async Task<Race?> GetRaceByIdAsync(int season, int round, string raceName)
        public async Task<Race?> GetRaceByIdAsync(int season, int round)
        {
            Race? race = races.FirstOrDefault(race => race.Season.Equals(season) && race.Round.Equals(round));

            return await Task.FromResult(race);
        }

        public Task<List<Race>> AddRaceAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteRaceAsync(int season, int round)
        {
            Race? race = races.FirstOrDefault(race => race.Season.Equals(season) && race.Round.Equals(round));

            if (race != null)             
            {
                races.Remove(race);

                Console.WriteLine($"Races after delete {races.Count}");
                return await Task.FromResult(true);
            }

            return await Task.FromResult(false);
        }

        public Task<bool> UpdateRaceAsync()
        {
            throw new NotImplementedException();
        }

        Task<Race> IRacesService.AddRaceAsync()
        {
            throw new NotImplementedException();
        }
    }
}

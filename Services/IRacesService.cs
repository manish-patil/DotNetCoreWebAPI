using F1API.Models;

namespace F1API.Services
{
    public interface IRacesService
    {
        Task<List<Race>> GetAllRacesAsync();

        //Task<Race?> GetRaceByIdAsync(int season, int round, string raceName);
        Task<Race?> GetRaceByIdAsync(int season, int round);

        Task<Race> AddRaceAsync();

        Task<bool> UpdateRaceAsync();

        Task<bool> DeleteRaceAsync(int season, int round);
    }
}

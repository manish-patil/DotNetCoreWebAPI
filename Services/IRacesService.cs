using F1API.DTOs;
using F1API.Models;

namespace F1API.Services
{
    public interface IRacesService
    {
        Task<List<Race>> GetAllRacesAsync();

        Task<Race?> GetRaceByIdAsync(int season, int round);

        //Task<Race?> AddRaceAsync(Race race);
        Task<Race?> AddRaceAsync(CreateRaceRequest request);

        Task<bool> UpdateRaceAsync(Race race);

        Task<bool> DeleteRaceAsync(int season, int round);
    }
}
